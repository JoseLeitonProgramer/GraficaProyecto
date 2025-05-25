using System;
using System.Drawing;

namespace GraficaProyecto
{
    public class CCirculosAnimados
    {
        private int pasos;
        private int pasoActual = 0;
        private bool creciendo = true;

        public int CantidadCirculos { get; set; } = 10;
        public float EspacioEntreCirculos { get; set; } = 20f;
        public int MaxRadio { get; set; } = 200;
        public PointF Centro { get; set; }

        public CCirculosAnimados(PointF centro, int pasos = 30)
        {
            Centro = centro;
            this.pasos = pasos;
        }

        public void Actualizar()
        {
            if (creciendo)
            {
                pasoActual++;
                if (pasoActual >= pasos)
                    creciendo = false;
            }
            else
            {
                pasoActual--;
                if (pasoActual <= 0)
                    creciendo = true;
            }
        }

        public void Dibujar(Graphics g)
        {
            float radioBase = MaxRadio * pasoActual / pasos;

            // Vibración suave para el radio base (latido general)
            float vibracionGlobal = (float)(Math.Sin(Environment.TickCount / 1000.0) * 5); // más lento
            radioBase += vibracionGlobal;

            int puntosPorCirculo = 100;  // Más puntos, más suave la onda

            for (int i = 0; i < CantidadCirculos; i++)
            {
                float radio = radioBase - i * EspacioEntreCirculos;
                if (radio <= 0) continue;

                PointF[] puntos = new PointF[puntosPorCirculo];

                for (int j = 0; j < puntosPorCirculo; j++)
                {
                    float angulo = (float)(j * 2 * Math.PI / puntosPorCirculo);

                    // Variación por onda de sonido
                    float variacion = (float)(Math.Sin(angulo * 8 + Environment.TickCount / 100.0) * 10);  // onda visible

                    float r = radio + variacion;

                    puntos[j] = new PointF(
                        Centro.X + (float)(r * Math.Cos(angulo)),
                        Centro.Y + (float)(r * Math.Sin(angulo))
                    );
                }

                float alpha = 255f * (1 - (float)i / CantidadCirculos);
                if (alpha < 0) alpha = 0;

                using (Pen pen = new Pen(Color.FromArgb((int)alpha, Color.Cyan), 2))
                {
                    g.DrawPolygon(pen, puntos);
                }
            }
        }


    }
}
