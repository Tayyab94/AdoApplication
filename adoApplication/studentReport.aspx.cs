using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adoApplication
{
    public partial class studentReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data SOURCE=ahad; DATABASE=dbStudent; INTEGRATED SECURITY=true");
            SqlCommand cmd = new SqlCommand("SELECT NAME,DEPARTMENT,GENDER,SUBJECTS FROM tblStudent", conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentForm.aspx");
        }
    }
}