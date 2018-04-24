using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace AppMVCAutofac.Core.Model
{
    
   public class User
    {
    public int Id { get; set; }
        [Required, StringLength(25, ErrorMessage = "Lenght of Name is not right", MinimumLength = 2)]
        [Display(Name ="Имя сотрудника")]
        public string Name { get; set; }

        [Required, StringLength(20, ErrorMessage = "Lenght of Position is not right", MinimumLength = 2)]
        [Display(Name = "Должность")]
        public string Position { get; set; }

        [Required, StringLength(2, ErrorMessage = "Lenght of Age is not right", MinimumLength = 1)]
        [Display(Name = "Возраст")]
        public string Age { get; set; }

        [Display(Name = "Дата оформления")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime StartDate { get; set; }

    }
}
