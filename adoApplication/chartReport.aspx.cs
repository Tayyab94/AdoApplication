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
    public partial class chartReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data SOURCE=ahad; DATABASE=dbStudent; INTEGRATED SECURITY=true");
            SqlCommand cmd = new SqlCommand("SELECT MONTH,PURCHASE,SALE,SALE-PURCHASE AS 'PROFIT' FROM tblTransactions", conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            Chart1.DataSource = dt;
            Chart1.Series["Series1"].XValueMember = "MONTH";
            Chart1.Series["Series1"].YValueMembers = "PURCHASE";
            Chart1.Series["Series2"].XValueMember = "MONTH";
            Chart1.Series["Series2"].YValueMembers = "SALE";
            Chart1.Series["Series3"].XValueMember = "MONTH";
            Chart1.Series["Series3"].YValueMembers = "PROFIT";
            Chart1.DataBind();

        }
    }
}