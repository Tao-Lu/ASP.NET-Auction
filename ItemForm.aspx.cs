using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ItemForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //show all items
            dtlItem.DataSource = ItemDB.getAllItem();
            dtlItem.DataBind();
            
            //compare the current date, start date and end date of the item, if item is current available to bid,
            //show bid button, otherwise only show question button.
            foreach (DataListItem listItem in dtlItem.Items)
            {
                //get the start date of the item
                Label lblStartDate = (Label)listItem.FindControl("lblStrartDateOfTheBid");
                DateTime startBidDate = Convert.ToDateTime(lblStartDate.Text);
                //get the duration of the item
                Label lblDuration = (Label)listItem.FindControl("lblDuration");
                int duration = Convert.ToInt32(lblDuration.Text);
                //the end date of the item
                DateTime endBidDate = startBidDate.AddDays(duration);
                //item is not available
                if(endBidDate<DateTime.Now || startBidDate>DateTime.Now)
                {
                    LinkButton bidButton= (LinkButton)listItem.FindControl("lnkBtnBid");
                    bidButton.Visible = false;
                }
            }
        }
    }

    //category button, show the items which are included in selected category
    protected void Button1_Click(object sender, EventArgs e)
    {
        //fill in the drop down list
        dtlItem.DataSource = ItemDB.getItemByCategory(ddlCategory.SelectedValue);
        dtlItem.DataBind();
        //compare the current date, start date and end date of the item, if item is current available to bid,
        //show bid button, otherwise only show question button.
        foreach (DataListItem listItem in dtlItem.Items)
        {
            //get strat date of the item
            Label lblStartDate = (Label)listItem.FindControl("lblStrartDateOfTheBid");
            DateTime startBidDate = Convert.ToDateTime(lblStartDate.Text);
            //get duration of the item
            Label lblDuration = (Label)listItem.FindControl("lblDuration");
            int duration = Convert.ToInt32(lblDuration.Text);
            //the end date of the item
            DateTime endBidDate = startBidDate.AddDays(duration);
            //item is not available
            if (endBidDate < DateTime.Now || startBidDate > DateTime.Now)
            {
                LinkButton bidButton = (LinkButton)listItem.FindControl("lnkBtnBid");
                bidButton.Visible = false;
            }
        }
    }

    //all category button, show all items
    protected void btnAllItems_Click(object sender, EventArgs e)
    {
        //show all items
        dtlItem.DataSource = ItemDB.getAllItem();
        dtlItem.DataBind();
        //compare the current date, start date and end date of the item, if item is current available to bid,
        //show bid button, otherwise only show question button.
        foreach (DataListItem listItem in dtlItem.Items)
        {
            //get strat date of the item
            Label lblStartDate = (Label)listItem.FindControl("lblStrartDateOfTheBid");
            DateTime startBidDate = Convert.ToDateTime(lblStartDate.Text);
            //get duration  of the item
            Label lblDuration = (Label)listItem.FindControl("lblDuration");
            int duration = Convert.ToInt32(lblDuration.Text);
            //end date of the item
            DateTime endBidDate = startBidDate.AddDays(duration);
            //item is not available
            if (endBidDate < DateTime.Now || startBidDate > DateTime.Now)
            {
                LinkButton bidButton = (LinkButton)listItem.FindControl("lnkBtnBid");
                bidButton.Visible = false;
            }
        }
    }

    //bid button, click button to bid item
    protected void LinkButton1_Click(object sender, EventArgs e)
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

    //question button
    protected void LinkButton2_Click(object sender, EventArgs e)
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
}