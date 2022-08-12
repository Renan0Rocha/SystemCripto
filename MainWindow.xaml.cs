using System;
using System.Windows;

namespace SystemCripto
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCriptografar_Click(object sender, RoutedEventArgs e)
        {
            string criptado;

            for (int i = 0; i < Convert.ToInt32(txtMensagem.Text.Length); i++)
            {
               
                if(txtMensagem.Text.Substring(i, 1) == "a")
                {
                    criptado = "T";
                    txtCriptografia.Text = txtCriptografia.Text + criptado;
                }

            }
        }

        private void btDescriptografar_Click(object sender, RoutedEventArgs e)
        {
            string criptado;

            for (int i = 0; i < Convert.ToInt32(txtCriptografia.Text.Length); i++)
            {

                if (txtCriptografia.Text.Substring(i, 1) == "T")
                {
                    criptado = "a";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "h")
                {
                    criptado = "b";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "o")
                {
                    criptado = "c";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "U")
                {
                    criptado = "d";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ç")
                {
                    criptado = "e";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "L")
                {
                    criptado = "f";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "y")
                {
                    criptado = "g";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "R")
                {
                    criptado = "h";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "7")
                {
                    criptado = "i";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "w")
                {
                    criptado = "j";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "A")
                {
                    criptado = "k";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Q")
                {
                    criptado = "l";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "k")
                {
                    criptado = "m";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "8")
                {
                    criptado = "n";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "6")
                {
                    criptado = "o";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "i")
                {
                    criptado = "p";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "e")
                {
                    criptado = "q";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "v")
                {
                    criptado = "r";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "D")
                {
                    criptado = "s";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "m")
                {
                    criptado = "t";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "X")
                {
                    criptado = "u";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "p")
                {
                    criptado = "v";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "b")
                {
                    criptado = "w";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "f")
                {
                    criptado = "x";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "j")
                {
                    criptado = "y";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "/")
                {
                    criptado = "z";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "t")
                {
                    criptado = "A";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "H")
                {
                    criptado = "B";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "O")
                {
                    criptado = "C";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "u")
                {
                    criptado = "D";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ç")
                {
                    criptado = "E";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "l")
                {
                    criptado = "F";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Y")
                {
                    criptado = "G";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "r")
                {
                    criptado = "H";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "]")
                {
                    criptado = "I";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "W")
                {
                    criptado = "J";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "a")
                {
                    criptado = "K";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "q")
                {
                    criptado = "L";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "K")
                {
                    criptado = "M";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "=")
                {
                    criptado = "N";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == ")")
                {
                    criptado = "O";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "I")
                {
                    criptado = "P";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "E")
                {
                    criptado = "Q";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "V")
                {
                    criptado = "R";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "d")
                {
                    criptado = "S";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "M")
                {
                    criptado = "T";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "x")
                {
                    criptado = "U";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "P")
                {
                    criptado = "V";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "B")
                {
                    criptado = "W";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "F")
                {
                    criptado = "X";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "J")
                {
                    criptado = "Y";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == ">")
                {
                    criptado = "Z";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "+")
                {
                    criptado = "0";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "3")
                {
                    criptado = "1";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "#")
                {
                    criptado = "2";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "*")
                {
                    criptado = "3";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "9")
                {
                    criptado = "4";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "&")
                {
                    criptado = "5";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == ",")
                {
                    criptado = "6";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "c")
                {
                    criptado = "7";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "g")
                {
                    criptado = "8";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "@")
                {
                    criptado = "9";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == " ")
                {
                    criptado = "!";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "$")
                {
                    criptado = "!";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ó")
                {
                    criptado = "?";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "n")
                {
                    criptado = ".";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "0")
                {
                    criptado = "'";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ú")
                {
                    criptado = "+";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Í")
                {
                    criptado = "-";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "?")
                {
                    criptado = ",";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "N")
                {
                    criptado = "=";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ê")
                {
                    criptado = ")";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "÷")
                {
                    criptado = ">";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ã")
                {
                    criptado = "{";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "õ")
                {
                    criptado = "}";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "á")
                {
                    criptado = "/";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "¨")
                {
                    criptado = "^";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ú")
                {
                    criptado = "-";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Á")
                {
                    criptado = "<";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "{")
                {
                    criptado = "ã";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "}")
                {
                    criptado = "õ";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "é")
                {
                    criptado = "á";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "^")
                {
                    criptado = "é";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "1")
                {
                    criptado = "ó";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "4")
                {
                    criptado = "í";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "5")
                {
                    criptado = "ê";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "z")
                {
                    criptado = "ô";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "-")
                {
                    criptado = "ú";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "É")
                {
                    criptado = "à";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "í")
                {
                    criptado = "Ã";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "ê")
                {
                    criptado = "Õ";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "<")
                {
                    criptado = "Á";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == ".")
                {
                    criptado = "É";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "2")
                {
                    criptado = "Ó";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "%")
                {
                    criptado = "Í";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "O")
                {
                    criptado = "Ê";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "z")
                {
                    criptado = "Ô";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "s")
                {
                    criptado = "Ú";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }
                if (txtCriptografia.Text.Substring(i, 1) == "Ô")
                {
                    criptado = "À";
                    txtMensagem.Text = txtMensagem.Text + criptado;
                }

            }
        }
    }
}
