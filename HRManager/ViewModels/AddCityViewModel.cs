using System.ComponentModel.DataAnnotations;

namespace HRManager.ViewModels
{
    public class AddCityViewModel
    {
        [Required(ErrorMessage="You Must Input Field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You Must Input Field")]
        public int PostalCode { get; set; }
    }
}