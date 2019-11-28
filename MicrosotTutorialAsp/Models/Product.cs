using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrosotTutorialAsp.Models
{
    public class Product
    {
        public int ID { get; set; }
        
        [Display(Name = "Назва")]
        public string Name { get; set; }
        
        [Display(Name = "Дата виробництва")]
        [DataType(DataType.Date)]
        public DateTime ProduceDate { get; set; }
        
        [Display(Name = "Час виробництва")]
        [DataType(DataType.Time)]
        public DateTime ProduceTime { get; set; }
        
        [Display(Name = "Тип продукту")]
        public string Type { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Ціна")]
        public decimal Price { get; set; }
    }
}
