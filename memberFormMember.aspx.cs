using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //get member id, and show detail of member
            string memberId = Session["memberId"].ToString();
            Member member = new Member();
            member = MemberDB.getMemberById(memberId);
            tbxName.Text = member.Name;
            tbxGender.Text = member.Gender;
            tbxDOB.Text = member.Dob.ToString();
            tbxAddress.Text = member.Address;
            tbxEmail.Text = member.Email;
            tbxPassword.Text = member.Password;
            tbxPhone.Text = member.Phone.ToString();
        }

        btnUpdate.Visible = false;
        btnUpdate.Enabled = false;
        btnCancle.Visible = false;
        btnCancle.Enabled = false;

        tbxName.ReadOnly = true;
        tbxName.ForeColor = System.Drawing.Color.Black;
        tbxAddress.ReadOnly = true;
        tbxAddress.ForeColor = System.Drawing.Color.Black;
        tbxPassword.ReadOnly = true;
        tbxPassword.ForeColor = System.Drawing.Color.Black;
        tbxPhone.ReadOnly = true;
        tbxPhone.ForeColor = System.Drawing.Color.Black;
    }
    //member can change some of the details
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        tbxName.ReadOnly = false;
        tbxName.ForeColor = System.Drawing.Color.Red;
        tbxAddress.ReadOnly = false;
        tbxAddress.ForeColor = System.Drawing.Color.Red;
        tbxPassword.ReadOnly = false;
        tbxPassword.ForeColor = System.Drawing.Color.Red;
        tbxPhone.ReadOnly = false;
        tbxPhone.ForeColor = System.Drawing.Color.Red;
        btnUpdate.Enabled = true;
        btnUpdate.Visible = true;
        btnCancle.Visible = true;
        btnCancle.Enabled = true;

    }
    //update the details of the member
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string name = tbxName.Text;
        string address = tbxAddress.Text;
        string password = tbxPassword.Text;
        int phone = Convert.ToInt32(tbxPhone.Text);
        string email = tbxEmail.Text;
        if (MemberDB.updateMemberDetail(name, address, password, phone, email) > 0)
            lblOutput.Text = "update successful";
        else
            lblOutput.Text = "update fail";
    }
    //cancel the update
    protected void btnCancle_Click(object sender, EventArgs e)
    {
        btnUpdate.Visible = false;
        btnUpdate.Enabled = false;

        tbxName.ReadOnly = true;
        tbxName.ForeColor = System.Drawing.Color.Black;
        tbxAddress.ReadOnly = true;
        tbxAddress.ForeColor = System.Drawing.Color.Black;
        tbxPassword.ReadOnly = true;
        tbxPassword.ForeColor = System.Drawing.Color.Black;
        tbxPhone.ReadOnly = true;
        tbxPhone.ForeColor = System.Drawing.Color.Black;

        string memberId = Session["memberId"].ToString();
        Member member = new Member();
        member = MemberDB.getMemberById(memberId);
        tbxName.Text = member.Name;
        tbxAddress.Text = member.Address;
        tbxPassword.Text = member.Password;
        tbxPhone.Text = member.Phone.ToString();
    }
}