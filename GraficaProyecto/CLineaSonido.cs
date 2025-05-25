using System;
using System.Drawing;

namespace GraficaProyecto
{
    public class CLineaSonido
    {
        public PointF Centro { get; set; }
        public float Longitud { get; set; }

        public float Angulo { get; private set; } = 0f;
        public float VelocidadRotacion { get; set; } = 1f;

        public float FrecuenciaVibracion { get; set; } = 10f;  // Más frecuencia para más ondas
        public float AmplitudVibracion { get; set; } = 30f;    // Más amplitud para ondas visibles

        public int NumeroSegmentos { get; set; } = 60;          // Número de divisiones en la línea

        public CLineaSonido(PointF centro, float longitud)
        {
            Centro = centro;
            Longitud = longitud;
        }

        public void Actualizar()
        {
            Angulo += VelocidadRotacion;

            if (Angulo >= 360f)
                Angulo -= 360f;
            else if (Angulo < 0)
                Angulo += 360f;
        }

        public void Dibujar(Graphics g)
        {
            double radianes = Angulo * Math.PI / 180.0;

            float dx = (float)Math.Cos(radianes);
            float dy = (float)Math.Sin(radianes);

            // Punto inicial y final de la línea sin vibración
            PointF pInicio = new PointF(
                Centro.X - dx * Longitud / 2,
                Centro.Y - dy * Longitud / 2
            );

            PointF pFin = new PointF(
                Centro.X + dx * Longitud / 2,
                Centro.Y + dy * Longitud / 2
            );

            // Vector perpendicular para la vibración
            float px = -dy;
            float py = dx;

            // Array de puntos a dibujar (NúmeroSegmentos+1 puntos)
            PointF[] puntos = new PointF[NumeroSegmentos + 1];

            for (int i = 0; i <= NumeroSegmentos; i++)
            {
                float t = (float)i / NumeroSegmentos; // Valor entre 0 y 1 a lo largo de la línea

                // Posición lineal a lo largo de la línea (sin vibración)
                float x = pInicio.X + dx * Longitud * t;
                float y = pInicio.Y + dy * Longitud * t;

                // Vibración sinusoidal en función de t y tiempo
                float desplazamiento = (float)(Math.Sin(2 * Math.PI * (FrecuenciaVibracion * t + Environment.TickCount / 1000.0)) * AmplitudVibracion);

                // Aplicar desplazamiento perpendicular
                x += px * desplazamiento;
                y += py * desplazamiento;

                puntos[i] = new PointF(x, y);
            }

            using (Pen pen = new Pen(Color.Cyan, 3))
            {
                g.DrawLines(pen, puntos);
            }
        }
    }
}

