using System;
using System.Drawing;

namespace GraficaProyecto
{
    public class CCirculosAnimados
    {
        private int pasos;
        private int pasoActual = 0;
        private bool creciendo = true;

        public int CantidadCirculos { get; set; } = 500;
        public float EspacioEntreCirculos { get; set; } = 20f;
        public int MaxRadio { get; set; } = 1000;
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

            // Vibración suave para radio (basada en tiempo)
            float vibracionRadio = (float)(Math.Sin(Environment.TickCount / 500.0) * 5); // +-5 pixeles

            for (int i = 0; i < CantidadCirculos; i++)
            {
                float radio = radioBase - i * EspacioEntreCirculos + vibracionRadio;
                if (radio < 0) radio = 0;

                float alpha = 255f * (1 - (float)i / CantidadCirculos);
                if (alpha < 0) alpha = 0;

                using (Pen pen = new Pen(Color.FromArgb((int)alpha, Color.Azure), 2))
                {
                    g.DrawEllipse(pen, Centro.X - radio, Centro.Y - radio, radio * 2, radio * 2);
                }
            }
        }

    }
}
