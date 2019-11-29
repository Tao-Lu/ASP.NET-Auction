using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registerForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblAgeValidation.Visible = false;
        lblCheckEmail.Visible = false;
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //user enter date of birth
        if (tbxDOB.Text != "")
        {
            //check the age of member (21 years old)
            DateTime memberDob = Convert.ToDateTime(tbxDOB.Text);
            DateTime currentDate = DateTime.Today;
            //get the days from memberDob to currentDate
            System.TimeSpan days = currentDate - memberDob;
            double getDay = days.TotalDays;
            //dob is on current date (NOW) or in the furture
            if (getDay <= 0)
            {
                lblAgeValidation.Text = "wrong date of birth";
                lblAgeValidation.Visible = true;
            }
            else
            {
                //calculate the age of member
                int age = Convert.ToInt32(getDay / 365);
                //age is above 21 years old
                if (age >= 21)
                {
                    //is a same email in the database
                    //YES
                    if (MemberDB.existEmail(tbxEmail.Text))
                    {
                        lblCheckEmail.Text = "This email address has been regisered";
                        lblCheckEmail.Visible = true;
                    }
                    //NO
                    else
                    {
                        //create a new member
                        Member newMember = new Member();
                        newMember.Name = tbxName.Text;
                        newMember.Gender = RadioButtonList_Gender.Text;
                        newMember.Dob = Convert.ToDateTime(tbxDOB.Text);
                        newMember.Address = tbxAddress.Text;
                        newMember.Email = tbxEmail.Text;
                        newMember.Password = tbxPasswordVerify.Text;
                        newMember.Phone = Convert.ToInt32(tbxPhone.Text);
                        newMember.Type = "bidder";
                        newMember.Status = "active";
                        //insert new member into database
                        if (MemberDB.insertMember(newMember) > 0)
                        {
                            lblSuccessful.Text = "registration successful!!!";
                            lblSuccessful.Visible = true;
                        }
                        else
                        {
                            lblSuccessful.Text = "registration fail!!!";
                            lblSuccessful.Visible = true;
                        }
                    }
                }
                //age is below 21 years old
                else
                {
                    lblAgeValidation.Text = "you are below 21 years old";
                    lblAgeValidation.Visible = true;
                }
            }
        }
    }
}