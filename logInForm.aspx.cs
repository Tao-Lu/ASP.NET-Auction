using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logInForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // get the email and password of the member who logs in
        Member loginMember = new Member();
        loginMember.Email = tbxEmail.Text;
        loginMember.Password = tbxPassword.Text;

        //get all member's information from the database
        List<Member> memberList = new List<Member>();
        memberList = MemberDB.getAllMember();

        //check member's email, password, status(debarred)
        bool exist = false;
        foreach (Member member in memberList)
        {
            // check the member'email
            //correct email address
            if (string.Compare(member.Email, loginMember.Email) == 0)
            {
                //this email exists in the database
                exist = true;
                // check the member's status
                //this account is not debarred
                if (string.Compare(member.Status, "active") == 0)
                {
                    //check account type
                    if (string.Compare(member.Type, "bidder") == 0)
                        // check the member's password
                        //correct password
                        if (string.Compare(member.Password, loginMember.Password) == 0)
                        {
                            Session["member"] = member.Email;
                            Session["memberId"] = member.MemberId;
                            Server.Transfer("homePage.aspx");
                            break;
                        }
                        //wrong password
                        else
                        {
                            lblOutput.Text = "wrong password";
                            lblOutput.Visible = true;
                            break;
                        }
                    else
                    {
                        lblOutput.Text = "your account is not a bidder account";
                        lblOutput.Visible = true;
                        break;
                    }
                }
                //this account is debarred
                else
                {
                    lblOutput.Text = "your account is debarred";
                    lblOutput.Visible = true;
                    break;
                }
            }
        }
        //this email does not exist in the database
        if (!exist)
        {
            lblOutput.Text = "this email address has not been registered";
            lblOutput.Visible = true;
        }
    }
}