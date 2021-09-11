using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MusicoModel
    {
        public int Id { get; set; }
        [StringLength(20)]
        [Display(Name = "Primeiro Nome")]
        public string PrimeiroNome { get; set; }
        [StringLength(20)]
        [Display(Name = "Ultimo Nome")]
        public string UltimoNome { get; set; }
        [Display(Name = "Instrumento Preferido")]
        public string InstrumentoPreferido { get; set; }
        [Display(Name = "Multi-Instrumentista")]
        public bool MultiInstrumentista { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Pertence a qual banda")]
        public bool PossuiBanda { get; set; }
        public string Banda { get; set; }

        [Display(Name = "Foto")]
        public string ImageUri { get; set; }
        public ICollection<SpotModel> SpotModels { get; set; }
        [Display(Name = "Id do Usuário")]
        public string UserId { get; set; }
    }
}
