using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberFormBidding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get member id, and  show member's bidding history
        string memberId = Session["memberId"].ToString();
        List<BiddingHistory> biddingHistory = new List<BiddingHistory>();
        biddingHistory = BiddingHistoryDB.getMemberBiddingHistory(memberId);
        gvMemberBidding.DataSource = biddingHistory;
        gvMemberBidding.DataBind();
    }
}