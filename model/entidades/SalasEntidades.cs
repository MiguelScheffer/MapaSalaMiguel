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
        public int ano { get; set; }
        
        public string periodo { get; set; }
        public string Nome { get; set; }
        public int NumeroComputador { get; set; }
        public bool IsLab { get; set; }
        public int NumeroCadeiras { get; set; }
        public bool Disponivel { get; set; }

        public Object[] Linha()
        {
            return new object[] { Id,ano,periodo,NumeroCadeiras,NumeroComputador,IsLab,Disponivel };
        }
    }
}
