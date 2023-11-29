using AutoMapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.IdentityModel.Tokens;
using Project2.Model;
using Project2.DTOs;
using Project2.DTOs.CustomerDTOs;
using Project2.DTOs.DeliverDTOs;
using Project2.DTOs.MarketerDTOs;
using Project2.Model.Entities;
using Project2.Model.Helpers;
using Project2.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Net.Mail;
using Project2.DTOs.EmailDTOs;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Net;

namespace Project2.Repository.Services
{
    public class UserService : IUserService
    {
        public AppDbContext _DbContext { get; set; }
        private IConfiguration _Config;
        private IMapper _Mapper;

        public UserService(AppDbContext DbContext, IConfiguration Config, IMapper Mapper)
        {
            _DbContext = DbContext;
            _Config = Config;
            _Mapper = Mapper;
        }
       
        public override ApiResponse Login(LoginViewModel Login)
        {
            User? User = _DbContext.Users
                .FirstOrDefault(x => x.UserName.ToLower() == Login.UserName.ToLower());

            if (User == null)
                return new ApiResponse(false, "Invalid User Name");

            if (User.status.Equals(Data.Enum.AccountStatus.Active))
            {
                if (string.IsNullOrEmpty(Login.Role))
                {
                    string Role = string.Empty;

                    bool CheckIfItsCustomer = _DbContext.Customers
                        .Any(x => x.userId == User.UID);

                    if (CheckIfItsCustomer)
                        Login.Role = Data.Enum.UserType.Customer.ToString();

                    else
                    {
                        bool CheckIfItsMarketer = _DbContext.Marketers
                            .Any(x => x.userId == User.UID);

                        if (CheckIfItsMarketer)
                            Login.Role = Data.Enum.UserType.Marketer.ToString();

                        else
                        {
                            bool CheckIfItsDeliver = _DbContext.Delivers
                                .Any(x => x.userId == User.UID);

                            if (CheckIfItsDeliver)
                                Login.Role = Data.Enum.UserType.Deliver.ToString();
                            else
                            {
                                bool CheckIfItsMaintainers = _DbContext.Maintainers
                                    .Any(x => x.userId == User.UID);

                                if (CheckIfItsMaintainers)
                                    Login.Role = Data.Enum.UserType.Maintainer.ToString();
                                else
                                    Login.Role = Data.Enum.UserType.Admin.ToString();
                            }
                        }

                    }
                }
               

                byte[] Salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

                // Derive a 256-bit Subkey (Use HMACSHA256 With 100,000 Iterations)
                string Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: Login.Password,
                    salt: Salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 100000,
                    numBytesRequested: 256 / 8));

                bool Verified = (User.password == Password);

                if (!Verified)
                    return new ApiResponse(false, "Invalid Password");

                List<Claim> Claims = new List<Claim> {
                new Claim("UserId", User.UID.ToString()),
                new Claim("RandomGuid", Guid.NewGuid().ToString()),
                new Claim("UserName", User.UserName),
                new Claim("Role", Login.Role)
            };

