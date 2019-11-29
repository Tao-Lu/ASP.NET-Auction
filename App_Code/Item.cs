using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Item
/// </summary>
public class Item
{
    private string itemId;
    private string description;
    private string conditionOfTheItem;
    private string imageFileName;
    private int minBidPrice;
    private DateTime startDateOfTheBid;
    private int duration;
    private DateTime dueDateToPay;
    private string donorId;
    private string categoryId;
    private string invoiceId;

    public Item() { }

    public Item(string itemId, string description, string conditionOfTheItem, string imageFileName, int minBidPrice, DateTime startDateOfTheBid, int duration, DateTime dueDateToPay, string donorId, string categoryId, string invoiceId)
    {
        this.itemId = itemId;
        this.description = description;
        this.conditionOfTheItem = conditionOfTheItem;
        this.imageFileName = imageFileName;
        this.minBidPrice = minBidPrice;
        this.startDateOfTheBid = startDateOfTheBid;
        this.duration = duration;
        this.dueDateToPay = dueDateToPay;
        this.donorId = donorId;
        this.categoryId = categoryId;
        this.invoiceId = invoiceId;
    }

    public string ItemId { get { return itemId; } set { itemId = value; } }
    public string Description { get { return description; } set { description = value; } }
    public string ConditionOfTheItem { get { return conditionOfTheItem; } set { conditionOfTheItem = value; } }
    public string ImageFileName { get { return imageFileName; } set { imageFileName = value; } }
    public int MinBidPrice { get { return minBidPrice; } set { minBidPrice = value; } }
    public DateTime StartDateOfTheBid { get { return startDateOfTheBid; } set { startDateOfTheBid = value; } }
    public int Duration { get { return duration; } set { duration = value; } }
    public DateTime DueDateToPay { get { return dueDateToPay; } set { dueDateToPay = value; } }
    public string DonorId { get { return donorId; } set { donorId = value; } }
    public string CategoryId { get { return categoryId; } set { categoryId = value; } }
    public string InvoiceId { get { return invoiceId; } set { invoiceId = value; } }
}