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
/// Summary description for BiddingDB
/// </summary>
public class BiddingDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get current bidding price with item Id
    public static Bidding getCurrentPrice(string itemId)
    {
        try
        {
            Bidding bidding;
            bidding = new Bidding();
            SqlCommand cmd = new SqlCommand("select top 1 * from ItemMemberInt where itemId=@itemId order by bidPrice desc", connection);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            //first people to bid
            if (dr.HasRows)
            {
                dr.Read();
                bidding.BidId = dr["bidId"].ToString();
                bidding.BidPrice = Convert.ToInt32(dr["bidPrice"]);
                bidding.BidDate = Convert.ToDateTime(dr["bidDate"]);
                //bidding.BidTime = Convert.ToDateTime(dr["bidTime"]);
                bidding.MemberId = dr["memberId"].ToString();
                dr.Close();
            }
            else
            {
                dr.Close();
                SqlCommand command = new SqlCommand("select * from Item where itemId=@itemId", connection);
                command.Parameters.AddWithValue("@itemId", itemId);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                bidding.BidPrice = Convert.ToInt32(dataReader["minBidPrice"]);
                bidding.MemberId = "";
                dataReader.Close();
            }
            
                      
            
            return bidding;
        }
        finally
        {
            connection.Close();
        }
    }

    //get bidding history with member Id
    public static List<Bidding> getMemberBiddingHistory(string memberId)
    {
        try
        {
            List<Bidding> listBidding = new List<Bidding>();
            SqlCommand cmd = new SqlCommand("select * from ItemMemberInt where memberId=@memberId", connection);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Bidding bidding;
            while (dr.Read())
            {
                //create a new bidding at a time
                bidding = new Bidding();
                bidding.BidId = dr["bidId"].ToString();
                bidding.BidPrice = Convert.ToInt32(dr["bidPrice"]);
                bidding.BidDate = Convert.ToDateTime(dr["bidDate"]);
                //bidding.BidTime = Convert.ToDateTime(dr["bidTime"]);
                bidding.ItemId = dr["itemId"].ToString();
                listBidding.Add(bidding);
            }
            dr.Close();
            return listBidding;
        }
        finally
        {
            connection.Close();
        }
    }

    //get highest price with item Id
    public static Bidding getHighestPrice(string itemId)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("select * from ItemMemberInt where itemId=@itemId and highest='yes'", connection);
            cmd.Parameters.AddWithValue("@itemId", itemId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Bidding bidding;
            dr.Read();
            //create a new bidding at a time
            bidding = new Bidding();
            bidding.BidId = dr["bidId"].ToString();
            bidding.BidPrice = Convert.ToInt32(dr["bidPrice"]);
            bidding.BidDate = Convert.ToDateTime(dr["bidDate"]);
            //bidding.BidTime = Convert.ToDateTime(dr["bidTime"]);
            bidding.MemberId = dr["memberId"].ToString();
            dr.Close();
            return bidding;
        }
        finally
        {
            connection.Close();
        }
    }

    //insert bidding
    public static int insertBidding (Bidding newBidding)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("insert into ItemMemberInt (bidPrice, bidDate, bidTime, itemId, memberId) values (@bidPrice, @bidDate, @bidTime, @itemId, @memberId)", connection);

            cmd.Parameters.AddWithValue("@bidPrice", newBidding.BidPrice);
            cmd.Parameters.AddWithValue("@bidDate", newBidding.BidDate);
            cmd.Parameters.AddWithValue("@bidTime", newBidding.BidTime);
            cmd.Parameters.AddWithValue("@itemId", newBidding.ItemId);
            cmd.Parameters.AddWithValue("@memberId", newBidding.MemberId);

            connection.Open();

            return cmd.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
        }
    }
}