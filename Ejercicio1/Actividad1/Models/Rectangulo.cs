using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    public class Rectangulo
    {
        


        double Largo { get; set; }
        double Ancho { get; set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalcularArea()
        {
          return Ancho * Largo;
        }

        

        

        public string Describir()
        {
            return $"Largo : {Largo} -- Ancho : {Ancho} -- Area : {CalcularArea()}";
        }
    }
}
