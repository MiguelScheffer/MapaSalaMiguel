using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class SalasEntidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroComputador { get; set; }
        public bool IsLab { get; set; }
        public int NumeroCadeiras { get; set; }
        public bool Disponivel { get; set; }

    }
}
