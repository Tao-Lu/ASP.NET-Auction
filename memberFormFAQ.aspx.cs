using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberFormFAQ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get member id, and show member's Faq
        string memberId = Session["memberId"].ToString();
        List<FAQ> listFaq = new List<FAQ>();
        listFaq = FAQDB.getFAQByMemberId(memberId);
        gvFaq.DataSource = listFaq;
        gvFaq.DataBind();
    }
}