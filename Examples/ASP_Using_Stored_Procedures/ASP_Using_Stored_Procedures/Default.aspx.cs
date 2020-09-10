using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Using_Stored_Procedures
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLoadSpecific_Click(object sender, EventArgs e)
        {
            //variables used to demo on hand and storehouse values - replace with values entered by user
            int onHand = 10;
            char storehouse = '3';
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAL_Test;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Sample_Procedure", conn);            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@p_on_hand", onHand));
            cmd.Parameters.Add(new SqlParameter("@p_storehouse", storehouse));
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet("Items_For_OnHand_And_Storehouse");
            da.Fill(ds);
            
            GridView2.DataSource = ds;
            GridView2.DataBind();
            GridView2.Visible = true;

        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
        }
    }
}