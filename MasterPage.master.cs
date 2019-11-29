using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // no member logs in
        if (Session["member"] == null)
        {
            btnLogin.Text = "Login";
        }
        // member has log in
        else
        {
            btnMember.Text = Session["member"].ToString();
            lblMemberId.Text = Session["memberId"].ToString();
            btnMember.Visible = true;
            btnRegister.Visible = false;
            btnLogin.Text = "Logout";
        }
    }

    //log in or log out
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // log in
        if (btnLogin.Text == "Login")
            Server.Transfer("logInForm.aspx");
        // log out
        else
        {
            Session["member"] = null;
            Session["memberId"] = null;
            btnMember.Text = "";
            btnMember.Visible = false;
            btnRegister.Visible = true;
            btnLogin.Text = "Login";
            Server.Transfer("logInForm.aspx");
        }
    }

    //clicking register button goes to register form
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Server.Transfer("registerForm.aspx");
    }

    //clicking member button goes to member detail form
    protected void btnMember_Click(object sender, EventArgs e)
    {
        Server.Transfer("memberFormMember.aspx");
    }
}
