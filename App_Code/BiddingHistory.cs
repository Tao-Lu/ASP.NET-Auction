using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BiddingHistory
/// </summary>
public class BiddingHistory
{
    private string description;
    private string imageFileName;
    private int bidPrice;
    private DateTime bidDate;
    private DateTime bidTime;


    public BiddingHistory() { }

    public BiddingHistory(string description, string imageFileName, int bidPrice, DateTime bidDate, DateTime bidTime)
    {
        this.description = description;
        this.imageFileName = imageFileName;
        this.bidPrice = bidPrice;
        this.bidDate = bidDate;
        this.bidTime = bidTime;

    }

    public string Description { get { return description; } set { description = value; } }
    public string ImageFileName { get { return imageFileName; } set { imageFileName = value; } }
    public int BidPrice { get { return bidPrice; } set { bidPrice = value; } }
    public DateTime BidDate { get { return bidDate; } set { bidDate = value; } }
    public DateTime BidTime { get { return bidTime; } set { bidTime = value; } }
}