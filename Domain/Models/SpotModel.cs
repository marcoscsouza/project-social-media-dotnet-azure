using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SpotModel
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; }

        public MusicoModel MusicoModel { get; set; }
    }
}
