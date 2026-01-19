using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2026_01_19_WebApplication1.Models
{
    public class LesPays : List<Pays>
    {
        public LesPays()
        {
        
            //int i = 1;
           
            //Add(new Pays(i++, "Japon", "../images/japon_flag.jpg"));
            //Add(new Pays(i++, "Inde", "../images/India_flag.png"));
            //Add(new Pays(i++, "Chine", "../images/China_flag.jpg"));
            //Add(new Pays(i++, "Bangladesh", "../images/Bangladesh_flag.png"));
            //Add(new Pays(i++, "France", "../images/flag_france.jpg"));
            //Add(new Pays(i++, "Brésil", "../images/Bresil_flag.jpg"));
            //Add(new Pays(i++, "Egypte", "../images/Egypt_flag.png"));
            //Add(new Pays(i++, "Mexique", "../images/mexico_flag.jpg"));
        }
        public void ajouter ()
        {
            int i = 1;

            Add(new Pays(i++, "Japon", "../images/japon_flag.jpg"));
            Add(new Pays(i++, "Inde", "../images/India_flag.png"));
            Add(new Pays(i++, "Chine", "../images/China_flag.jpg"));
            Add(new Pays(i++, "Bangladesh", "../images/Bangladesh_flag.png"));
            Add(new Pays(i++, "France", "../images/flag_france.jpg"));
            Add(new Pays(i++, "Brésil", "../images/Bresil_flag.jpg"));
            Add(new Pays(i++, "Egypte", "../images/Egypt_flag.png"));
            Add(new Pays(i++, "Mexique", "../images/mexico_flag.jpg"));
        }
    }
}
