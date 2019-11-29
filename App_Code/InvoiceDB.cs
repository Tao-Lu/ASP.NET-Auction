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
/// Summary description for InvoiceDB
/// </summary>
public class InvoiceDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get invoice by member Id
    public static List<Invoice> getInvoiceByMemberId (string memberId)
    {
        try
        {
            List<Invoice> listInvoice = new List<Invoice>();
            SqlCommand cmd = new SqlCommand("select * from Invoice where memberId=@memberId", connection);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Invoice invoice;
            while (dr.Read())
            {
                //create a new invoice at a time
                invoice = new Invoice();
                invoice.InvoiceId = dr["invoiceId"].ToString();
                invoice.InvoiceDate = Convert.ToDateTime(dr["invoiceDate"]);
                invoice.SubtotalPrice = Convert.ToDecimal(dr["subtotalPrice"]);
                invoice.Shipment = dr["shipment"].ToString();
                invoice.TotalPrice = Convert.ToDecimal(dr["totalPrice"]);
                invoice.CreditCardType = dr["creditCardType"].ToString();
                invoice.CreditCardNumber = Convert.ToInt32(dr["creditCardNumber"]);
                invoice.CVV2Number = Convert.ToInt32(dr["cvv2Number"]);
                invoice.ExpiryDate = Convert.ToDateTime(dr["expiryDate"]);
                invoice.MemberId = dr["memberId"].ToString();
                listInvoice.Add(invoice);
            }
            dr.Close();
            return listInvoice;
        }
        finally
        {
            connection.Close();
        }
    }

    //get all invoice
    public static List<Invoice> getAllInvoice()
    {
        try
        {
            List<Invoice> listInvoice = new List<Invoice>();
            SqlCommand cmd = new SqlCommand("select * from Invoice", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Invoice invoice;
            while (dr.Read())
            {
                //create a new invoice at a time
                invoice = new Invoice();
                invoice.InvoiceId = dr["invoiceId"].ToString();
                invoice.InvoiceDate = Convert.ToDateTime(dr["invoiceDate"]);
                invoice.SubtotalPrice = Convert.ToDecimal(dr["subtotalPrice"]);
                invoice.Shipment = dr["shipment"].ToString();
                invoice.TotalPrice = Convert.ToDecimal(dr["totalPrice"]);
                invoice.CreditCardType = dr["creditCardType"].ToString();
                invoice.CreditCardNumber = Convert.ToInt32(dr["creditCardNumber"]);
                invoice.CVV2Number = Convert.ToInt32(dr["cvv2Number"]);
                invoice.ExpiryDate = Convert.ToDateTime(dr["expiryDate"]);
                invoice.MemberId = dr["memberId"].ToString();
                listInvoice.Add(invoice);
            }
            dr.Close();
            return listInvoice;
        }
        finally
        {
            connection.Close();
        }
    }

    //insert into Invoice
    public static int insertNewInvoice(DateTime invoiceDate, decimal subtotalPrice, string shipment, decimal totalPrice, string creditCardType, int creditCardNumber, int cvv2Numebr, DateTime expiryDate, string memberId)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("insert into Invoice values (cast(@InvoiceDate as date), @subtotalPrice, @shipment, @totalPrice, @creditCardType, @creditCardNumber, @cvv2Number, cast(@expiryDate as date), @memberId)", connection);
            //select cast('2005-05-01' as date)
            cmd.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
            cmd.Parameters.AddWithValue("@subtotalPrice", subtotalPrice);
            cmd.Parameters.AddWithValue("@shipment", shipment);
            cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
            cmd.Parameters.AddWithValue("@creditCardType", creditCardType);
            cmd.Parameters.AddWithValue("@creditCardNumber", creditCardNumber);
            cmd.Parameters.AddWithValue("@cvv2Number", cvv2Numebr);
            cmd.Parameters.AddWithValue("@expiryDate", expiryDate);
            cmd.Parameters.AddWithValue("@memberId", memberId);

            connection.Open();

            return cmd.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
        }
    }
}