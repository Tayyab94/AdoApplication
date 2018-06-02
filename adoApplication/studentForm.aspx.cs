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
    public partial class studentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                SqlConnection conn = new SqlConnection("Data SOURCE=ahad; DATABASE=dbStudent; INTEGRATED SECURITY=true");
                SqlCommand cmd = new SqlCommand("SELECT ID,NAME FROM tblStudent", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlStudents.DataSource = dt;
                ddlStudents.DataTextField = "NAME";
                ddlStudents.DataValueField = "ID";
                ddlStudents.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            String gender;
            if (rdBtnMale.Checked)
                gender = rdBtnMale.Text;
            else
                gender = rdBtnFemale.Text;

            String subject = "";
            if (cboxPhy.Checked)
                subject = cboxPhy.Text;
            if (cboxChem.Checked)
            {
                if (subject != "")
                    subject += ",";
                subject += cboxChem.Text;
            }
            if (cboxBio.Checked)
            {
                if (subject != "")
                    subject += ",";
                subject += cboxBio.Text;
            }

            String path = "~/Picture/" + fuPicture.FileName;
            String fullPath = Server.MapPath(path);
            fuPicture.SaveAs(fullPath);

            SqlConnection conn = new SqlConnection("Data SOURCE=ahad; DATABASE=dbStudent; INTEGRATED SECURITY=true");
            SqlCommand cmd = new SqlCommand("Insert into tblStudent (NAME,AGE,DEPARTMENT,GENDER,SUBJECTS,PROFILE) values ('"+txtName.Text+"','"+txtAge.Text+"','"+ddlDepartment.SelectedItem.Text+"','"+gender+"','"+subject+"','"+path+"')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Write("Saved Successfully");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentReport.aspx");
        }

        protected void ddlStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data SOURCE=ahad; DATABASE=dbStudent; INTEGRATED SECURITY=true");
            SqlCommand cmd = new SqlCommand("SELECT NAME,AGE,DEPARTMENT,GENDER,SUBJECTS,PROFILE FROM tblStudent WHERE ID='"+ddlStudents.SelectedItem.Value+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            txtName.Text = dt.Rows[0]["NAME"].ToString();
            txtAge.Text = dt.Rows[0]["AGE"].ToString();
            ddlDepartment.SelectedValue = dt.Rows[0]["DEPARTMENT"].ToString();
            Image1.ImageUrl = dt.Rows[0]["PROFILE"].ToString();
            String gender = dt.Rows[0]["GENDER"].ToString();
            if (gender == "Male")
            {
                rdBtnMale.Checked = true;
                rdBtnFemale.Checked = false;
            }
            else
            {
                rdBtnFemale.Checked = true;
                rdBtnMale.Checked = false;
            }
            String subject = dt.Rows[0]["Subjects"].ToString();
            String[] sub = subject.Split(',');

            for(int i=0; i<sub.Length; i++)
            {
                //if (sub[i].ToString() == cboxPhy.Text)
                //    cboxPhy.Checked = true;
                //else if (sub[i].ToString() == cboxChem.Text)
                //    cboxChem.Checked = true;
                //else if (sub[i].ToString() == cboxBio.Text)
                //    cboxBio.Checked = true;
                switch(sub[i].ToString())
                {
                    case "Physics":
                        cboxPhy.Checked = true;
                        break;
                    case "Chemistry":
                        cboxChem.Checked = true;
                        break;
                    case "Biology":
                        cboxBio.Checked = true;
                        break;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data SOURCE=ahad; DATABASE=dbStudent; INTEGRATED SECURITY=true");
            SqlCommand cmd = new SqlCommand("DELETE FROM tblStudent WHERE ID = '"+ddlStudents.SelectedItem.Value+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Write("Deleted Successfully");

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            String gender;
            if (rdBtnMale.Checked)
                gender = rdBtnMale.Text;
            else
                gender = rdBtnFemale.Text;

            String subject = "";
            if (cboxPhy.Checked)
                subject = cboxPhy.Text;
            if (cboxChem.Checked)
            {
                if (subject != "")
                    subject += ",";
                subject += cboxChem.Text;
            }
            if (cboxBio.Checked)
            {
                if (subject != "")
                    subject += ",";
                subject += cboxBio.Text;
            }

            String path = "~/Picture/" + fuPicture.FileName;
            String fullPath = Server.MapPath(path);
            fuPicture.SaveAs(fullPath);

            SqlConnection conn = new SqlConnection("Data SOURCE=ahad; DATABASE=dbStudent; INTEGRATED SECURITY=true");
            SqlCommand cmd = new SqlCommand("Update tblStudent SET NAME='"+txtName.Text+ "', AGE='"+txtAge.Text+ "',DEPARTMENT='"+ddlDepartment.SelectedItem.Text+ "', GENDER='"+gender+ "', SUBJECTS='"+subject+ "',PROFILE='"+path+ "' WHERE ID='" + ddlStudents.SelectedItem.Value+"'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Write("Record Updated Successfully");
        }
    }
}