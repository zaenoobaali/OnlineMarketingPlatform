using Project2.DTOs.UserDTOs;

namespace Project2.DTOs.MarketerDTOs
{ 
    public class AddMarketerViewModel
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public long phoneNumber { get; set; }
        public long mobileNumber { get; set; }
        public string city { get; set; }
        public string zone { get; set; }
        public AddUserViewModel UserInformation { get; set; }

    }
}
