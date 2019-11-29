using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InvoiceDetails
/// </summary>
public class InvoiceDetails
{
    private string itemId;
    private string description;
    private string conditionOfTheItem;
    private string imageFileName;
    private decimal price;

    public InvoiceDetails() { }

    public InvoiceDetails(string itemId, string description, string conditionOfTheItem, string imageFileName, decimal price)
    {
        this.itemId = itemId;
        this.description = description;
        this.conditionOfTheItem = conditionOfTheItem;
        this.imageFileName = imageFileName;
        this.price = price;
    }

    public string ItemId { get { return itemId; } set { itemId = value; } }
    public string Description { get { return description; } set { description = value; } }
    public string ConditionOfTheItem { get { return conditionOfTheItem; } set { conditionOfTheItem = value; } }
    public string ImageFileName { get { return imageFileName; } set { imageFileName = value; } }
    public  decimal Price { get { return price; } set { price = value; } }

}