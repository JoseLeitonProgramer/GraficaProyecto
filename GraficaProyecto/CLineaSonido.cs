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
        public float FrecuenciaVibracion { get; set; } = 10f;  
        public float AmplitudVibracion { get; set; } = 30f;    
        public int NumeroSegmentos { get; set; } = 60;
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

            PointF pInicio = new PointF(
                Centro.X - dx * Longitud / 2,
                Centro.Y - dy * Longitud / 2
            );

            PointF pFin = new PointF(
                Centro.X + dx * Longitud / 2,
                Centro.Y + dy * Longitud / 2
            );

            float px = -dy;
            float py = dx;

            PointF[] puntos = new PointF[NumeroSegmentos + 1];

            for (int i = 0; i <= NumeroSegmentos; i++)
            {
                float t = (float)i / NumeroSegmentos;

                float x = pInicio.X + dx * Longitud * t;
                float y = pInicio.Y + dy * Longitud * t;

                float desplazamiento = (float)(Math.Sin(2 * Math.PI * (FrecuenciaVibracion * t + Environment.TickCount / 1000.0)) * AmplitudVibracion);

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

