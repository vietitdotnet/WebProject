using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebProject.ModelValidation;

namespace WebProject.Entites
{
    public class Category
    {

        public Category()
        {
            Id = Guid.NewGuid().ToString().Substring(24);
        }

        [Key]
        public string Id { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "{0} không được bỏ trống.")]
        public string Name { get; set; }

        public string ParentCategoryId { get; set; }

        [ForeignKey("ParentCategoryId")]
        [Display(Name = "Mục cha")]
        public virtual Category ParentCategory { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} có độ dài từ {1} đến {2} kí tự.")]
        [SlugValidation]
        public string Slug { get; set; }



    }
}
