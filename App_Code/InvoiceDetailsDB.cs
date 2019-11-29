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
/// Summary description for InvoiceDetailsDB
/// </summary>
public class InvoiceDetailsDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get invoice details by invoiceId, memberId
    public static List<InvoiceDetails> getInvoiceDetails(string invoiceId, string memberId)
    {
        try
        {
            List<InvoiceDetails> listInvoiceDetails = new List<InvoiceDetails>();
            SqlCommand cmd = new SqlCommand("select distinct I.itemId, I.imageFileName, I.description, I.conditionOfTheItem, B.bidPrice from Invoice P, ItemMemberInt B, Item I where P.memberId=B.memberId and B.itemId=I.itemId and I.invoiceId=@invoiceId and B.highest='yes' and P.memberId=@memberId", connection);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            cmd.Parameters.AddWithValue("@invoiceId", invoiceId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            InvoiceDetails invoiceDetails;
            while (dr.Read())
            {
                //create a new item at a time
                invoiceDetails = new InvoiceDetails();
                invoiceDetails.ItemId = dr["itemId"].ToString();
                invoiceDetails.ImageFileName = "~/Images/items/" + dr["imageFileName"];
                invoiceDetails.Description = dr["description"].ToString();
                invoiceDetails.ConditionOfTheItem = dr["conditionOfTheItem"].ToString();
                invoiceDetails.Price = Convert.ToDecimal(dr["bidPrice"]);
                listInvoiceDetails.Add(invoiceDetails);
            }
            dr.Close();
            return listInvoiceDetails;
        }
        finally
        {
            connection.Close();
        }
    }
}