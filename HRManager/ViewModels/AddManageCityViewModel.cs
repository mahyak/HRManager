using System.ComponentModel.DataAnnotations;

namespace HRManager.ViewModels
{
    public class AddManageCityViewModel
    {
        [Required(ErrorMessage="You Must Input This Filed")]
        public string Name { get; set; }
        public int PostalCode { get; set; }
    }
}