using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace GreenInitiative
{
    public partial class AddTree : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //DBManager db = new DBManager();
                //DataTable dt= db.GetDataTableInline("select  GuestId,GuestName from Guest_Details");
                //drpguest.DataSource = dt;
                //drpguest.DataValueField = "GuestId";
                //drpguest.DataTextField = "GuestName";
                //drpguest.DataBind();
            }
        }

        protected void btntreesub_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager db = new DBManager();
                string filename = Path.GetFileName(filephoto.FileName);
                int userid = Convert.ToInt16(Session["UserId"]);
                filephoto.SaveAs(Server.MapPath("~/images/students/" + filename));
                string sfilename = "/images/students/" + filename;
                String sql = "insert into Tree_Details ([TreeName],[Description],[DatePlanted],[LastModDate],[Location],[UserId]) values (";
                sql += @"'" + txttreename.Text.Trim() + "',";
                sql += @"'" + txtdes.Text.Trim() + "',GETDATE(),GETDATE(),";
                sql += @"'" + txtloc.Text.Trim() + "',";
                sql += @"" + userid + ");select @@identity";
                //sql += @"" + drpguest.SelectedValue + ;
                int retid= db.InsertRecordScaler(sql);
                string sql1 = "insert into Tree_Image (TreeId,ImagePath,UpdateDate,Active) values (";
                sql1 += @"" + retid + ",";
                sql1 += @"'" + sfilename + "',GETDATE(),1)";
                db.InsertRecord(sql1);
                MsgBox("Tree added Successfully", this.Page, this);
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
    }
}