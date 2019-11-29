using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FAQForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get item id which item is selected, then get the question of this item
        string itemId = Session["itemId"].ToString();
        gvFAQ.DataSource = FAQDB.getFAQByItemId(itemId);
        gvFAQ.DataBind();
    }

    protected void btnAsk_Click(object sender, EventArgs e)
    {
        if (tbxAskQuestion.Text!="")
        {
            //if user does not log in
            if (Session["member"] == null)
                Server.Transfer("logInForm.aspx");
            //user log in, post a question with specific item
            else
            {
                string question = tbxAskQuestion.Text;
                string itemId = Session["itemId"].ToString();
                string memberId = Session["memberId"].ToString();
                DateTime date = DateTime.Now;
                if (FAQDB.insertNewFAQ(question, date, memberId, itemId)>0)
                {
                    lblOutput.Text = "successful";
                    lblOutput.Visible = true;
                }
                else
                {
                    lblOutput.Text = "failed";
                    lblOutput.Visible = true;
                }
            }
        }
    }
}