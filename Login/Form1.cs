using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void BTN_EntrarPrincipal_Click(object sender, EventArgs e )
        {
            try
            {
                //Equals é um metodo da classe String para comparar o Text
                //Text é a informação que escrevemos no textbox
                if (TXT_UsuarioPrincipal.Text.Equals("Henrique") && TXT_SenhaPrincipal.Text.Equals("1234")){
                    MessageBox.Show("Bem Vindo");
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }

        }
    }
}
