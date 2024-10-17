using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miacuario
{
    public class acuario
    {

        public string Direccion {  get; set; }
        public delfin delfin1 { get; set; }
        public delfin delfin2 { get; set; }
        public orca orca1 { get; set; }
        public void listaNombre()
        {
            Console.WriteLine($"Delfin1: {delfin1.Nombre}");
            Console.WriteLine($"Delfin2: {delfin2.Nombre}");
            Console.WriteLine($"Orca: {orca1.Nombre}");
        }
    }
}
