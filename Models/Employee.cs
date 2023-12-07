using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SweeperS_Dev.Models
{
	public class Employee
	{
        // EmployeeID	FirstName	LastName	JoinDate	Nationality	EmployeeStatus	DOB
        public int ID { get; set; }
        [Required]
        //    [DisplayColumn("First Name")]
        [Display(Name = "First Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Enter Valid First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Enter Valid Last Name")]
        public string LastName { get; set; } = null!;
        [Required]
        //dotnet aspnet-codegenerator razorpage -m Employee -dc SweeepersDataContext -udl -outDir Pages/Test --referenceScriptLibraries

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DOB { get; set; } = DateTime.Parse("01-Jan-1900")!;
        public string Gender { get; set; } = null!;
        public string Image { get; set; } = null!;
        /*
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Enter valid Email Address")]
        [Required(ErrorMessage = "Email is Required")]
        public string EmailId { get; set; } = null!;

        [Display(Name = "MobileNo")]
        [RegularExpression(@"^[7-9][0-9]{9}$", ErrorMessage = "Enter Mobileno.")]
        [Required(ErrorMessage = "MobileNo Required")]
        public string MobileNo { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender Required")]
        public string GenderId { get; set; }
        public List<SelectListItem> ListofGender { get; set; }
        public bool Status { get; set; }
        */

    }
}

