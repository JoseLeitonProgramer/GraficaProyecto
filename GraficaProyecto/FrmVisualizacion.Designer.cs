namespace GraficaProyecto
{
    partial class FrmVisualizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAdelantar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 45);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(881, 388);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barraProgreso
            // 
            this.barraProgreso.BackColor = System.Drawing.Color.White;
            this.barraProgreso.Location = new System.Drawing.Point(321, 439);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(572, 38);
            this.barraProgreso.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlay.Location = new System.Drawing.Point(12, 439);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(55, 38);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPause.Location = new System.Drawing.Point(73, 439);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(55, 38);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Location = new System.Drawing.Point(134, 439);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 38);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRetroceder.Location = new System.Drawing.Point(199, 439);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(55, 38);
            this.btnRetroceder.TabIndex = 6;
            this.btnRetroceder.Text = "<<";
            this.btnRetroceder.UseVisualStyleBackColor = false;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAdelantar
            // 
            this.btnAdelantar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdelantar.Location = new System.Drawing.Point(260, 439);
            this.btnAdelantar.Name = "btnAdelantar";
            this.btnAdelantar.Size = new System.Drawing.Size(55, 38);
            this.btnAdelantar.TabIndex = 7;
            this.btnAdelantar.Text = ">>";
            this.btnAdelantar.UseVisualStyleBackColor = false;
            this.btnAdelantar.Click += new System.EventHandler(this.btnAdelantar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(881, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Simulación del Reproductor de Windows Media";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmVisualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdelantar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.picCanvas);
            this.Name = "FrmVisualizacion";
            this.Text = "FrmVisualizacion";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAdelantar;
        private System.Windows.Forms.Button button1;
    }
}