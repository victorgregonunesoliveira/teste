using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Principal : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"C:\Users\victorgrego\Documents\Visual Studio 2015\Projects\WebApplication3\WebApplication3\App_Data\Database1.mdf" + ";Integrated Security=True");

                //con = new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString);

                //if (!IsPostBack)
                //{
                //    SqlDataSource SqlDataSource1 = new SqlDataSource();
                //    SqlDataSource1.ID = "SqlDataSource1";
                //    this.Page.Controls.Add(SqlDataSource1);
                //    SqlDataSource1.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                //    SqlDataSource1.SelectCommand = "SELECT * FROM [Pessoa]";
                //    GridPessoas.DataSource = SqlDataSource1;
                //    GridPessoas.DataBind();
                //}

            }

            catch (Exception ex)
            {
                string recebe = ex.ToString();
            }
        }

        protected void btnPesquisar_ServerClick(object sender, EventArgs e)
        {
            //INSERT INTO Customers VALUES ('TPC', 'The Phone Company', 'John Kane', 'Owner', NULL, 'Forks', NULL, NULL, 'USA', NULL, DEFAULT);

            try
            {
                //    string strPesquisa = string.Empty;
                //    if (txtCpf.Value.ToString() != string.Empty)
                //    {
                //        strPesquisa = txtCpf.Value.ToString();
                //    }
                //    else if (txtName.Value.ToString() != string.Empty)
                //    {
                //        strPesquisa = txtName.Value.ToString();
                //    }

                //    GridPessoas.DataSourceID = string.Empty;
                //    SqlDataSource SqlDataSource1 = new SqlDataSource();
                //    SqlDataSource1.ID = "SqlDataSource1";
                //    this.Page.Controls.Add(SqlDataSource1);
                //    SqlDataSource1.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                //    SqlDataSource1.SelectCommand = "select * from Pessoa where Cpf like '%" + strPesquisa + "%'";
                //    GridPessoas.DataSource = SqlDataSource1;
                //    GridPessoas.DataBind();





                //con.Close();



                //string dateString = "23/10/1984";

                //DateTime receve = Convert.ToDateTime(dateString);


                //con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                //con.Open();
                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "insert into Telefone values('5','85','32814640')";
                //cmd.ExecuteNonQuery();

                //con.Close();




                //string dateString = "23/10/1984";

                //DateTime receve = Convert.ToDateTime(dateString);


                //con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                //con.Open();
                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "insert into Pessoa values('5','victor','97219207387','1984-10-23','victorgrego_2@hotmail.com')";
                //cmd.ExecuteNonQuery();

                //con.Close();
            }
            catch (Exception ex)
            {
                string recebe = ex.ToString();
            }
        }

       
        protected void GridPessoas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userid = Convert.ToInt32(GridPessoas.DataKeys[e.RowIndex].Values["Id"].ToString());
            try
            {

                this.SqlDataSource1.DeleteCommand = @"DELETE FROM Pessoa WHERE Id = " + userid;

              
                GridPessoas.DataBind();
            }
            catch (Exception ex)
            {
                //Box.Text = "SQL error" + e;
            }
            


        }

        protected void GridPessoas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            int userid = Convert.ToInt32(GridPessoas.DataKeys[e.RowIndex].Values["Id"].ToString());

            GridViewRow row = GridPessoas.Rows[e.RowIndex];

            string strName = ((TextBox)(row.Cells[1].Controls[0])).Text;
            string strEmail = ((TextBox)(row.Cells[4].Controls[0])).Text;
            string strCpf = ((TextBox)(row.Cells[2].Controls[0])).Text;

            this.SqlDataSource1.UpdateCommand = @"UPDATE Pessoa SET Nome ='" + strName + "',Email ='" + strEmail + "', Cpf ='" + strCpf + "' WHERE ID = " + userid; 
           
            GridPessoas.DataBind();

                     
        }

        protected void btnCadastrar_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro_Pessoa.aspx");
        }
    }
}