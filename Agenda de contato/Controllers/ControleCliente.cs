using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Agenda_de_contato.Controllers
{
    public class ControleCliente
    {
        Models.acessoDados acesso = new Models.acessoDados();
        //Propriedades
        #region Properties 


        private double telefone = 0;
        public double txtTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }
        private string nome = "";
        public string txtNome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        private string email = "";
        public string txtEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }



        public SqlCommand cmd { get; private set; }


        #endregion Properties
        //Métodos
        #region Methods
        public bool cadastrar()
        {   //Duas formas de implementar: 1 - montando o comando sql em uma string na classe de negócio, podendo fazer regras para escrita dinâmica do sql ainda na camada de controle (negócio)

            try
            {
                string SqlCommand = "INSERT INTO tbContatos(nome,telefone,email) VALUES (@nome,@telefone,@email)";
                //cmd = new SqlCommand(="INSERT INTO tbCliente(cpf,nome,codPerfil,dddtelefone,telefone,endereco,email,senha) VALUES (@cpf,@nome,@Codperfil,@dddtelefone,@telefone,@endereco,@email,@senha)", con);
                //strSQL.Replace("INSERT", "BBB");
                SqlCommand = SqlCommand.Replace("@nome", "'" + txtNome + "'");
                SqlCommand = SqlCommand.Replace("@telefone", txtTelefone.ToString());
                SqlCommand = SqlCommand.Replace("@email", "'" + txtEmail + "'");
                if (acesso.cadastrar(SqlCommand))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //2. Passar o objeto inteiro para a classe acesso a dados e lá é montado o sql.

        }
        public bool excluir()
        {
            try
            {

                string SqlCommand = "DELETE FROM tbContatos  WHERE (nome = @nome)";
                SqlCommand = SqlCommand.Replace("@nome", "'" + txtNome + "'");
                if (acesso.cadastrar(SqlCommand))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool alterar()
        {
            try
            {
                string SqlCommand = "UPDATE tbContatos SET nome=@nome, telefone=@telefone, email=@email";
                //  SqlCommand adoCmd = new SqlCommand("UPDATE tbCliente SET nome=@nome, codPerfil=@codperfil, endereco=@endereco, dddtelefone=@dddtelefone, telefone=@telefone, email=@email, senha=@senha WHERE cpf=@cpf", con);
                SqlCommand = SqlCommand.Replace("@nome", "'" + txtNome + "'");
                SqlCommand = SqlCommand.Replace("@telefone", txtTelefone.ToString());
                SqlCommand = SqlCommand.Replace("@email", "'" + txtEmail + "'");
                if (acesso.cadastrar(SqlCommand))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion Methods
    }
}