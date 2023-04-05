using System.ComponentModel.DataAnnotations;

namespace SpryStore.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad Alanı Boş Geçilemez")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
