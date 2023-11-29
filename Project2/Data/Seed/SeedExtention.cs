using Microsoft.EntityFrameworkCore;
using Project2.Model.Entities;
using Project2.Model.Helpers;

namespace Project2.Data.Seed
{
    public static class SeedExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UID = 1,
                    Name = "Admin",
                    UserName = "admin",
                    Email = "ashop0992@gmail.com", 
                    password = Encryption.pass("admin@1234"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Admin
                },
                new User
                {
                    UID = 2,
                    Name = "Zainab Ali",
                    UserName ="zainabali",
                    Email = "za562925@gmail.com",
                    password = Encryption.pass("zainabzainab"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 3,
                    Name = "Razan Ali",
                    UserName = "razanali",
                    Email = "razanali@gmail.com",
                    password = Encryption.pass("razanrazan"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 4,
                    Name = "Zain Ali",
                    UserName = "zainali",
                    Email = "zainali@gmail.com",
                    password = Encryption.pass("zainzain"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 5,
                    Name = "Raghad Ali",
                    UserName = "raghadali",
                    Email = "raghadali@gmail.com",
                    password = Encryption.pass("raghadraghad"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 6,
                    Name = "Aya Ali",
                    UserName = "ayaali",
                    Email = "ayaali@gmail.com",
                    password = Encryption.pass("ayaaya"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 7,
                    Name = "Arwa Essa",
                    UserName = "arwaessa",
                    Email = "arwaessa@gmail.com",
                    password = Encryption.pass("arwaarwa"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 8,
                    Name = "Osama Ali",
                    UserName = "osamaali",
                    Email = "osamaali@gmail.com",
                    password = Encryption.pass("osamaosama"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 9,
                    Name = "Saosan Ali",
                    UserName = "saosanali",
                    Email = "saosanali@gmail.com",
                    password = Encryption.pass("saosansaosan"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 10,
                    Name = "Reem Manssor",
                    UserName = "reemmanssor",
                    Email = "reemmanssor@gmail.com",
                    password = Encryption.pass("reemreem"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 11,
                    Name = "Majd Esber",
                    UserName = "majdesber",
                    Email = "majdesber@gmail.com",
                    password = Encryption.pass("majdmajd"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 12,
                    Name = "Rama Kaheel",
                    UserName = "ramakaheel",
                    Email = "ramakaheel@gmail.com",
                    password = Encryption.pass("ramarama"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 13,
                    Name = "Mohamad Ahmad",
                    UserName = "mohamadahmad",
                    Email = "mohamadahmad@gmail.com",
                    password = Encryption.pass("mohamadmohamad"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 14,
                    Name = "Abeer Ali",
                    UserName = "abeerali",
                    Email = "abeerali@gmail.com",
                    password = Encryption.pass("abeerabeer"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 15,
                    Name = "Samaher Ali",
                    UserName = "samaherali",
                    Email = "samaherali@gmail.com",
                    password = Encryption.pass("samahersamaher"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 16,
                    Name = "Rama Abd-AlHak",
                    UserName = "ramaabdalhak",
                    Email = "ramaabdalhak@gmail.com",
                    password = Encryption.pass("ramaramarama"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 17,
                    Name = "Roua Edress",
                    UserName = "rouaedress",
                    Email = "rouaedress@gmail.com",
                    password = Encryption.pass("rouaroua"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Customer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 18,
                    Name = "Four Hundred",
                    UserName = "fourhundred",
                    Email = "customer.service@400.sy",
                    password = Encryption.pass("400@400"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Marketer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 19,
                    Name = "CASUCCI",
                    UserName = "casucci",
                    Email = "casucci@gmail.com",
                    password = Encryption.pass("casucci@casucci"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Marketer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 20,
                    Name = "4BODY",
                    UserName = "4body",
                    Email = "forbody@gmail.com",
                    password = Encryption.pass("4body@4body"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Marketer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 21,
                    Name = "DIADORA",
                    UserName = "diadora",
                    Email = "syria@zarzourgroup.com",
                    password = Encryption.pass("diadora@diadora"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Marketer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 22,
                    Name = "Mixed colors of batti",
                    UserName = "batti",
                    Email = "info@batticolors.com",
                    password = Encryption.pass("batti@batti"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Marketer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 23,
                    Name = "Movo delivery",
                    UserName = "movo",
                    Email = "info@movo.delivery",
                    password = Encryption.pass("movo@@movo"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Deliver,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 24,
                    Name = "Al Kadmous",
                    UserName = "alkadmous",
                    Email = "eatery@gmail.com",
                    password = Encryption.pass("kadmous@@kadmous"),
                    Billfold = 1000000,
                    userType = Enum.UserType.Deliver,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 25,
                    Name = "Ahmad Mohseen",
                    UserName = "ahmadmohseen",
                    Email = "maintainer1@gmail.com",
                    password = Encryption.pass("ahmad@maint"),
                    Billfold = 0,
                    userType = Enum.UserType.Maintainer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 26,
                    Name = "Fares Monzer",
                    UserName = "faresmonzer",
                    Email = "maintainer2@gmail.com",
                    password = Encryption.pass("fares@maint"),
                    Billfold = 0,
                    userType = Enum.UserType.Maintainer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 27,
                    Name = "Kais Salem",
                    UserName = "kaissalem",
                    Email = "maintainer3@gmail.com",
                    password = Encryption.pass("kais@maint"),
                    Billfold = 0,
                    userType = Enum.UserType.Maintainer,
                    status = Enum.AccountStatus.Active
                },
                new User
                {
                    UID = 28,
                    Name = "Mohanad Mahmood",
                    UserName = "mohanadmahmood",
                    Email = "maintainer4@gmail.com",
                    password = Encryption.pass("mohanad@maint"),
                    Billfold = 0,
                    userType = Enum.UserType.Maintainer,
                    status = Enum.AccountStatus.Active
                }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    FName = "Zainab",
                    LName = "Ali",
                    UserName = "zainabali",
                    phoneNumber = 963937239433,
                    Birthdate = DateTime.Parse("1999-08-25"),
                    photo = "https://media.istockphoto.com/id/1363312796/photo/blue-hydrangea-background.webp?s=1024x1024&w=is&k=20&c=EEPfUAN5JhvnvjKV1vza_Tq2i-Oicya4joqZCAkgTQA=",
                    userId = 2,
                    Point = 200,
                    city = "Damascus",
                    zone = "Qatana",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1999-08-25")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 2,
                    FName = "Razan",
                    LName = "Ali",
                    UserName = "razanali",
                    phoneNumber = 963996902853,
                    Birthdate = DateTime.Parse("2002-02-18"),
                    photo = "https://images.unsplash.com/photo-1519181245277-cffeb31da2e3?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80",
                    userId = 3,
                    Point = 230,
                    city = "Damascus",
                    zone = "Qatana",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("2002-02-18")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 3,
                    FName = "Zain",
                    LName = "Ali",
                    UserName = "zainali",
                    phoneNumber = 963936851060,
                    Birthdate = DateTime.Parse("2006-08-28"),
                    photo = "https://plus.unsplash.com/premium_photo-1677916317230-d9b78d675264?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=388&q=80",
                    userId = 4,
                    Point = 398,
                    city = "Damascus",
                    zone = "Qatana",
                    gender = "Male",
                    age = AgeCalculation.GetAge(DateTime.Parse("2006-08-28")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 4,
                    FName = "Raghad",
                    LName = "Ali",
                    UserName = "raghadali",
                    phoneNumber = 963934470881,
                    Birthdate = DateTime.Parse("2008-06-19"),
                    photo = "https://images.unsplash.com/photo-1530533718754-001d2668365a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80",
                    userId = 5,
                    Point = 100,
                    city = "Damascus",
                    zone = "Qatana",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("2008-06-19")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 5,
                    FName = "Aya",
                    LName = "Ali",
                    UserName = "ayaali",
                    phoneNumber = 963934470881,
                    Birthdate = DateTime.Parse("2009-12-24"),
                    photo = "https://images.unsplash.com/photo-1571149828506-c48f1610314b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80",
                    userId = 6,
                    Point = 100,
                    city = "Damascus",
                    zone = "Qatana",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("2009-12-24")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 6,
                    FName = "Arwa",
                    LName = "Essa",
                    UserName = "arwaessa",
                    phoneNumber = 963934470881,
                    Birthdate = DateTime.Parse("1973-11-25"),
                    photo = "https://images.unsplash.com/photo-1436891620584-47fd0e565afb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
                    userId = 7,
                    Point = 300,
                    city = "Damascus",
                    zone = "Qatana",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1973-11-25")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 7,
                    FName = "Osama",
                    LName = "Ali",
                    UserName = "osamaali",
                    phoneNumber = 963936851941,
                    Birthdate = DateTime.Parse("1962-05-20"),
                    photo = "https://images.unsplash.com/photo-1682686580036-b5e25932ce9a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=775&q=80",
                    userId = 8,
                    Point = 500,
                    city = "Damascus",
                    zone = "Qatana",
                    gender = "Male",
                    age = AgeCalculation.GetAge(DateTime.Parse("1962-05-20")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 8,
                    FName = "Saosan",
                    LName = "Ali",
                    UserName = "saosanali",
                    phoneNumber = 963985920017,
                    Birthdate = DateTime.Parse("1970-03-17"),
                    photo = "https://images.unsplash.com/photo-1683357974024-373448bbf733?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
                    userId = 9,
                    Point = 346,
                    city = "Damascus",
                    zone = "Mazah",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1970-03-17")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 9,
                    FName = "Reem",
                    LName = "Manssor",
                    UserName = "reemmanssor",
                    phoneNumber = 963998784139,
                    Birthdate = DateTime.Parse("1998-02-01"),
                    photo = "https://images.unsplash.com/photo-1528697203043-733dafdaa316?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=812&q=80",
                    userId = 10,
                    Point = 100,
                    city = "Damascus",
                    zone = "Moaadameah",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1998-02-01")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 10,
                    FName = "Majd",
                    LName = "Esber",
                    UserName = "majdesber",
                    phoneNumber = 963995755940,
                    Birthdate = DateTime.Parse("1997-03-20"),
                    photo = "https://images.unsplash.com/photo-1688560722687-7d4d5fb8ff8f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80",
                    userId = 11,
                    Point = 100,
                    city = "Damascus",
                    zone = "Dummar",
                    gender = "Male",
                    age = AgeCalculation.GetAge(DateTime.Parse("1997-03-20")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 11,
                    FName = "Rama",
                    LName = "Kaheel",
                    UserName = "ramakaheel",
                    phoneNumber = 963935470669,
                    Birthdate = DateTime.Parse("1998-01-01"),
                    photo = "https://images.unsplash.com/photo-1688728489565-8c155cf71c64?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=464&q=80",
                    userId = 12,
                    Point = 100,
                    city = "Damascus",
                    zone = "Kafar-sosah",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1998-01-01")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 12,
                    FName = "Mohamad",
                    LName = "Ahmad",
                    UserName = "mohamadahmad",
                    phoneNumber = 963934873326,
                    Birthdate = DateTime.Parse("1963-12-15"),
                    photo = "https://images.unsplash.com/photo-1691764548951-c3fdcf90544a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
                    userId = 13,
                    Point = 900,
                    city = "Damascus",
                    zone = "Mazah",
                    gender = "Male",
                    age = AgeCalculation.GetAge(DateTime.Parse("1963-12-15")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 13,
                    FName = "Abeer",
                    LName = "Ali",
                    UserName = "abeerali",
                    phoneNumber = 963983739169,
                    Birthdate = DateTime.Parse("1975-01-01"),
                    photo = "https://images.unsplash.com/photo-1493612276216-ee3925520721?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=464&q=80",
                    userId = 14,
                    Point = 230,
                    city = "Lattakia",
                    zone = "Jablah",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1975-01-01")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 14,
                    FName = "Samaher",
                    LName = "Ali",
                    UserName = "samaherali",
                    phoneNumber = 963967811417,
                    Birthdate = DateTime.Parse("1973-11-01"),
                    photo = "https://images.unsplash.com/photo-1688728459248-c8dcc2c4f33b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
                    userId = 15,
                    Point = 240,
                    city = "Lattakia",
                    zone = "Jablah",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1973-11-01")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 15,
                    FName = "Rama",
                    LName = "Abd-AlHak",
                    UserName = "ramaabdalhak",
                    phoneNumber = 963993991918,
                    Birthdate = DateTime.Parse("1999-03-03"),
                    photo = "https://images.unsplash.com/photo-1582769923195-c6e60dc1d8dc?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=464&q=80",
                    userId = 16,
                    Point = 300,
                    city = "Damascus",
                    zone = "Mohajreen",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1999-03-03")),
                    CreatedDate = DateTime.Now
                },
                new Customer
                {
                    Id = 16,
                    FName = "Roua",
                    LName = "Edress",
                    UserName = "rouaedress",
                    phoneNumber = 963947222344,
                    Birthdate = DateTime.Parse("1999-10-23"),
                    photo = "https://images.unsplash.com/photo-1483412033650-1015ddeb83d1?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=873&q=80",
                    userId = 17,
                    Point = 300,
                    city = "Damascus",
                    zone = "Sabborah",
                    gender = "Female",
                    age = AgeCalculation.GetAge(DateTime.Parse("1999-10-23")),
                    CreatedDate = DateTime.Now
                }
                );

            modelBuilder.Entity<Marketer>().HasData(
                new Marketer
                  {
                      Id = 1,
                      Name = "Four Hundred",
                      UserName = "fourhundred",
                      phoneNumber = 963116912400,
                      mobileNumber = 963993100400,
                      photo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/072011/four_hundred.png?itok=2vTbTRms",
                      Point = 200000,
                      userId =18,
                      CreatedDate = DateTime.Now,
                      city = "Damascus",
                      zone = "Fahhameh"
                  },
                new Marketer
                {
                    Id = 2,
                    Name = "CASUCCI",
                    UserName = "casucci",
                    phoneNumber = 2240926,
                    mobileNumber = 963932163000,
                    photo = "https://www.casucci-fashion.com/site/img/uploads1/larg/branches_20211101051244_56.jpg",
                    Point = 200000,
                    userId = 19,
                    CreatedDate = DateTime.Now,
                    city = "Damascus",
                    zone = "Fahhameh"
                },
                new Marketer
                {
                    Id = 3,
                    Name = "4BODY",
                    UserName = "4body",
                    phoneNumber = 963112266170,
                    mobileNumber = 963933320070,
                    photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYzjEqiqABoKEHwf3djup6cR_9GsRo32Io7X1Kn6cyvQ&s",
                    Point = 200000,
                    userId = 20,
                    CreatedDate = DateTime.Now,
                    city = "Damascus",
                    zone = "Fahhameh"
                },
                new Marketer
                {
                    Id = 4,
                    Name = "DIADORA",
                    UserName = "diadora",
                    phoneNumber = 5440405,
                    mobileNumber = 0,
                    photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Diadora_logo.png/1200px-Diadora_logo.png",
                    Point = 200000,
                    userId = 21,
                    CreatedDate = DateTime.Now,
                    city = "Damascus",
                    zone = "Fahhameh"
                },
                new Marketer
                {
                    Id = 5,
                    Name = "Mixed colors of batti",
                    UserName = "batti",
                    phoneNumber = 0,
                    mobileNumber = 963989312094,
                    photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRkrCI_2KyBPWDQBPxbnM2Lth9rdH9KJgzod8jmqucRn7gApPIKSU8jsOrGyrzrNbbCtCI&usqp=CAU",
                    Point = 200000,
                    userId = 22,
                    CreatedDate = DateTime.Now,
                    city = "Damascus",
                    zone = "Fahhameh"
                }
                );

            modelBuilder.Entity<Deliver>().HasData(
                new Deliver
                {
                     Id = 1,
                     Name = "Movo delivery",
                     UserName = "movo",
                     mobileNumber = 0,
                     phoneNumber = 0118054000,
                     photo = "https://lh3.googleusercontent.com/p/AF1QipPUuFAL_44ng3qOaOG4aoqFzbHJmIRcheBwW_SD=s680-w680-h510",
                     userId = 23,
                     city = "Damascus",
                     zone = "Masaab ebn Omeer",
                     CreatedDate = DateTime.Now
                },
                new Deliver
                {
                    Id = 2,
                    Name = "Al Kadmous",
                    UserName = "alkadmous",
                    mobileNumber = 0,
                    phoneNumber = 0113325002,
                    photo = "https://www.alkadmous.com/images/logo.png",
                    userId = 24,
                    city = "Damascus",
                    zone = "Al Hamra Street",
                    CreatedDate = DateTime.Now
                }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "User Manager",
                    Description = "Blocking Users"
                },
                new Role
                {
                    Id = 2,
                    Name = "Complaint Manager",
                    Description = "Handling Complaints"
                },
                new Role
                {
                    Id = 3,
                    Name = "Popularization Manager",
                    Description = "Processing Popularization"
                },
                new Role
                {
                    Id = 4,
                    Name = "Tender & Auction Manager",
                    Description = "Canceling Tender or Auction"
                }

                );
            modelBuilder.Entity<Maintainer>().HasData(
                new Maintainer
                {
                    Id = 1,
                    FName = "Ahmad",
                    LName = "Mohseen",
                    UserName = "ahmadmohseen",
                    roleName = "User Manager",
                    userId = 25,
                    RoleId = 1
                },
                new Maintainer
                {
                    Id = 2,
                    FName = "Fares",
                    LName = "Monzer",
                    UserName = "faresmonzer",
                    roleName = "Complaint Manager",
                    userId = 26,
                    RoleId = 2
                },
                new Maintainer
                {
                    Id = 3,
                    FName = "Kais",
                    LName = "Salem",
                    UserName = "kaissalem",
                    roleName = "Popularization Manager",
                    userId = 27,
                    RoleId = 3
                },
                new Maintainer
                {
                    Id = 4,
                    FName = "Mohanad",
                    LName = "Mahmood",
                    UserName = "mohanadmahmood",
                    roleName = "Tender & Auction Manager",
                    userId = 28,
                    RoleId = 4
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {//5
                    id = 1,
                    Name = "FRUIT OF DESIRE collection",
                    productType = "T-Shirt",
                    Price = 50000,
                    point = 50,
                    photo = "https://media.istockphoto.com/id/1419697140/photo/sleeveless-cute-shirt-isolated-on-white-background.jpg?s=1024x1024&w=is&k=20&c=-NML3t1Fi34_h4AI6AUOo25s8ScIBvdQF1WH9GA_X9w=",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//5
                    id = 2,
                    Name = "Women's suit",
                    productType = "Suit",
                    Price = 260000,
                    point = 260,
                    photo = "https://images.unsplash.com/photo-1614786269829-d24616faf56d?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=435&q=80",
                    ProductStatus = Enum.ProductStatus.Offer,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//5
                    id = 3,
                    Name = "Women's dress",
                    productType = "Dress",
                    Price = 240000,
                    point = 240,
                    photo = "https://images.unsplash.com/photo-1466694474381-de12210d82ac?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=388&q=80",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//5
                    id = 4,
                    Name = "Cotton blouse",
                    productType = "Blouse",
                    Price = 120000,
                    point = 120,
                    photo = "https://images.unsplash.com/photo-1568732939097-b949d8c03cc1?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//1
                    id = 5,
                    Name = "Half Sleeve Shirt",
                    productType = "T-Shirt",
                    Price = 130000,
                    point = 130,
                    photo = "https://media.istockphoto.com/id/1149139091/photo/blank-blue-mens-short-sleeve-summer-shirt-front-isolated-on-white-background-creased-wrinkle.webp?b=1&s=170667a&w=0&k=20&c=BOS13CMzBmgYfdEwRWX-RGp2B7J35a1Tw1e5pmH1lSw=",
                    ProductStatus = Enum.ProductStatus.Offer,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//1
                    id = 6,
                    Name = "Kids Clothes",
                    productType = "Clothes",
                    Price = 200000,
                    point = 200,
                    photo = "https://images.unsplash.com/photo-1519238263530-99bdd11df2ea?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=301&q=80",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//1
                    id = 7,
                    Name = "Men T-shirt",
                    productType = "T-Shirt",
                    Price = 95000,
                    point = 95,
                    photo = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=580&q=80",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//4
                    id = 8,
                    Name = "TRACK JACKET PIRATI",
                    productType = "Jacket",
                    Price = 220000,
                    point = 220,
                    photo = "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dw6ea061e6/images/hi-res/502.181066_20002_10_HR.jpg?sw=1920",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 9,
                    Name = "HOODIE 2030",
                    productType = "Hoodie",
                    Price = 92000,
                    point = 92,
                    photo = "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dw4ab93b55/images/hi-res/502.179395_60063_10_HR.jpg?sw=1920",
                    ProductStatus = Enum.ProductStatus.Discount,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 10,
                    Name = "T-SHIRT LS PIRATI",
                    productType = "T-Shirt",
                    Price = 91000,
                    point = 91,
                    photo = "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dwe0de2333/images/hi-res/502.181067_20002_10_HR.jpg?sw=1920",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 11,
                    Name = "SS POLO ICON",
                    productType = "T-Shirt",
                    Price = 75000,
                    point = 75,
                    photo = "https://www.diadora.com/dw/image/v2/BBPK_PRD/on/demandware.static/-/Sites-diadora-master/default/dwe0de2333/images/hi-res/502.181067_20002_10_HR.jpg?sw=1920",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//3
                    id = 12,
                    Name = "Woman Sports Wear",
                    productType = "Clothe",
                    Price = 175000,
                    point = 175,
                    photo = "https://media.istockphoto.com/id/1402936271/photo/flat-lay-composition-with-sport-clothes-on-color-background-top-view.jpg?s=1024x1024&w=is&k=20&c=INSeuHIh6InTCMLARv_Wm2Qvt0tdSKpOnfQNA_qD8IM=",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 13,
                    Name = "Men Sports Wear",
                    productType = "Clothe",
                    Price = 175000,
                    point = 175,
                    photo = "https://media.istockphoto.com/id/155601795/photo/mannequin-at-fashion-store.jpg?s=1024x1024&w=is&k=20&c=7_uOci7R8S0iFM4Ru9ULjhCe23Kk-F1lClRHZiql-0g=",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 14,
                    Name = "Sports Jacket",
                    productType = "Jacket",
                    Price = 150000,
                    point = 150,
                    photo = "https://media.istockphoto.com/id/1369103424/photo/blank-black-windbreaker-mock-up-front-and-side-view.jpg?s=1024x1024&w=is&k=20&c=R2J4w5UUcxck5a9Ixemx_1SlZmOT3NxU0Cohjt_KTxI=",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                }, new Product
                {
                    id = 15,
                    Name = "Sports Pants",
                    productType = "Pants",
                    Price = 250000,
                    point = 250,
                    photo = "https://media.istockphoto.com/id/1406303920/photo/womens-sweatpants-sport.jpg?s=1024x1024&w=is&k=20&c=ldGWRr1rehqR4g8GrMfFb_lyT_0iwz-6VFB45qUah0A=",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {//2
                    id = 16,
                    Name = "Marines pants",
                    productType = "Pant",
                    Price = 180000,
                    point = 180,
                    photo = "https://images.unsplash.com/photo-1594633312681-425c7b97ccd1?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=387&q=80",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                }, new Product
                {
                    id = 17,
                    Name = "Linen pants",
                    productType = "Pant",
                    Price = 125000,
                    point = 125,
                    photo = "https://media.istockphoto.com/id/1312418321/photo/white-linen-pant-formal-trouser.jpg?s=1024x1024&w=is&k=20&c=Ao83-deGCtRbXa3pBbzfCpGS2tMRdZneh1e5HAWpKOE=",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 18,
                    Name = "Wide women's pants",
                    productType = "Pant",
                    Price = 120000,
                    point = 120,
                    photo = "https://media.istockphoto.com/id/1431894849/photo/beautiful-young-woman-in-total-black-look-sleeveless-crop-top-wide-leg-pant-fashion-model.jpg?s=1024x1024&w=is&k=20&c=XmIMCAdwMt65BR2dLfmFtv483XRxMJij6Gj3qIApI0E=",
                    ProductStatus =Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 19,
                    Name = "Women's Jeans Pants",
                    productType = "Pant",
                    Price = 120000,
                    point = 120,
                    photo = "https://images.unsplash.com/photo-1475178626620-a4d074967452?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=386&q=80",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 20,
                    Name = "Women's Linen Pants",
                    productType = "Pant",
                    Price = 37000,
                    point = 37,
                    photo = "https://media.istockphoto.com/id/1400106591/photo/blank-white-man-pants-mockup-front-and-back-view.jpg?s=1024x1024&w=is&k=20&c=SSXGsf-2-YznRdhBqZdlHGhXJFxqBIZmLnrUqMiY3e8=",
                    ProductStatus = Enum.ProductStatus.Offer,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    id = 21,
                    Name = "Women's sweatpants",
                    productType = "Pant",
                    Price = 60000,
                    point = 60,
                    photo = "https://media.istockphoto.com/id/1406303920/photo/womens-sweatpants-sport.jpg?s=1024x1024&w=is&k=20&c=ldGWRr1rehqR4g8GrMfFb_lyT_0iwz-6VFB45qUah0A=",
                    ProductStatus = Enum.ProductStatus.None,
                    CreatedDate = DateTime.Now
                }
                );

            modelBuilder.Entity<ProductColor>().HasData(
                new ProductColor
                {
                    Id = 1,
                    color = "Black",
                    productId = 1
                },
                new ProductColor
                {
                    Id = 2,
                    color = "Yellow",
                    productId = 1
                },
                new ProductColor
                {
                    Id = 3,
                    color = "Gray",
                    productId = 1
                },

                new ProductColor
                {
                    Id = 4,
                    color = "Green",
                    productId = 2
                },
                new ProductColor
                {
                    Id = 5,
                    color = "Black",
                    productId = 2
                },
                new ProductColor
                {
                    Id = 6,
                    color = "Pink",
                    productId = 2
                },
                new ProductColor
                {
                    Id = 7,
                    color = "White",
                    productId = 2
                },
                new ProductColor
                {
                    Id = 8,
                    color = "Blue",
                    productId = 3
                },
                new ProductColor
                {
                    Id = 9,
                    color = "Pink",
                    productId = 3
                },
                new ProductColor
                {
                    Id = 10,
                    color = "Orange",
                    productId = 3
                },
                new ProductColor
                {
                    Id = 11,
                    color = "Green",
                    productId = 3
                },
                new ProductColor
                {
                    Id = 12,
                    color = "White",
                    productId = 3
                },
                new ProductColor
                {
                    Id = 13,
                    color = "Red",
                    productId = 4
                },
                new ProductColor
                {
                    Id = 14,
                    color = "Black",
                    productId = 4
                },
                new ProductColor
                {
                    Id = 15,
                    color = "Pink",
                    productId = 4
                },
                new ProductColor
                {
                    Id = 16,
                    color = "Gray",
                    productId = 4
                },
                new ProductColor
                {
                    Id = 17,
                    color = "Blue",
                    productId = 5
                },
                new ProductColor
                {
                    Id = 18,
                    color = "Blue",
                    productId = 6
                },
                new ProductColor
                {
                    Id = 19,
                    color = "Green",
                    productId = 6
                },
                new ProductColor
                {
                    Id = 20,
                    color = "Gray",
                    productId = 6
                },
                new ProductColor
                {
                    Id = 21,
                    color = "White",
                    productId = 6
                },
                new ProductColor
                {
                    Id = 22,
                    color = "Black",
                    productId = 7
                },
                new ProductColor
                {
                    Id = 23,
                    color = "White",
                    productId = 8
                },
                new ProductColor
                {
                    Id = 24,
                    color = "Blue",
                    productId = 9
                },
                new ProductColor
                {
                    Id = 25,
                    color = "White",
                    productId = 10
                },
                new ProductColor
                {
                    Id = 26,
                    color = "White",
                    productId = 11
                },
                new ProductColor
                {
                    Id = 27,
                    color = "Blue",
                    productId = 11
                },
                new ProductColor
                {
                    Id = 28,
                    color = "Black",
                    productId = 11
                },
                new ProductColor
                {
                    Id = 29,
                    color = "White",
                    productId = 12
                },
                new ProductColor
                {
                    Id = 30,
                    color = "Black",
                    productId = 12
                },
                new ProductColor
                {
                    Id = 31,
                    color = "Blue",
                    productId = 12
                },

                new ProductColor
                {
                    Id = 32,
                    color = "Red",
                    productId = 12
                },
                new ProductColor
                {
                    Id = 33,
                    color = "White",
                    productId = 13
                },
                new ProductColor
                {
                    Id = 34,
                    color = "Black",
                    productId = 13
                },
                new ProductColor
                {
                    Id = 35,
                    color = "Red",
                    productId = 13
                },
                new ProductColor
                {
                    Id = 36,
                    color = "Blue",
                    productId = 14
                },
                new ProductColor
                {
                    Id = 37,
                    color = "Black",
                    productId = 14
                },
                new ProductColor
                {
                    Id = 38,
                    color = "White",
                    productId = 14
                },
                new ProductColor
                {
                    Id = 39,
                    color = "White",
                    productId = 15
                },
                new ProductColor
                {
                    Id = 40,
                    color = "BlacK",
                    productId = 15
                },
                new ProductColor
                {
                    Id = 41,
                    color = "Gray",
                    productId = 15
                },
                new ProductColor
                {
                    Id = 42,
                    color = "Gray",
                    productId = 16
                },
                new ProductColor
                {
                    Id = 43,
                    color = "Green",
                    productId = 17
                },
                new ProductColor
                {
                    Id = 44,
                    color = "Blue",
                    productId = 18
                },
                new ProductColor
                {
                    Id = 45,
                    color = "Light Blue",
                    productId = 19
                },
                new ProductColor
                {
                    Id = 46,
                    color = "Beige",
                    productId = 20
                },
                new ProductColor
                {
                    Id = 47,
                    color = "White",
                    productId = 20
                },
                new ProductColor
                {
                    Id = 48,
                    color = "Blue",
                    productId = 21
                }
                );
            modelBuilder.Entity<ProductSize>().HasData(
                new ProductSize
                {
                    Id = 1,
                    size = "L",
                    productId = 1
                },
                new ProductSize
                {
                    Id = 2,
                    size = "M",
                    productId = 1
                },
                new ProductSize
                {
                    Id = 3,
                    size = "S",
                    productId = 1
                },
                new ProductSize
                {
                    Id = 4,
                    size = "L",
                    productId = 2
                },
                new ProductSize
                {
                    Id = 5,
                    size = "M",
                    productId = 2
                },
                new ProductSize
                {
                    Id = 6,
                    size = "XL",
                    productId = 2
                },
                new ProductSize
                {
                    Id = 7,
                    size = "S",
                    productId = 2
                },
                new ProductSize
                {
                    Id = 8,
                    size = "M",
                    productId = 3
                },
                new ProductSize
                {
                    Id = 9,
                    size = "S",
                    productId = 3
                },
                new ProductSize
                {
                    Id = 10,
                    size = "L",
                    productId = 3
                },
                new ProductSize
                {
                    Id = 11,
                    size = "XL",
                    productId = 3
                },
                new ProductSize
                {
                    Id = 12,
                    size = "S",
                    productId = 4
                },
                new ProductSize
                {
                    Id = 13,
                    size = "M",
                    productId = 4
                },
                new ProductSize
                {
                    Id = 14,
                    size = "L",
                    productId = 4
                },
                new ProductSize
                {
                    Id = 15,
                    size = "M",
                    productId = 5
                },
                new ProductSize
                {
                    Id = 16,
                    size = "S",
                    productId = 6
                },
                new ProductSize
                {
                    Id = 17,
                    size = "M",
                    productId = 7
                },
                new ProductSize
                {
                    Id = 18,
                    size = "L",
                    productId = 7
                },
                new ProductSize
                {
                    Id = 19,
                    size = "S",
                    productId = 8
                },
                new ProductSize
                {
                    Id = 20,
                    size = "L",
                    productId = 8
                },
                new ProductSize
                {
                    Id = 21,
                    size = "XL",
                    productId = 8
                },
                new ProductSize
                {
                    Id = 22,
                    size = "S",
                    productId = 9
                },
                new ProductSize
                {
                    Id = 23,
                    size = "XS",
                    productId = 9
                },
                new ProductSize
                {
                    Id = 24,
                    size = "M",
                    productId = 9
                },
                new ProductSize
                {
                    Id = 25,
                    size = "L",
                    productId = 9
                },
                new ProductSize
                {
                    Id = 26,
                    size = "XL",
                    productId = 9
                },
                new ProductSize
                {
                    Id = 27,
                    size = "XXL",
                    productId = 9
                },
                new ProductSize
                {
                    Id = 28,
                    size = "S",
                    productId = 10
                },
                new ProductSize
                {
                    Id = 29,
                    size = "XS",
                    productId = 10
                },
                new ProductSize
                {
                    Id = 30,
                    size = "M",
                    productId = 10
                },
                new ProductSize
                {
                    Id = 31,
                    size = "L",
                    productId = 10
                },
                new ProductSize
                {
                    Id = 32,
                    size = "XL",
                    productId = 10
                },
                new ProductSize
                {
                    Id = 33,
                    size = "XXL",
                    productId = 10
                },
                new ProductSize
                {
                    Id = 34,
                    size = "S",
                    productId = 11
                },
                new ProductSize
                {
                    Id = 35,
                    size = "XS",
                    productId = 11
                },
                new ProductSize
                {
                    Id = 36,
                    size = "M",
                    productId = 11
                },
                new ProductSize
                {
                    Id = 37,
                    size = "L",
                    productId = 11
                },
                new ProductSize
                {
                    Id = 38,
                    size = "XL",
                    productId = 11
                },
                new ProductSize
                {
                    Id = 39,
                    size = "XXL",
                    productId = 11
                },
                new ProductSize
                {
                    Id = 40,
                    size = "M",
                    productId = 12
                },
                new ProductSize
                {
                    Id = 41,
                    size = "L",
                    productId = 12
                },
                new ProductSize
                {
                    Id = 42,
                    size = "XL",
                    productId = 12
                },
                new ProductSize
                {
                    Id = 43,
                    size = "XXL",
                    productId = 12
                },
                new ProductSize
                {
                    Id = 44,
                    size = "M",
                    productId = 13
                },
                new ProductSize
                {
                    Id = 45,
                    size = "L",
                    productId = 13
                },
                new ProductSize
                {
                    Id = 46,
                    size = "XL",
                    productId = 13
                },
                new ProductSize
                {
                    Id = 47,
                    size = "XXL",
                    productId = 13
                },
                new ProductSize
                {
                    Id = 48,
                    size = "M",
                    productId = 14
                },
                new ProductSize
                {
                    Id = 49,
                    size = "L",
                    productId = 14
                },
                new ProductSize
                {
                    Id = 50,
                    size = "XL",
                    productId = 14
                },
                new ProductSize
                {
                    Id = 51,
                    size = "XXL",
                    productId = 14
                },
                new ProductSize
                {
                    Id = 52,
                    size = "M",
                    productId = 15
                },
                new ProductSize
                {
                    Id = 53,
                    size = "L",
                    productId = 15
                },
                new ProductSize
                {
                    Id = 54,
                    size = "XL",
                    productId = 15
                },
                new ProductSize
                {
                    Id = 55,
                    size = "XXL",
                    productId = 15
                },
                new ProductSize
                {
                    Id = 56,
                    size = "M",
                    productId = 16
                },
                new ProductSize
                {
                    Id = 57,
                    size = "L",
                    productId = 16
                },
                new ProductSize
                {
                    Id = 58,
                    size = "M",
                    productId = 17
                },
                new ProductSize
                {
                    Id = 59,
                    size = "L",
                    productId = 17
                },
                new ProductSize
                {
                    Id = 60,
                    size = "S",
                    productId = 18
                },
                new ProductSize
                {
                    Id = 61,
                    size = "M",
                    productId = 18
                },
                new ProductSize
                {
                    Id = 62,
                    size = "L",
                    productId = 18
                },
                new ProductSize
                {
                    Id = 63,
                    size = "M",
                    productId = 19
                },
                new ProductSize
                {
                    Id = 64,
                    size = "30",
                    productId = 20
                },
                new ProductSize
                {
                    Id = 65,
                    size = "32",
                    productId = 20
                },
                new ProductSize
                {
                    Id = 66,
                    size = "34",
                    productId = 20
                },
                new ProductSize
                {
                    Id = 67,
                    size = "36",
                    productId = 20
                },
                new ProductSize
                {
                    Id = 68,
                    size = "28",
                    productId = 21
                },
                new ProductSize
                {
                    Id = 69,
                    size = "30",
                    productId = 21
                },
                new ProductSize
                {
                    Id = 70,
                    size = "32",
                    productId = 21
                },
                new ProductSize
                {
                    Id = 71,
                    size = "34",
                    productId = 21
                },
                new ProductSize
                {
                    Id = 72,
                    size = "36",
                    productId = 21
                }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Description = "Vibrant fruit patterns: For a modern and trendy look, opt from our Fruit of Desire Collection in all Batti Branches",
                    productId = 1,
                    marketerId = 5,
                    reactioncount = 200,
                    counter = 54,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 2,
                    Description = "BUY 1 GET 1 FREE  🤩" +
                    "Hurry! Get yours now while we're still on offer ,The offer is available in all Batti branches and for a limited time",
                    productId = 2,
                    marketerId = 5,
                    reactioncount = 300,
                    counter = 40,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 3,
                    Description = "Casual, modern, colorful: the new dress fit into any style. Check out the new models from vitality collection.",
                    productId = 3,
                    marketerId = 5,
                    reactioncount = 400,
                    counter = 30,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 4,
                    Description = "Trendy and colorful: matchy-matchy looks to celebrate Adha's Eid. Discover our Fruit of Desire Collection.",
                    productId = 4,
                    marketerId = 5,
                    reactioncount = 100,
                    counter = 51,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 5,
                    Description = "Summer needs a lot of clothes 👔" +
                    "Take advantage of the offers and shop a variety of T-shirts" +
                    "Buy a half sleeve shirt size M of selected models , at the sale price, and get the second for free",
                    productId = 5,
                    marketerId = 1,
                    reactioncount = 150,
                    counter = 44,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 6,
                    Description = "Distinguish your child in the summer with cheerful colors",
                    productId = 6,
                    marketerId = 1,
                    reactioncount = 110,
                    counter = 23,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 7,
                    Description = "Feel confident and stylish 🔥⭐ ",
                    productId = 7,
                    marketerId = 1,
                    reactioncount = 70,
                    counter = 60,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 8,
                    Description = "The track jacket is made of breathable and water repellent fabric, with transfer prints on the sleeves and embroidered logos on the chest. Made in Italy.",
                    productId = 8,
                    marketerId = 4,
                    reactioncount = 600,
                    counter = 39,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 9,
                    Description = "Men hoodie available in different, nature-inspired colors. Made of recycled cotton, Hoodie 2030 is comfortable and sustainable: it is indeed made in Italy and GRS certified .( Discount 50% 'from 184000 to 92000')",
                    productId = 9,
                    marketerId = 4,
                    reactioncount = 500,
                    counter = 56,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 10,
                    Description = "The long sleeve tee is made from 100% cotton. Transfer prints on the sleeves, pocket with stitched pirate embroidery and logos of the three brands under the pocket.",
                    productId = 10,
                    marketerId = 4,
                    reactioncount = 90,
                    counter = 55,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 11,
                    Description = "Short-sleeved Polo shirt made of stretch polyester piquet inspired by a retro vibe style. SS Polo Icon features contrasting knitted inserts on the collar and on the sleeve hems. The logo design complies with the tournament regulations",
                    productId = 11,
                    marketerId = 4,
                    reactioncount = 56,
                    counter = 5,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 12,
                    Description = "The special summer collection is now in our halls In addition to bags and sports shoes 😍" +
                    "Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉" +
                    "We are waiting for you ❤❤",
                    productId = 12,
                    marketerId = 3,
                    reactioncount = 456,
                    counter = 46,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 13,
                    Description = "The special summer collection is now in our halls In addition to bags and sports shoes 😍\" +\r\n\"Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉\" +\r\n\"We are waiting for you ❤❤",
                    productId = 13,
                    marketerId = 3,
                    reactioncount = 500,
                    counter = 20,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 14,
                    Description = "The special summer collection is now in our halls In addition to bags and sports shoes 😍\" +\r\n\"Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉\" +\r\n\"We are waiting for you ❤❤",
                    productId = 14,
                    marketerId = 3,
                    reactioncount = 450,
                    counter = 47,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 15,
                    Description = "The special summer collection is now in our halls In addition to bags and sports shoes 😍\" +\r\n\"Now you can choose the most beautiful pieces, such as design, colors, quality, and price as well 😉\" +\r\n\"We are waiting for you ❤❤",
                    productId = 15,
                    marketerId = 3,
                    reactioncount = 566,
                    counter = 17,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 16,
                    Description = "New CASUCCI Collection Summer 2023 season",
                    productId = 16,
                    marketerId = 2,
                    reactioncount = 340,
                    counter = 33,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                },
                new Post
                {
                    Id = 17,
                    Description = "New CASUCCI Collection Summer 2023 season",
                    productId = 17,
                    marketerId = 2,
                    reactioncount = 350,
                    counter = 30,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 18,
                    Description = "New CASUCCI Collection Summer 2023 season",
                    productId = 18,
                    marketerId = 2,
                    reactioncount = 340,
                    counter = 20,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 19,
                    Description = "New CASUCCI Collection Summer 2023 season",
                    productId = 19,
                    marketerId = 2,
                    reactioncount = 340,
                    counter = 10,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 20,
                    Description = "New CASUCCI Collection Summer 2023 season",
                    productId = 20,
                    marketerId = 2,
                    reactioncount = 500,
                    counter = 56,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }, new Post
                {
                    Id = 21,
                    Description = "New CASUCCI Collection Summer 2023 season",
                    productId = 21,
                    marketerId = 2,
                    reactioncount = 456,
                    counter = 43,
                    status = Enum.PostStatus.Public,
                    CreatedDate = DateTime.Now
                }

                );
        }
    }
}
