namespace JuegoNaves
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Jugador = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            alien = new PictureBox();
            lbPuntaje = new Label();
            vida2 = new PictureBox();
            vida1 = new PictureBox();
            vida3 = new PictureBox();
            lbFinJuego = new Label();
            ((System.ComponentModel.ISupportInitialize)Jugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vida2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vida1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vida3).BeginInit();
            SuspendLayout();
            // 
            // Jugador
            // 
            Jugador.Image = (Image)resources.GetObject("Jugador.Image");
            Jugador.Location = new Point(141, 228);
            Jugador.Name = "Jugador";
            Jugador.Size = new Size(67, 62);
            Jugador.SizeMode = PictureBoxSizeMode.StretchImage;
            Jugador.TabIndex = 0;
            Jugador.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // alien
            // 
            alien.Image = (Image)resources.GetObject("alien.Image");
            alien.Location = new Point(141, 41);
            alien.Name = "alien";
            alien.Size = new Size(67, 69);
            alien.SizeMode = PictureBoxSizeMode.StretchImage;
            alien.TabIndex = 1;
            alien.TabStop = false;
            // 
            // lbPuntaje
            // 
            lbPuntaje.AutoSize = true;
            lbPuntaje.Location = new Point(13, 17);
            lbPuntaje.Name = "lbPuntaje";
            lbPuntaje.Size = new Size(73, 20);
            lbPuntaje.TabIndex = 2;
            lbPuntaje.Text = "Puntaje: 0";
            // 
            // vida2
            // 
            vida2.Image = (Image)resources.GetObject("vida2.Image");
            vida2.Location = new Point(280, 4);
            vida2.Name = "vida2";
            vida2.Size = new Size(42, 33);
            vida2.SizeMode = PictureBoxSizeMode.StretchImage;
            vida2.TabIndex = 3;
            vida2.TabStop = false;
            // 
            // vida1
            // 
            vida1.Image = (Image)resources.GetObject("vida1.Image");
            vida1.Location = new Point(233, 4);
            vida1.Name = "vida1";
            vida1.Size = new Size(42, 33);
            vida1.SizeMode = PictureBoxSizeMode.StretchImage;
            vida1.TabIndex = 4;
            vida1.TabStop = false;
            // 
            // vida3
            // 
            vida3.Image = (Image)resources.GetObject("vida3.Image");
            vida3.Location = new Point(328, 4);
            vida3.Name = "vida3";
            vida3.Size = new Size(42, 33);
            vida3.SizeMode = PictureBoxSizeMode.StretchImage;
            vida3.TabIndex = 5;
            vida3.TabStop = false;
            // 
            // lbFinJuego
            // 
            lbFinJuego.AutoSize = true;
            lbFinJuego.Location = new Point(135, 158);
            lbFinJuego.Name = "lbFinJuego";
            lbFinJuego.Size = new Size(96, 20);
            lbFinJuego.TabIndex = 6;
            lbFinJuego.Text = "Fin del Juego";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(lbFinJuego);
            Controls.Add(vida3);
            Controls.Add(vida1);
            Controls.Add(vida2);
            Controls.Add(lbPuntaje);
            Controls.Add(alien);
            Controls.Add(Jugador);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Jugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)alien).EndInit();
            ((System.ComponentModel.ISupportInitialize)vida2).EndInit();
            ((System.ComponentModel.ISupportInitialize)vida1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vida3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Jugador;
        private System.Windows.Forms.Timer timer1;
        private PictureBox alien;
        private Label lbPuntaje;
        private PictureBox vida2;
        private PictureBox vida1;
        private PictureBox vida3;
        private Label lbFinJuego;
    }
}
