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
    public partial class FRM_CadastroCliente : Form
    {
        public FRM_CadastroCliente()
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



        private void BTN_CadastrarCadastro_Click(object sender, EventArgs e)
        {

            if (TXT_NomeCadastro.Text == "" || TXT_SenhaCadastro.Text == "")
            {
                MessageBox.Show("Favor inserir dados para cadastro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                try
                {
                    // cn = objeto Connection, abirndo a conexão  com banco de dados
                    cn.Open();

                    //cm = Objeto Commandd, enviando comando de tipo texto para o banco de dados verificar a existencia do dado
                    //utilizando interpolação de Strings ($)
                    cm.CommandText = $"insert into Userlogin (nome, senha) values( '{TXT_NomeCadastro.Text}','{TXT_SenhaCadastro.Text}' )";

                    //onde quero que o comando seja executado
                    cm.Connection = cn;

                    //executando leitura dos dados informados nop banco de dados
                    dr = cm.ExecuteReader();

                    MessageBox.Show("Usuario cadastrado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_CadastroCliente cad = new FRM_CadastroCliente();
                    cad.Close();
                    
                }
                catch (Exception erro)
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

        private void BTN_CadastroX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXT_SenhaCadastro_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
