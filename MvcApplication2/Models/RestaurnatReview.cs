using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class RestaurnatReview 
    {
        public int Id { get; set; }
        [Range(1,10)]
        [Required]
        public int Rating { get; set; }
        [Required(ErrorMessageResourceType=typeof(MvcApplication2.Views.Home.Resources), ErrorMessage="You can't write more then 1024 characters!")]
        [StringLength(1024)]
        public string Body { get; set; }
        public int RestaurantId {get;set;}
        [Display(Name="User name")]
        [DisplayFormat(NullDisplayText="anonymus")]
        public string ReviewerName { get; set; }
    
    }
}