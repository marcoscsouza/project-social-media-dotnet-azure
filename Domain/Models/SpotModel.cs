using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SpotModel
    {
        public int Id { get; set; }
        [Display(Name = "Spot")]

        public string Texto { get; set; }
        [Display(Name = "Data da Publicação")]

        public DateTime DataCriacao { get; set; }

        public MusicoModel MusicoModel { get; set; }
    }
}
