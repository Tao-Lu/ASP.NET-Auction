using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// using for sending email to members
using System.Net;
using System.Net.Mail;

public partial class forgetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblOutput.Visible = false;
    }

    //send an email to forget password member
    protected void btnSendRecoveryEmail_Click(object sender, EventArgs e)
    {
        // get the forget password member's email
        Member forgetPWDMember = new Member();
        forgetPWDMember.Email = tbxEmail.Text;

        //get all member's information from the database
        List<Member> memberList = new List<Member>();
        memberList = MemberDB.getAllMember();

        //check forget password member's email
        bool exist = false;
        foreach (Member member in memberList)
        {
            // check the member'email
            //correct email address
            if (string.Compare(member.Email, forgetPWDMember.Email) == 0)
            {
                //this email exists in the database
                exist = true;

                //send the email
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                //the email which is used to send forget password email to member
                client.Credentials = new NetworkCredential("inft3050test@gmail.com", "inft3050");
                //from ... to ...
                MailMessage msg = new MailMessage("inft3050@gmail.com", forgetPWDMember.Email);
                //the email subject and body
                msg.Subject = "Forget Password";
                msg.Body = "Here is a recovery link.";
                //send email
                client.Send(msg);
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