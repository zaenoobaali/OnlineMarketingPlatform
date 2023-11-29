using Project2.DTOs.UserDTOs;
using System.ComponentModel.DataAnnotations;
namespace Project2.DTOs.CustomerDTOs
{
    public class AddCustomerViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public long phoneNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string city { get; set; }
        public string zone { get; set; }
        public string gender { get; set; }
        public AddUserViewModel UserInformation { get; set; }
    }
}
