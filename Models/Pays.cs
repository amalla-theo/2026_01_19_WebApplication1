using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;


namespace _2026_01_19_WebApplication1.Models
{
    public class Pays
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Drapeau { get; set; }
        public Pays(string Nom)
        {
            this.Nom = Nom;
        }
        public Pays(string Nom, string drapeau)
        {
            this.Nom = Nom;
            this.Drapeau = drapeau;
        }
        public Pays()
        {
           
        }
        public Pays(int Id, string Nom, string drapeau)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Drapeau = drapeau;
        }
    }
}
