using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FAQ
/// </summary>
public class FAQ
{
    private string faqId;
    private string question;
    private string reply;
    private DateTime date;
    private string itemId;
    private string memberId;

    public FAQ() { }

    public FAQ(string faqId, string question, string reply, DateTime date, string itemId, string memberId)
    {
        this.faqId = faqId;
        this.question = question;
        this.reply = reply;
        this.date = date;
        this.itemId = itemId;
        this.memberId = memberId;
    }

    public string FaqId { get { return faqId; } set { faqId = value; } }
    public string Question { get { return question; } set { question = value; } }
    public string Reply { get { return reply; } set { reply = value; } }
    public DateTime Date { get { return date; } set { date = value; } }
    public string ItemId { get { return itemId; } set { itemId = value; } }
    public string MemberId { get { return memberId; } set { memberId = value; } }
}