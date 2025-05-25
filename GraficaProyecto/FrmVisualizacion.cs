using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficaProyecto
{
    public partial class FrmVisualizacion : Form
    {
        private CLineaSonido linea1;
        private CLineaSonido linea2;
        private CCirculosAnimados circulos;
        private float backgroundHue = 0f;
        public FrmVisualizacion()
        {
            InitializeComponent();
            PointF centro = new PointF(picCanvas.Width / 2f, picCanvas.Height / 2f);

            linea1 = new CLineaSonido(centro, 1000f)
            {
                VelocidadRotacion = 0.2f,
                FrecuenciaVibracion = 10f,
                AmplitudVibracion = 10f
            };

            linea2 = new CLineaSonido(centro, 1000f)
            {
                VelocidadRotacion = -0.2f,
                FrecuenciaVibracion = 10f,
                AmplitudVibracion = 10f
            };

            circulos = new CCirculosAnimados(centro, pasos: 80)
            {
                MaxRadio = 200
            };

            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            picCanvas.Paint += picCanvas_Paint;
            picCanvas.BackColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            linea1.Actualizar();
            linea2.Actualizar();
            circulos.Actualizar();

            backgroundHue += 1f;
            if (backgroundHue > 360f)
                backgroundHue = 0f;

            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(CColorHelper.ColorDesdeHSV(backgroundHue, 0.8f, 0.15f));

            circulos.Dibujar(e.Graphics);
            linea1.Dibujar(e.Graphics);
            linea2.Dibujar(e.Graphics);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        


        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
