using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Bidding
/// </summary>
public class Bidding
{
    private string bidId;
    private int bidPrice;
    private DateTime bidDate;
    private DateTime bidTime;
    private string highest;
    private string memberId;
    private string itemId;

    public Bidding() { }

    public Bidding(string bidId, int bidPrice, DateTime bidDate, DateTime bidTime, string highest, string memberId, string itemId)
    {
        this.bidId = bidId;
        this.bidPrice = bidPrice;
        this.bidDate = bidDate;
        this.bidTime = bidTime;
        this.highest = highest;
        this.memberId = memberId;
        this.itemId = itemId;

    }

    public string BidId { get { return bidId; } set { bidId = value; } }
    public int BidPrice { get { return bidPrice; } set { bidPrice = value; } }
    public DateTime BidDate { get { return bidDate; } set { bidDate = value; } }
    public DateTime BidTime { get { return bidTime; } set { bidTime = value; } }
    public string Highest { get { return highest; } set { highest = value; } }
    public string MemberId { get { return memberId; } set { memberId = value; } }
    public string ItemId { get { return itemId; } set { itemId = value; } }

}