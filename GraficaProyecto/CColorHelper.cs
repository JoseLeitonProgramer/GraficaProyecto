using System;
using System.Drawing;

namespace GraficaProyecto
{
    public static class CColorHelper
    {
        public static Color ColorDesdeHSV(float hue, float sat, float val)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            float f = hue / 60 - (float)Math.Floor(hue / 60);

            val *= 255;
            int v = Convert.ToInt32(val);
            int p = Convert.ToInt32(val * (1 - sat));
            int q = Convert.ToInt32(val * (1 - f * sat));
            int t = Convert.ToInt32(val * (1 - (1 - f) * sat));

            switch (hi)
            {
                case 0:
                    return Color.FromArgb(255, v, t, p);
                case 1:
                    return Color.FromArgb(255, q, v, p);
                case 2:
                    return Color.FromArgb(255, p, v, t);
                case 3:
                    return Color.FromArgb(255, p, q, v);
                case 4:
                    return Color.FromArgb(255, t, p, v);
                default:
                    return Color.FromArgb(255, v, p, q); //PROBANDO SI SE HACE PUSH
            }
        }
    }
}
