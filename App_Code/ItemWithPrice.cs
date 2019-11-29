using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ItemWithPrice
/// </summary>
public class ItemWithPrice
{
    private string itemId;
    private string description;
    private string conditionOfTheItem;
    private string imageFileName;
    private DateTime dueDateToPay;
    private decimal price;

    public ItemWithPrice() { }

    public ItemWithPrice(string itemId, string description, string conditionOfTheItem, string imageFileName, DateTime dueDateToPay, decimal price)
    {
        this.itemId = itemId;
        this.description = description;
        this.conditionOfTheItem = conditionOfTheItem;
        this.imageFileName = imageFileName;
        this.dueDateToPay = dueDateToPay;
        this.price = price;
    }

    public string ItemId { get { return itemId; } set { itemId = value; } }
    public string Description { get { return description; } set { description = value; } }
    public string ConditionOfTheItem { get { return conditionOfTheItem; } set { conditionOfTheItem = value; } }
    public string ImageFileName { get { return imageFileName; } set { imageFileName = value; } }
    public DateTime DueDateToPay { get { return dueDateToPay; } set { dueDateToPay = value; } }
    public decimal Price { get { return price; } set { price = value; } }
}