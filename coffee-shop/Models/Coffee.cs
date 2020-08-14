using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coffee_shop.Models
{
    public class Coffee
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string BeanType { get; set; }
    }
}
