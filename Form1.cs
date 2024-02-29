using System.Media;

namespace JuegoNaves
{
    public partial class Form1 : Form
    {

        bool derecha, izquierda;
        int x;
        int puntaje;
        Random rnd = new Random();
        int vidas;

        void vidasJugador()
        {
            if (vidas == 1)
            {
                vida1.Image = null;
            }

            if (vidas == 2)
            {
                vida2.Image = null;
            }

            if (vidas == 3)
            {
                vida3.Image = null;
                lbFinJuego.Show();
                timer1.Stop();
            }

        }

        void actualizarJuego()
        {
            if (Jugador.Bounds.IntersectsWith(alien.Bounds))
            {
                alien.Location = new Point(x, 0);
                alien.Top -= 200;
                vidas += 1;
                vidasJugador();

            }

        }

        void MovimientoEnemigo()
        {
            alien.Top += 6;
            if (alien.Top > 400)
            {
                puntaje++;
                lbPuntaje.Text = "Puntaje: " + puntaje;

                x = rnd.Next(0, 300);
                alien.Location = new Point(x, 0);
            }

        }

        public Form1()
        {
            InitializeComponent();
            lbFinJuego.Hide();
        }

        void movimientoJugador()
        {
            if (derecha == true)
            {
                Jugador.Left += 5;

            }
            if (izquierda == true)
            {
                Jugador.Left -= 5;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                derecha = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                izquierda = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                derecha = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                izquierda = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movimientoJugador();
            MovimientoEnemigo();
            actualizarJuego();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
