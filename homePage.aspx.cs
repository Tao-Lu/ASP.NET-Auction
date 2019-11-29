using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class homePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //up to 7 days items
            dtlLastWeekItem.DataSource = ItemDB.getLastWeekItem();
            dtlLastWeekItem.DataBind();
            //current available items
            dtlCurrentAvailableItem.DataSource = ItemDB.getCurrentAvailableItem();
            dtlCurrentAvailableItem.DataBind();
        }

    }

    //Question (last week) button related to item
    protected void lnkBtnQuestionLastWeek_Click(object sender, EventArgs e)
    {
        //get item id
        if (Session["itemId"] == null)
        {
            string text = (((sender as LinkButton).NamingContainer as DataListItem).FindControl("lblItemId") as Label).Text;
            Session["itemId"] = text;
        }
        else
        {
            Session["itemId"] = null;
            string text = (((sender as LinkButton).NamingContainer as DataListItem).FindControl("lblItemId") as Label).Text;
            Session["itemId"] = text;
        }
        Server.Transfer("FAQForm.aspx");
    }

    //Question (current available) button related to item
    protected void lnkBtnQuestionCurrent_Click(object sender, EventArgs e)
    {
        //get item id
        if (Session["itemId"] == null)
        {
            string text = (((sender as LinkButton).NamingContainer as DataListItem).FindControl("lblItemId") as Label).Text;
            Session["itemId"] = text;
        }
        else
        {
            Session["itemId"] = null;
            string text = (((sender as LinkButton).NamingContainer as DataListItem).FindControl("lblItemId") as Label).Text;
            Session["itemId"] = text;
        }
        Server.Transfer("FAQForm.aspx");
    }

    //bid (current available) button
    protected void lnkBtnBid_Click(object sender, EventArgs e)
    {
        //member does not log in
        if (Session["member"] == null)
            Server.Transfer("logInForm.aspx");
        else
        {
            //get item id
            if (Session["itemId"] == null)
            {
                string text = (((sender as LinkButton).NamingContainer as DataListItem).FindControl("lblItemId") as Label).Text;
                Session["itemId"] = text;
            }
            else
            {
                string text = (((sender as LinkButton).NamingContainer as DataListItem).FindControl("lblItemId") as Label).Text;
                Session["itemId"] = text;
            }
            Server.Transfer("biddingForm.aspx");
        }
    }
}