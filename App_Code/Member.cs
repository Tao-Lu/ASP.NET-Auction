using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Member
/// </summary>

public class Member
{
    private string memberId;
    private string name;
    private string gender;
    private DateTime dob;
    private string address;
    private string email;
    private string password;
    private int phone;
    private string type;
    private string status;

    public Member() { }

    public Member(string memberId, string name, string gender, DateTime dob, string address, string email, string password, int phone, string type, string status)
    {
        this.memberId = memberId;
        this.name = name;
        this.gender = gender;
        this.dob = dob;
        this.address = address;
        this.email = email;
        this.password = password;
        this.phone = phone;
        this.type = type;
        this.status = status;
    }

    public string MemberId { get { return memberId; } set { memberId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Gender { get { return gender; } set { gender = value; } }
    public DateTime Dob { get { return dob; } set { dob = value; } }
    public string Address { get { return address; } set { address = value; } }
    public string Email { get { return email; } set { email = value; } }
    public string Password { get { return password; } set { password = value; } }
    public int Phone { get { return phone; } set { phone = value; } }
    public string Type { get { return type; } set { type = value; } }
    public string Status { get { return status; } set { status = value; } }
}