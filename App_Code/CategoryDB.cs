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
/// Summary description for CategoryDB
/// </summary>
public class CategoryDB
{
    //connect to database
    static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

    //get all categories
    public static List<Category> getAllCategory()
    {
        try
        {
            List<Category> listCategory = new List<Category>();
            SqlCommand cmd = new SqlCommand("select * from Category", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Category category;
            while (dr.Read())
            {
                //create a new item at a time
                category = new Category();
                category.CategoryId = dr["categoryId"].ToString();
                category.ShortName = dr["shortName"].ToString();
                category.Description = dr["description"].ToString();
                listCategory.Add(category);
            }
            dr.Close();
            return listCategory;
        }
        finally
        {
            connection.Close();
        }
    }
}