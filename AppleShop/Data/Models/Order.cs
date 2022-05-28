using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace AppleShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [MinLength(3)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [MinLength(3)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Введите адресс")]
        [StringLength(25)]
        [MinLength(3)]
        [Required(ErrorMessage = "Длина адресс не менее 10 символов")]
        public string adress { get; set; }

        [Display(Name = "Введите номер телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [MinLength(3)]
        [Required(ErrorMessage = "Длина номера не менее 10 символов")]
        public string phone { get; set; }

        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [MinLength(3)]
        [Required(ErrorMessage = "Длина email не менее 20 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
