using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Agenda_de_contato.Views
{
    public partial class AgendaTelefonica : System.Web.UI.Page
    {
        Controllers.ControleCliente ctrCliente = new Controllers.ControleCliente();

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntCadastro_Click(object sender, EventArgs e)
        {
            try
            {

                ctrCliente.txtTelefone = double.Parse(txtTelefone.Text);
                ctrCliente.txtNome = txtNome.Text;
                ctrCliente.txtEmail = txtEmail.Text;
                if (ctrCliente.cadastrar())
                    lblResultado.Text = "Registro incluído com sucesso...";
                else
                    lblResultado.Text = "Falha ao cadastrar o registro";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message.ToString();
            }
            txtNome.Text = (" ");
            txtEmail.Text = (" ");
            txtTelefone.Text = (" ");
        }

        protected void BntDExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ctrCliente.txtNome = txtNome.Text;
                if (ctrCliente.excluir())
                    lblResultado.Text = "Registro deletado com sucesso...";
                else
                    lblResultado.Text = "Falha ao deletar o registro";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message.ToString();
            }
            txtNome.Text = (" ");
            txtEmail.Text = (" ");
            txtTelefone.Text = (" ");
        }

        protected void bntBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-TJ20GPL;Initial Catalog=pizzaria;Integrated Security=True");

                con.Open();
                string sql = "SELECT * FROM tbContatos where nome = " + "'" + txtNome.Text + "'";
                SqlCommand adoCmd = new SqlCommand(sql, con);

                SqlDataReader adoDR = adoCmd.ExecuteReader();

                if (adoDR.HasRows)
                {
                    if (adoDR.Read())
                    {
                        txtNome.Text = adoDR["nome"].ToString();
                        txtTelefone.Text = adoDR["telefone"].ToString();
                        txtEmail.Text = adoDR["email"].ToString();
                    }

                }

                lblResultado.Text = "Consulta realizada com sucesso...";
                con.Close();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message.ToString();
            }
        }

        protected void bntAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrCliente.txtTelefone = double.Parse(txtTelefone.Text);
                ctrCliente.txtNome = txtNome.Text;
                ctrCliente.txtEmail = txtEmail.Text;

                if (ctrCliente.alterar())
                    lblResultado.Text = "Registro alterado com sucesso...";
                else
                    lblResultado.Text = "Falha ao alterar o registro";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message.ToString();
            }
            txtEmail.Text = (" ");
            txtNome.Text = (" ");
            txtTelefone.Text = (" ");





        }
    }
}
    
