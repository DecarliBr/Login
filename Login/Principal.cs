using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//instanciando biblioteca de conexão com banco de dados

namespace Login
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        //intnanciando os objetos Connect, Command e DataReader
        //Objeto Connect
        SqlConnection cn = new SqlConnection(@"Data Source = DESKTOP-O28HAT6; integrated Security = SSPI; Initial Catalog = Cliente");

        //objeto Command
        SqlCommand cm = new SqlCommand();

        //Objeto DataReader
        SqlDataReader dr;


        private void BTN_EntrarPrincipal_Click(object sender, EventArgs e )
        {
            if(TXT_UsuarioPrincipal.Text == "" || TXT_SenhaPrincipal.Text == "")
            {
                MessageBox.Show("Favor inserir dados para login", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // cn = objeto Connection, abirndo a conexão  com banco de dados
                    cn.Open();

                    //cm = Objeto Commandd, enviando comando de tipo texto para o banco de dados verificar a existencia do dado
                    //utilizando interpolação de Strings ($)
                    cm.CommandText = $"select * from Userlogin where nome = ('{TXT_UsuarioPrincipal.Text}') and senha = ('{TXT_SenhaPrincipal.Text}')";

                    //onde quero que o comando seja executado
                    cm.Connection = cn;

                    //executando leitura dos dados informados nop banco de dados
                    dr = cm.ExecuteReader();

                    if (dr.HasRows)// caso o banco encontre as informações digitadas no txt_usuario e txt_senha ( caso existam as linhas no banco)
                    {
                        MessageBox.Show("Bem vindo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // limpando cmapos usuario e senha
                        TXT_SenhaPrincipal.Clear();
                        TXT_UsuarioPrincipal.Clear();
                    }
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);

                    //encerrando a conexão com o bando de dados
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }

        }

        private void BTN_CadastrarPrincipal_Click(object sender, EventArgs e)
        {
            FRM_CadastroCliente cad = new FRM_CadastroCliente();
            cad.Show();
        }

        private void FRM_Principal_Load(object sender, EventArgs e)
        {

        }

        private void BTN_PrincipalX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXT_SenhaPrincipal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
