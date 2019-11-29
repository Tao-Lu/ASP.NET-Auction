using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberFormPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get member id, and show the invoice member has paid
        string memberId = Session["memberId"].ToString();
        List<Invoice> listInvoice = new List<Invoice>();
        listInvoice = InvoiceDB.getInvoiceByMemberId(memberId);
        gvPayment.DataSource = listInvoice;
        gvPayment.DataBind();
    }
    //which invoice is selected by member to check details of the invoice
    protected void invoiceSelected(object sender, GridViewCommandEventArgs e)
    {
        //which row is selected
        int rowSelected = Convert.ToInt32(e.CommandArgument);
        if (e.CommandName == "getInvoiceId")
        {
            //get invoice id and member id
            string invoiceId = gvPayment.Rows[rowSelected].Cells[0].Text;
            string memberId = Session["memberId"].ToString();
            //show the details of the invoice
            gvPaymentDetails.DataSource =  InvoiceDetailsDB.getInvoiceDetails(invoiceId, memberId);
            gvPaymentDetails.DataBind();
        }
    }
}