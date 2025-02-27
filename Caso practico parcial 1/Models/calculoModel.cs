using System;

namespace TuProyecto.Models
{
    public class CalculoModel
    {
        public string Dato { get; set; }
        public double Altura { get; set; }
        public int Segundos { get; set; }
        public double AlturaFinal { get; set; }
        public int NumeroAleatorio { get; set; }

        public void CalcularCaida()
        {
            const double gravedad = 9.81;
            AlturaFinal = Altura - (0.5 * gravedad * Math.Pow(Segundos, 2));

            // Evitar valores negativos
            if (AlturaFinal < 0)
                AlturaFinal = 0;
        }

        public void GenerarNumeroAleatorio()
        {
            Random rand = new Random();
            NumeroAleatorio = rand.Next(1, 100);
        }
    }
}
