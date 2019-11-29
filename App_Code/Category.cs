using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Category
/// </summary>
public class Category
{
    private string categoryId;
    private string shortName;
    private string description;

    public Category() { }

    public Category(string categoryId, string shortName, string description)
    {
        this.categoryId = categoryId;
        this.shortName = shortName;
        this.description = description;
    }

    public string CategoryId { get { return categoryId; } set { categoryId = value; } }
    public string ShortName { get { return shortName; } set { shortName = value; } }
    public string Description { get { return description; } set { description = value; } }
}