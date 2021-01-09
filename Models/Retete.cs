using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moldovan_Maria_AplicatieWeb.Models
{
    public class Retete
    {
        public int ID { get; set; }
        [Display(Name = "Denumire reteta")]
        public string Denumire { get; set; }
        public string Ingrediente { get; set; }
        public string Preparare { get; set; }
        [Display (Name = "Timp gatire")]
        public string Timp { get; set; }
    }
}
