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
/// Summary description for MemberDB
/// </summary>
public class MemberDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //add new member(bidder)
    public static int insertMember(Member member)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("insert into Member values (@name, @gender, @dob, @address, @email, @password, @phone, @type, @status)", connection);

            cmd.Parameters.AddWithValue("@name", member.Name);
            cmd.Parameters.AddWithValue("@gender", member.Gender);
            cmd.Parameters.AddWithValue("@dob", member.Dob);
            cmd.Parameters.AddWithValue("@address", member.Address);
            cmd.Parameters.AddWithValue("@email", member.Email);
            cmd.Parameters.AddWithValue("@password", member.Password);
            cmd.Parameters.AddWithValue("@phone", member.Phone);
            cmd.Parameters.AddWithValue("@type", member.Type);
            cmd.Parameters.AddWithValue("@status", member.Status);

            connection.Open();

            return cmd.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
        }
    }

    //get all members(bidders)
    public static List<Member> getAllMember()
    {
        try
        {
            List<Member> listMember = new List<Member>();
            SqlCommand cmd = new SqlCommand("select * from Member", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Member member;
            while (dr.Read())
            {
                //create a new member at a time
                member = new Member();
                member.MemberId = dr["memberId"].ToString();
                member.Name = dr["name"].ToString();
                member.Gender = dr["gender"].ToString();
                member.Dob = Convert.ToDateTime(dr["dob"]);
                member.Address = dr["address"].ToString();
                member.Email = dr["email"].ToString();
                member.Password = dr["password"].ToString();
                member.Phone = Convert.ToInt32(dr["phone"]);
                member.Type = dr["type"].ToString();
                member.Status = dr["status"].ToString();
                listMember.Add(member);
            }
            dr.Close();
            return listMember;
        }
        finally
        {
            connection.Close();
        }
    }

    //get members by member Id
    public static Member getMemberById(string memberId)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("select * from Member where memberId=@memberId", connection);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Member member;
            dr.Read();
            //create a new member at a time
            member = new Member();
            member.MemberId = dr["memberId"].ToString();
            member.Name = dr["name"].ToString();
            member.Gender = dr["gender"].ToString();
            member.Dob = Convert.ToDateTime(dr["dob"]);
            member.Address = dr["address"].ToString();
            member.Email = dr["email"].ToString();
            member.Password = dr["password"].ToString();
            member.Phone = Convert.ToInt32(dr["phone"]);
            member.Type = dr["type"].ToString();
            member.Status = dr["status"].ToString();
            dr.Close();
            return member;
        }
        finally
        {
            connection.Close();
        }
    }

    //update member details
    public static int updateMemberDetail(string name, string address, string password, int phone, string email)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("update Member set name=@name, address=@address,  password=@password, phone=@phone where email=@email", connection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@phone", phone);

            connection.Open();

            return cmd.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
        }
    }

    //checking the email ensures there is no duplicate one in database
    public static bool existEmail(string memberEmail)
    {
        List<Member> listMember = new List<Member>();
        listMember = getAllMember();
        bool exist = false;
        foreach (Member member in listMember)
        {
            //exist same email in the database
            if (string.Compare(member.Email, memberEmail) == 0)
            {
                exist = true;
                break;
            }
        }
        return exist;
    }
}