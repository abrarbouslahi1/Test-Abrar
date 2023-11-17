using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public enum Etat
    {
        EnAttend,
        EnCours,
        Payee
    }
    public class Course
    {
        public DateTime DateCourse { get; set; }
        public string lieuDepart { get; set; }
        public string lieuArrive { get; set; }
        public double Montant { get; set; }
        public bool PaiementEnLigne { get; set; }
        public Etat Etat { get; set; }
        public int clientFk { get; set; }
        public int voitureFk { get; set; }
        public int Numcourse { get; set; }

        [ForeignKey("clientFk")]
        public Client client { get; set; }
        [ForeignKey("voitureFk")]
        public Voiture voiture { get; set; }
       

    }
}
