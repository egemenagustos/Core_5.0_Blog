using System.ComponentModel.DataAnnotations;

namespace Core_5._0_Blog.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen rol adı giriniz!")]
        public string Name { get; set; }
    }
}
