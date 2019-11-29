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
/// Summary description for FAQDB
/// </summary>
public class FAQDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get FAQ by item Id
    public static List<FAQ> getFAQByItemId (string itemId)
    {
        try
        {
            List<FAQ> listFaq = new List<FAQ>();
            SqlCommand cmd = new SqlCommand("select * from FAQ where itemId=@itemId", connection);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            FAQ faq;
            while (dr.Read())
            {
                //create a new faq at a time
                faq = new FAQ();
                faq.FaqId = dr["FAQId"].ToString();
                faq.Question = dr["question"].ToString();
                faq.Date = Convert.ToDateTime(dr["date"]);
                faq.Reply = dr["reply"].ToString();
                faq.ItemId = dr["itemId"].ToString();
                faq.MemberId = dr["memberId"].ToString();
                listFaq.Add(faq);
            }
            dr.Close();
            return listFaq;
        }
        finally
        {
            connection.Close();
        }
    }

    //get FAQ by member Id
    public static List<FAQ> getFAQByMemberId(string MemberId)
    {
        try
        {
            List<FAQ> listFaq = new List<FAQ>();
            SqlCommand cmd = new SqlCommand("select * from FAQ where memberId=@memberId", connection);
            cmd.Parameters.AddWithValue("@memberId", MemberId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            FAQ faq;
            while (dr.Read())
            {
                //create a new faq at a time
                faq = new FAQ();
                faq.FaqId = dr["FAQId"].ToString();
                faq.Question = dr["question"].ToString();
                faq.Date = Convert.ToDateTime(dr["date"]);
                faq.Reply = dr["reply"].ToString();
                faq.MemberId = dr["memberId"].ToString();
                listFaq.Add(faq);
            }
            dr.Close();
            return listFaq;
        }
        finally
        {
            connection.Close();
        }
    }

    //insert new Faq
    public static int insertNewFAQ (string quesiton, DateTime date, string memberId, string itemId)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("insert into FAQ (question, date, memberId, itemId) values (@question, cast(@date as date), @memberId, @itemId)", connection);

            cmd.Parameters.AddWithValue("@question", quesiton);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            connection.Open();

            return cmd.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
        }
    }

}