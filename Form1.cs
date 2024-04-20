using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANTE
{
    public partial class Form1 : Form
    {


        string usuario_1 = "JOSE";
        string clave_1 = "SIFTWORD";

        string usuario_2 = "SEBASTIAN";
        string clave_2 = "BORASMENTE";

        string usuario_3 = "SILVIA";
        string clave_3 = "SILBARRI";

        int intUsuario1 = 0;
        int intUsuario2 = 0;
        int intUsuario3 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != usuario_1 || textBox2.Text != clave_1) &&
                (textBox1.Text != usuario_2 || textBox2.Text != clave_2) &&
                (textBox1.Text != usuario_3 || textBox2.Text != clave_3))
            {
                if ((textBox1.Text != usuario_1) &&
                (textBox1.Text != usuario_2) &&
                (textBox1.Text != usuario_3))
                {
                    MessageBox.Show("¡¡¡ USUARIO INCORRECTO !!!");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    if (textBox1.Text != usuario_1)
                        intUsuario1++;
                    else if (textBox1.Text != usuario_2)
                        intUsuario2++;
                    else if (textBox1.Text != usuario_3)
                        intUsuario3++;

                    if (intUsuario1 >= 3 || intUsuario2 >= 3 || intUsuario3 >= 3)
                    {
                        MessageBox.Show(" Demasiados intentos con este usuario, ha sido bloqueado.");
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        button1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("¡¡¡ CONTRASEÑA INCORRECTA !!!");
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
            }

            else
            {
                textBox1.Clear();
                textBox2.Clear();
                this.Hide(); // ocultar
                Form2 form = new Form2();
                form.ShowDialog();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (!checkBox1.Checked == true)
            {
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }

            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
