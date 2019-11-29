using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberUnpay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //get member id, and show the items member won, but has not paid
            string memberId = Session["memberId"].ToString();
            dtlItemWithHighPrice.DataSource = ItemWithPriceDB.getItemWithPrice(memberId);
            dtlItemWithHighPrice.DataBind();
        }   
    }
    //select items which member want to pay
    protected void btnMakeAPayment_Click(object sender, EventArgs e)
    {
        List<string> listItemId = new List<string>();
        List<decimal> listPrice = new List<decimal>();
        //check which items are selected by member
        foreach (DataListItem listItem in dtlItemWithHighPrice.Items)
        {
            CheckBox chxPay= (CheckBox)listItem.FindControl("chxPay");
            if(chxPay.Checked)
            {
                //get item id, and the  price of the item
                Label lblItemId= (Label)listItem.FindControl("lblItemId");
                string itemId = lblItemId.Text;
                listItemId.Add(itemId);
                Label lblPrice = (Label)listItem.FindControl("lblPrice");
                decimal price = Convert.ToDecimal(lblPrice.Text);
                listPrice.Add(price);   
            }
        }
        //if member does not select item to pay
        if(listItemId.Count()==0)
        {
            lblOutput.Text = "please select items";
            lblOutput.Visible = true;
        }
        else
        {
            Session["unpaySelectedItemId"] = listItemId;
            Session["unpaySelectedPrice"] = listPrice;
            Server.Transfer("PaymentForm.aspx");
        }
    }
}