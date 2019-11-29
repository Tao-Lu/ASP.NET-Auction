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
/// Summary description for ItemDB
/// </summary>
public class ItemDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get all items
    public static List<Item> getAllItem()
    {
        try
        {
            List<Item> listItem = new List<Item>();
            SqlCommand cmd = new SqlCommand("select * from Item", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Item item;
            while (dr.Read())
            {
                //create a new item at a time
                item = new Item();
                item.ItemId = dr["itemId"].ToString();
                item.Description = dr["description"].ToString();
                item.ConditionOfTheItem = dr["conditionOfTheItem"].ToString();
                item.ImageFileName = dr["imageFileName"].ToString();
                item.MinBidPrice = Convert.ToInt32(dr["minBidPrice"]);
                item.StartDateOfTheBid = Convert.ToDateTime(dr["startDateOfTheBid"]);
                item.Duration = Convert.ToInt32(dr["duration"]);
                //item.DueDateToPay = Convert.ToDateTime(dr["dueDateToPay"]);
                item.DonorId = dr["donorId"].ToString();
                item.CategoryId = dr["categoryId"].ToString();
                item.InvoiceId = dr["invoiceId"].ToString();
                listItem.Add(item);
            }
            dr.Close();
            return listItem;
        }
        finally
        {
            connection.Close();
        }
    }

    //get items by category
    public static List<Item> getItemByCategory(string category)
    {
        try
        {
            List<Item> listItemByCategory = new List<Item>();
            SqlCommand cmd = new SqlCommand("select * from Item I, Category C where C.shortName=@category and I.categoryId=C.categoryId", connection);
            cmd.Parameters.AddWithValue("@category", category);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Item item;
            while (dr.Read())
            {
                //create a new item at a time
                item = new Item();
                item.ItemId = dr["itemId"].ToString();
                item.Description = dr["description"].ToString();
                item.ConditionOfTheItem = dr["conditionOfTheItem"].ToString();
                item.ImageFileName = dr["imageFileName"].ToString();
                item.MinBidPrice = Convert.ToInt32(dr["minBidPrice"]);
                item.StartDateOfTheBid = Convert.ToDateTime(dr["startDateOfTheBid"]);
                item.Duration = Convert.ToInt32(dr["duration"]);
                //item.DueDateToPay = Convert.ToDateTime(dr["dueDateToPay"]);
                item.DonorId = dr["donorId"].ToString();
                item.CategoryId = dr["categoryId"].ToString();
                item.InvoiceId = dr["invoiceId"].ToString();
                listItemByCategory.Add(item);
            }
            dr.Close();
            return listItemByCategory;
        }
        finally
        {
            connection.Close();
        }
    }

    //get items by item id
    public static Item getItemByItemId(string itemId)
    {
        try
        {
            Item item = new Item();
            SqlCommand cmd = new SqlCommand("select * from Item where itemId=@itemId", connection);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            item.ItemId = dr["itemId"].ToString();
            item.Description = dr["description"].ToString();
            item.ConditionOfTheItem = dr["conditionOfTheItem"].ToString();
            item.ImageFileName = "~/Images/items/" + dr["imageFileName"];
            item.MinBidPrice = Convert.ToInt32(dr["minBidPrice"]);
            item.StartDateOfTheBid = Convert.ToDateTime(dr["startDateOfTheBid"]);
            item.Duration = Convert.ToInt32(dr["duration"]);
            item.DonorId = dr["donorId"].ToString();
            item.CategoryId = dr["categoryId"].ToString();
            item.InvoiceId = dr["invoiceId"].ToString();
            return item;
        }
        finally
        {
            connection.Close();
        }
    }

    //get homepage items (up to 7 days-last week)
    public static List<Item> getLastWeekItem()
    {
        List<Item> allItem = new List<Item>();
        allItem = ItemDB.getAllItem();

        List<Item> currentAvailableItem = new List<Item>();

        foreach (Item item in allItem)
        {
            DateTime endDate = item.StartDateOfTheBid.AddDays(item.Duration);

            if (DateTime.Now.AddDays(-7) <= endDate && endDate < DateTime.Now)
            {
                currentAvailableItem.Add(item);
            }
        }

        return currentAvailableItem;
    }

    //get homwpage items (current available)
    public static List<Item> getCurrentAvailableItem()
    {
        List<Item> allItem = new List<Item>();
        allItem = ItemDB.getAllItem();

        List<Item> currentAvailableItem = new List<Item>();

        foreach (Item item in allItem)
        {
            DateTime endDate = item.StartDateOfTheBid.AddDays(item.Duration);

            if (item.StartDateOfTheBid <= DateTime.Now && DateTime.Now < endDate)
            {
                currentAvailableItem.Add(item);
            }
        }

        return currentAvailableItem;
    }

    //update iitem (invoiceId)
    public static int updateItemInvoiceId(List<string> listItemId, string invoiceId)
    {
        try
        {
            int noOfItem=0;
            foreach (string itemId in listItemId)
            {
                SqlCommand cmd = new SqlCommand("update Item set invoiceId=@invoiceId where itemId=@itemId", connection);

                cmd.Parameters.AddWithValue("@itemId", itemId);
                cmd.Parameters.AddWithValue("@invoiceId", invoiceId);

                connection.Open();

                noOfItem += cmd.ExecuteNonQuery();

                connection.Close();
            }

            return noOfItem;
        }
        finally
        {
            connection.Close();
        }
    }
}