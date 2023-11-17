using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Chauffeur
    {
        public int Id { get; set; }
        public string email { get; set; }
        public float tauxbenefice { get; set; }
        public Voiture voiture { get; set; }
        public int voitureFK { get; set; }
    }
}
