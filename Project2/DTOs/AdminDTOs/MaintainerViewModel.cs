using Project2.DTOs.UserDTOs;

namespace Project2.DTOs.AdminDTOs
{
    public class MaintainerViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public AddUserViewModel UserInformation { get; set; }
        public string roleName { get; set; } 
    }
}
