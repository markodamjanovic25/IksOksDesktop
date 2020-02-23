using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOksIgrica
{
    class Znak
    {
        public string NazivZnaka { get; set; }

        public Znak(string nazivZnaka)
        {
            this.NazivZnaka = nazivZnaka;
        }

        public override string ToString()
        {
            return $"{NazivZnaka}";
        }

    }
}
