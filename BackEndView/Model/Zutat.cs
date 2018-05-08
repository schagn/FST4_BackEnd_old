using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndView.Model
{
    public class Zutat
    {
        public Guid ZutatenId { get; set; }
        public string Beschreibung { get; set; }
        public double Preis { get; set; }

    }
}
