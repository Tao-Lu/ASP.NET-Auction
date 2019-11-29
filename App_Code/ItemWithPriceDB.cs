using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Xml;

/// <summary>
/// Summary description for ItemWithPriceDB
/// </summary>
public class ItemWithPriceDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get Item with price and member Id
    public static List<ItemWithPrice> getItemWithPrice(string memberId)
    {
        try
        {
            List<ItemWithPrice> listItemWithPrice = new List<ItemWithPrice>();
            SqlCommand cmd = new SqlCommand("select I.itemId, I.description, I.imageFileName, I.conditionOfTheItem, B.bidPrice, I.dueDateToPay from Item I, ItemMemberInt B where I.itemId=B.itemId and B.memberId=@memberId and B.highest='yes' and I.invoiceId is null", connection);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            ItemWithPrice itemWithPrice;
            while (dr.Read())
            {
                //create a new itemWithPrice at a time
                itemWithPrice = new ItemWithPrice();
                itemWithPrice.ItemId = dr["itemId"].ToString();
                itemWithPrice.Description = dr["description"].ToString();
                itemWithPrice.ImageFileName = dr["imageFileName"].ToString();
                itemWithPrice.ConditionOfTheItem = dr["conditionOfTheItem"].ToString();
                itemWithPrice.Price = Convert.ToDecimal(dr["bidPrice"]);
                itemWithPrice.DueDateToPay = Convert.ToDateTime(dr["dueDateToPay"]);
                listItemWithPrice.Add(itemWithPrice);
            }
            dr.Close();
            return listItemWithPrice;
        }
        finally
        {
            connection.Close();
        }
    }

    //get item with price by memberId and ItemId
    public static ItemWithPrice getItemWithPriceByMemberIdItemId(string memberId, string itemId)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("select I.itemId, I.description, I.imageFileName, I.conditionOfTheItem, B.bidPrice, I.dueDateToPay from Item I, ItemMemberInt B where I.itemId=B.itemId and B.memberId=@memberId and B.highest='yes' and I.invoiceId is null and I.itemId=@itemId", connection);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            ItemWithPrice itemWithPrice;
            dr.Read();
            //create a new itemWithPrice at a time
            itemWithPrice = new ItemWithPrice();
            itemWithPrice.ItemId = dr["itemId"].ToString();
            itemWithPrice.Description = dr["description"].ToString();
            itemWithPrice.ImageFileName = "~/Images/items/" + dr["imageFileName"];
            itemWithPrice.ConditionOfTheItem = dr["conditionOfTheItem"].ToString();
            itemWithPrice.Price = Convert.ToDecimal(dr["bidPrice"]);
            itemWithPrice.DueDateToPay = Convert.ToDateTime(dr["dueDateToPay"]);
            dr.Close();
            return itemWithPrice;
        }
        finally
        {
            connection.Close();
        }
    }
}