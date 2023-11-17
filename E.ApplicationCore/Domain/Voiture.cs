using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Voiture
    {
        public string NumMat { get; set; }
        public MarqColeur MarqColeur { get; set; }
        public IList<Client> clients { get; set; }
        public IList<Chauffeur> chauffeurs { get; set; }
        public IList<Course> courses { get; set; }

    }
}
