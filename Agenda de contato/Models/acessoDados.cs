using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Agenda_de_contato.Models
{
    public class acessoDados
    {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter adapt;

            public bool cadastrar(string strCommand)
            {
                try
                {
                    if (executar(strCommand))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private bool executar(string strCommand)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-TJ20GPL;Initial Catalog=pizzaria;Integrated Security=True");
                    cmd = new SqlCommand(strCommand, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public SqlDataReader listar(string strCommand)
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-TJ20GPL;Initial Catalog=pizzaria;Integrated Security=True");
                    cmd = new SqlCommand(strCommand, con);
                    con.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    return dataReader;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        
    }
    
}