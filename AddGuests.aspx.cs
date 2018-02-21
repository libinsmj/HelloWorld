using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenInitiative
{
    public partial class AddGuests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillTitle();
            }
        }


        public void FillTitle()
        {
            DBManager db = new DBManager();
            DataTable dt = db.GetDataTableInline("select TitleId,Title from Title_Details");
            drptitle.DataSource = dt;
            drptitle.DataValueField = "TitleId";
            drptitle.DataTextField = "Title";
            drptitle.DataBind();
        }
        protected void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager db = new DBManager();
                string filename = Path.GetFileName(filephoto.FileName);
                filephoto.SaveAs(Server.MapPath("~/images/Guests/" + filename));
                string sfilename = "/images/Guests/" + filename;
                String sql = "insert into Guest_Details ([TitleId],[GuestName],[Position],[Organisation],[MobileNo],[Email],[Imagepath],[linkiden]) values (";
                sql += @"" + drptitle.SelectedValue.Trim() + ",";
                sql += @"'" + txtname.Text.Trim() + "',";
                sql += @"'" + txtdes.Text.Trim() + "',";
                sql += @"'" + txtorg.Text.Trim() + "',";
                sql += @"'" + txtmob.Text.Trim() + "',";
                sql += @"'" + txtemail.Text.Trim() + "',";
                sql += @"'" + sfilename + "',";
                sql += @"'" + txtprof.Text + "')";
                db.InsertRecord(sql);
                MsgBox("Registered Successfully", this.Page, this);
                ClearFields();
                //Response.Redirect("Home.aspx");
            }
            catch (Exception ex)
            {
                MsgBox(ex.Message, this.Page, this);
            }
        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        public void ClearFields()
        {
            txtdes.Text = "";
            txtemail.Text = "";
            txtmob.Text = "";
            txtname.Text = "";
            txtorg.Text = "";
            txtprof.Text = "";
            
        }
    }
}