                SymmetricSecurityKey Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Config["JWT:Key"]));
                SigningCredentials Credentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

                JwtSecurityToken TokenDetails = new JwtSecurityToken("http://localhost:53174/",
                  "http://localhost:53174/",
                  Claims,
                  expires: DateTime.Now.AddMinutes(30),
                  signingCredentials: Credentials);

                string TokenString = new JwtSecurityTokenHandler().WriteToken(TokenDetails);
                if (Login.Role.Equals(Data.Enum.UserType.Maintainer.ToString()))
                {
                    var ItsMaintainer = _DbContext.Maintainers
                        .FirstOrDefault(x => x.userId == User.UID);
                    if (ItsMaintainer == null) return new ApiResponse(false, "not found");

                    var respons = new
                    {
                        token = TokenString,
                        role = ItsMaintainer.roleName
                    };
                    return new ApiResponse(respons, "Success");
                }
                return new ApiResponse(TokenString, "Success");
            }
            else
                return new ApiResponse(false, " Your Account is an Inactive :( ");
        }

        public override async Task<ApiResponse> RegisterForCustomer(AddCustomerViewModel NewCustomer)
        {
            User NewUserEntity = _Mapper.Map<User>(NewCustomer.UserInformation);
            NewUserEntity.userType = Data.Enum.UserType.Customer;
            NewUserEntity.Name = NewCustomer.FName + " " + NewCustomer.LName;

            byte[] Salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            // Derive a 256-bit Subkey (Use HMACSHA256 With 100,000 Iterations)
            NewUserEntity.password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: NewCustomer.UserInformation.password,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            await _DbContext.Users.AddAsync(NewUserEntity);
            await _DbContext.SaveChangesAsync();

            Customer NewCustomerEntity = _Mapper.Map<Customer>(NewCustomer);

            NewCustomerEntity.userId = NewUserEntity.UID;
            NewCustomerEntity.age = AgeCalculation.GetAge(NewCustomer.Birthdate);

            _DbContext.Customers.Add(NewCustomerEntity);
            _DbContext.SaveChanges();

            return Login(new LoginViewModel()
            {
                UserName = NewCustomer.UserName,
                Password = NewCustomer.UserInformation.password,
                Role = Data.Enum.UserType.Customer.ToString()
            });
        }

        public override async Task<ApiResponse> RegisterForDeliver(int adminId , AddDeliverViewModel NewDeliver)
        {
            var admin = _DbContext.Users
             .FirstOrDefault(u => u.UID == adminId &&
             (u.userType.Equals(Data.Enum.UserType.Admin)));
            if (admin == null) return new ApiResponse(false, "You are not admin!");

            User NewUserEntity = _Mapper.Map<User>(NewDeliver.UserInformation);
            NewUserEntity.userType = Data.Enum.UserType.Deliver;
            NewUserEntity.Name = NewDeliver.Name;

            byte[] Salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            // Derive a 256-bit Subkey (Use HMACSHA256 With 100,000 Iterations)
            NewUserEntity.password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: NewDeliver.UserInformation.password,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            await _DbContext.Users.AddAsync(NewUserEntity);
            await _DbContext.SaveChangesAsync();

            Deliver NewDeliverEntity = _Mapper.Map<Deliver>(NewDeliver);

            NewDeliverEntity.userId = NewUserEntity.UID;

            _DbContext.Delivers.Add(NewDeliverEntity);
            _DbContext.SaveChanges();

            return Login(new LoginViewModel()
            {
                UserName = NewDeliver.UserName,
                Password = NewDeliver.UserInformation.password,
                // Role = Data.Enum.UserType.Deliver.ToString()
            });
        }

        public override async Task<ApiResponse> RegisterForMarketer(AddMarketerViewModel NewMarketer)
        {
            User NewUserEntity = _Mapper.Map<User>(NewMarketer.UserInformation);
            NewUserEntity.userType = Data.Enum.UserType.Marketer;
            NewUserEntity.Name = NewMarketer.Name;

            byte[] Salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            // Derive a 256-bit Subkey (Use HMACSHA256 With 100,000 Iterations)
            NewUserEntity.password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: NewMarketer.UserInformation.password,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            await _DbContext.Users.AddAsync(NewUserEntity);
            await _DbContext.SaveChangesAsync();

            Marketer NewMarketerEntity = _Mapper.Map<Marketer>(NewMarketer);

            NewMarketerEntity.userId = NewUserEntity.UID;

            _DbContext.Marketers.Add(NewMarketerEntity);
            _DbContext.SaveChanges();

            return Login(new LoginViewModel()
            {
                UserName = NewMarketer.UserName,
                Password = NewMarketer.UserInformation.password,
                // Role = Data.Enum.UserType.Marketer.ToString()
            });
        }

        public override ApiResponse ForgetPassword(PasswordResetRequest request)
        {
            var user = _DbContext.Users.FirstOrDefault(u => u.Email == request.Email);
            if (user == null)
            {
                return new ApiResponse(false,"Invaliad Email.");
            }

            // إنشاء رمز عشوائي وحفظه في جدول المستخدمين
            var resetCode = GenerateResetCode();
            user.ResetCode = resetCode;
            user.ResetPassToken = CreateRamdomToken();
            _DbContext.SaveChanges();

            // إرسال رمز إعادة التعيين عبر البريد الإلكتروني
            SendResetCodeEmail(request.Email, resetCode);
            return new ApiResponse(user.ResetPassToken , "Success");
        }

        public override ApiResponse VerifyResetCode(string token , VerifyCodeViewModel verifyCode )
        {
            var user = _DbContext.Users.FirstOrDefault(u => u.ResetPassToken == token);
            if (user == null)
            {
                return new ApiResponse(false ,"Invalid token");
            }

            if (user.ResetCode != verifyCode.code)
            {
                return new ApiResponse(false,"Invalid code");
            }
            return new ApiResponse(true, "Success");
        }

        public override ApiResponse ChangePassword(string token, ResetPasswordViewModel resetPassword)
        {
            var user = _DbContext.Users.FirstOrDefault(u => u.ResetPassToken == token);
            if (user == null)
            {
                return new ApiResponse(false,"");
            }
            user.password = Encryption.pass(resetPassword.NewPassword);
            user.ResetCode = null;
            user.ResetPassToken = null;
            _DbContext.SaveChanges();

            return new ApiResponse(true, "Success");
        }

        private string GenerateResetCode()
        {
            var random = new Random();
            var resetCode = random.Next(1000, 9999).ToString();

            return resetCode;
        }

        private void SendResetCodeEmail(string email, string code)
        {
            var mail = "ashop0992@gmail.com";
            var pass = "homyshop1234";

            var message = new MailMessage();

            message.To.Add(email);
            message.From = new MailAddress(mail);
            message.Subject = "رمز إعادة التعيين";
            message.Body = $"رمز إعادة التعيين الخاص بك هو: {code}";

            //var sub = "رمز إعادة التعيين";
            //var body = $"رمز إعادة التعيين الخاص بك هو: {code}";

            var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Credentials = new NetworkCredential(mail, pass);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            
            //smtpClient.SendMailAsync(
            //    new MailMessage(from: mail,
            //                    to: email,
            //                    sub,
            //                    body));
            //var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            //{
            //    Credentials = new NetworkCredential("38c48b0db16f08", "********7376"),
            //    EnableSsl = true
            //};

            smtpClient.Send(message);
        }

        private string CreateRamdomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }

    }
}