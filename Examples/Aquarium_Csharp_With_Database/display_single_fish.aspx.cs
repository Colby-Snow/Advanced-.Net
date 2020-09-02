using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aquarium_Csharp_With_Database
{
    public partial class display_single_fish : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //validate there is something to search on
            if (searchTextBox.Text.Trim() == String.Empty)
            {
                Response.Write("<script type=\"text/javascript\">alert(\"Search value is required, try again.\");</script");
            }
            else
            { 
                try
                {
                    //create a data source tied to the connection string from Web.config
                    SqlDataSource dsSource = new SqlDataSource();
                    dsSource.ConnectionString = ConfigurationManager.ConnectionStrings["AquariumConnectionString"].ToString();

                    //define a SelectCommand set to the sql string
                    //String sql = "Select * from fish where name = @pName";
                    String sql = "Select * from fish where upper(name) like '%' + @pName + '%'";
                    //String sql = "Select * from fish where id = @pId";
                    dsSource.SelectCommand = sql;

                    //since sql command has a parameter, add a parameter to the command
                    //with the search value from form
                    dsSource.SelectParameters.Add("pName", searchTextBox.Text.ToUpper());
                    //dsSource.SelectParameters.Add("pId", searchTextBox.Text);

                    //create a DataView object from the rows returned from the SQL query
                    DataView dv = new DataView();
                    dv = (DataView)dsSource.Select(DataSourceSelectArguments.Empty);

                    //Only 1 row with 4 columns (id, name, cost, type) should be returned from the query with ID
                    //Multiple rows could be returned with search by name (only showing first row returned)
                    fishNameLabel.Text = dv.Table.Rows[0].Field<String>(1).ToString();  //name
                    fishCostLabel.Text = dv.Table.Rows[0].Field<Decimal>(2).ToString();  //cost
                    fishTypeLabel.Text = dv.Table.Rows[0].Field<String>(3).ToString();  //type
                }
                catch (Exception exc)
                {
                    Response.Write("<script type=\"text/javascript\">alert(\"Error retrieving data\");</script");
                }
            }
        }
    }
}