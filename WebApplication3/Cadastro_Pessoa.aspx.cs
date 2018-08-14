using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Cadastro_Pessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregaGV();
        }
        protected void CarregaGV()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Cod", System.Type.GetType("System.String"));
            dt.Columns.Add("Coluna 2", System.Type.GetType("System.String"));
            dt.Columns.Add("Coluna 3", System.Type.GetType("System.String"));

            //for (int i = 1; i < 10; i++)
            //{
            //    dt.Rows.Add(new String[] { i.ToString(), "Coluna 2", "Coluna 3" });
            //}

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void btnAddCadastro_ServerClick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", System.Type.GetType("System.String"));
            dt.Columns.Add("DDD", System.Type.GetType("System.String"));
            dt.Columns.Add("Telefone", System.Type.GetType("System.String"));

            for (int i = 1; i < 2; i++)
            {
                dt.Rows.Add(new String[] { i.ToString(), txtDDDCadastro.Value.ToString(), txtTelefoneCadastro.Value.ToString() });
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnSalvar_ServerClick(object sender, EventArgs e)
        {

            


            //int userid = Convert.ToInt32(GridPessoas.DataKeys[e.RowIndex].Values["Id"].ToString());

            foreach (GridViewRow rows in this.GridView1.Rows)
            {
                this.SqlDataSource1.InsertCommand = @"INSERT INTO Telefone(Id,DDD,Telefone)VALUES (1," + rows.Cells[1].Text.ToString().Trim() +"," + rows.Cells[2].Text.ToString().Trim() + ")";
            }


            GridView1.DataBind();



        }
    }
}