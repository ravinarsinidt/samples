using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.txtId.Text = "Ravi";
            // Get data from DB
            // Set data to controls
        }
    }
}