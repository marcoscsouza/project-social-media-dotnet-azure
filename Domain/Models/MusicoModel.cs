using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MusicoModel
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string InstrumentoPreferido { get; set; }
        public bool MultiInstrumentista { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool PossuiBanda { get; set; }
        public string Banda { get; set; }


        public string ImageUri { get; set; }
        public ICollection<SpotModel> SpotModels { get; set; }
        public string UserId { get; set; }
    }
}
