using JuegoDelAhorcado.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JuegoDelAhorcado
{
    public partial class Form1 : Form
    {
        private string currentWord;
        private int errorCount;
        private int encontradoCount;

        private const string IMAGE_TEMPLATE = "./Fotos/Imagen{0}.PNG";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            IniciarJuego(Listados.NombreAnimal);
        }

        private void btnFrutas_Click(object sender, EventArgs e)
        {
            IniciarJuego(Listados.NombreFruta);

        }

        private void btncarros_Click(object sender, EventArgs e)
        {
            IniciarJuego(Listados.NombreCarro);
        }
        public void IniciarJuego(string palabra)
        {
            errorCount = 0;
            encontradoCount = 0;
            currentWord = palabra;
            pictureAhorcado.Show();

            InicializarAhorcadoPicture();
            InicializarBotonesOpciones();
            IniciarlizarPalabra();
            MessageBox.Show("Usted solo cuenta con 7 intentos.  Pulse Aceptar para poder continuar con el juego");
            
        }

        private void InicializarAhorcadoPicture()
        {
            pictureAhorcado.Image = Image.FromFile(string.Format(IMAGE_TEMPLATE,1));
            pictureAhorcado.Show();
        }

        private void IniciarlizarPalabra()
        {
            flowLayoutPalabra.Controls.Clear();
            for (int i = 0; i < currentWord.Length; i++)
            {
                var label = new Label();
                label.Size = new Size(25, 25);
                label.Text = "_";

                flowLayoutPalabra.Controls.Add(label);
            }
        }

        private void InicializarBotonesOpciones()
        {
            botonesABC.Controls.Clear();

            for (int i = 65; i < 91; i++)
            {
                var button = new Button();
                button.Text = ((char)i).ToString();
                button.Size = new Size(25, 25);
                button.Click += Jugada;

                botonesABC.Controls.Add(button);
            }
        }


        private void Jugada(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if(currentWord.ToUpper().Contains(button.Text))
            {
                button.BackColor = Color.Green;
                MarcarLetrasCorrectas(button.Text[0]);

                if (encontradoCount == currentWord.Length) Win();
            }
            else
            {
                errorCount += 1;

                button.BackColor = Color.Red;
                button.Enabled = false;

                if (errorCount < 7) MarcarAhorcado();
                else GameOver();
            }
        }

        private void Win()
        {
            MessageBox.Show($"Felicidades pudiste adivinar  la palabra clave, ya eres libre");
            MessageBox.Show($"Seleciona una categoria para poder volver a jugar");

            foreach (var control in botonesABC.Controls)
            {
                ((Button)control).Enabled = false;
            }
        }

        private void GameOver()
        {
            MessageBox.Show($"Estas Ahorcado, la palabra era {currentWord}");
            MessageBox.Show($"Selecione una categoria para poder volver a jugar");

            foreach ( var control in botonesABC.Controls)
            {
                ((Button)control).Enabled = false;
            }
        }

        private void MarcarAhorcado()
        {
            pictureAhorcado.Image = Image.FromFile(string.Format(IMAGE_TEMPLATE, errorCount + 1));      
        }

        private void MarcarLetrasCorrectas(char letter)
        {
            var results = ConseguirIncidencias(letter);
            encontradoCount += results.Length;

            foreach(var i in results)
            {
                ((Label)flowLayoutPalabra.Controls[i]).Text = currentWord[i].ToString().ToUpper();
            }

        }

        private int[] ConseguirIncidencias(char t)
        {
            var result = new List<int>();

            var word = currentWord.ToUpper();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == t) result.Add(i);
            }

            return result.ToArray();
        }

        
    }
}
