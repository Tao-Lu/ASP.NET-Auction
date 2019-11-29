using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Donor
/// </summary>
public class Donor
{
    private string donorId;
    private string name;
    private DateTime dob;
    private string address;
    private string email;

    public Donor(string donorId, string name, DateTime dob, string address, string email)
    {
        this.donorId = donorId;
        this.name = name;
        this.dob = dob;
        this.address = address;
        this.email = email;
    }

    public string DonorId { get { return donorId; } set { donorId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public DateTime Dob { get { return dob; } set { dob = value; } }
    public string Address { get { return address; } set { address = value; } }
    public string Email { get { return email; } set { email = value; } }
}