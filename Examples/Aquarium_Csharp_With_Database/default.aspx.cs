using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aquarium_Csharp_With_Database
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            Session.Add("length", lengthTextBox.Text);
            Session.Add("width", widthTextBox.Text);
            Session.Add("height", heightTextBox.Text);

            Response.Redirect("display_answer.aspx");
        }
    }
}