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
/// Summary description for BiddingHistoryDB
/// </summary>
public class BiddingHistoryDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get bidding history with member Id
    public static List<BiddingHistory> getMemberBiddingHistory(string memberId)
    {
        try
        {
            List<BiddingHistory> listBiddingHistory = new List<BiddingHistory>();
            SqlCommand cmd = new SqlCommand("select * from ItemMemberInt B, Item I where memberId=@memberId and B.itemId=I.itemId ", connection);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            BiddingHistory biddingHistory;
            while (dr.Read())
            {
                //create a new bidding at a time
                biddingHistory = new BiddingHistory();
                biddingHistory.Description = dr["description"].ToString();
                biddingHistory.ImageFileName = "~/Images/items/"+dr["imageFileName"];
                biddingHistory.BidPrice = Convert.ToInt32(dr["bidPrice"]);
                biddingHistory.BidDate = Convert.ToDateTime(dr["bidDate"]);
                listBiddingHistory.Add(biddingHistory);
            }
            dr.Close();
            return listBiddingHistory;
        }
        finally
        {
            connection.Close();
        }
    }
}