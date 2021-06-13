using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmova_Databaze
{

    public class Rootobject
    {
        public Movsave[] movSave { get; set; }
    }

    public class Movsave
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string CountryOfOrigin { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }
        public string Director { get; set; }
        public string Script { get; set; }
        public string Camera { get; set; }
        public string Music { get; set; }
        public string Actors { get; set; }
        public int Rating { get; set; }
        public string Commentary { get; set; }
    }

}
