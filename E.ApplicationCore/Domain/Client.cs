using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Client
    {
        
        public string CinId { get; set; }
        public string Nom { get; set; }
        public string prenom { get; set; }
        public DateTime DateNaissence { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        public string password { get; set; }
        public IList<Voiture> voitures { get; set; }
        public IList<Course> courses { get; set; }
        

    }
}
