using System;

namespace TuProyecto.Models
{
    public class CalculoModel
    {
        public double Altura { get; set; }
        public double Tiempo { get; set; }
        public double Resultado { get; set; }
        public int NumeroAleatorio { get; set; }

        public void CalcularCaida()
        {
            // Fórmula de caída libre: h = (1/2) * g * t^2
            const double gravedad = 9.81;
            Resultado = 0.5 * gravedad * Math.Pow(Tiempo, 2);
        }

        public void GenerarNumeroAleatorio()
        {
            Random rand = new Random();
            NumeroAleatorio = rand.Next(1, 100); // Número entre 1 y 100
        }
    }
}