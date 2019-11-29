using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class biddingForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get item id which item is selected
        string itemId = Session["itemId"].ToString();
        Item bidItem = new Item();
        //get the specific item
        bidItem = ItemDB.getItemByItemId(itemId);
        
        //show deteial of the item
        lblItemId.Text = bidItem.ItemId;
        Image1.ImageUrl =bidItem.ImageFileName;
        lblCondition.Text = bidItem.ConditionOfTheItem;
        lblDescription.Text = bidItem.Description;
        lblDuration.Text = bidItem.Duration + " days";
        lblMinBidPrice.Text = "$ " + bidItem.MinBidPrice;
        lblStartDate.Text = bidItem.StartDateOfTheBid.ToString("dd/MM/yyyy");
        //get current bidding price and member id
        Bidding bidCurrentPrice = new Bidding();
        bidCurrentPrice = BiddingDB.getCurrentPrice(bidItem.ItemId);
        lblCurrentPrice.Text = bidCurrentPrice.BidPrice.ToString();
        lblBiddingMember.Text = bidCurrentPrice.MemberId.ToString();
    }

    //click button to bid item
    protected void btnBid_Click(object sender, EventArgs e)
    {
        //check bid price
        //no bid price
        if (tbxBidPrice.Text=="")
        {
            lblCheckBidPrice.Text = "please enter your bid price";
            lblCheckBidPrice.Visible = true;
        }
        else
        {
            //bid price is lower than current bid price
            if (Convert.ToInt32(tbxBidPrice.Text)<=Convert.ToInt32(lblCurrentPrice.Text))
            {
                lblCheckBidPrice.Text = "your bid price should be higher than current bid price";
                lblCheckBidPrice.Visible = true;
            }
            else
            {
                //insert new bidding into ItemMemberInt
                Bidding newBidding = new Bidding();
                newBidding.BidPrice = Convert.ToInt32(tbxBidPrice.Text);
                newBidding.BidDate = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                newBidding.BidTime = Convert.ToDateTime(DateTime.Now.ToString("HH: mm:ss"));
                newBidding.ItemId = lblItemId.Text;
                string memberId = Session["memberId"].ToString();
                newBidding.MemberId = memberId;
                BiddingDB.insertBidding(newBidding);
                Server.Transfer("biddingForm.aspx");
            }
        }
    }
}