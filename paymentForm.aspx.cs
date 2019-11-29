using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class paymentForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblCardExpire.Visible = false;

        if (!IsPostBack)
        {
            //get member id
            string memberId = Session["memberId"].ToString();
            //get item id
            List<string> listItemId = new List<string>();
            listItemId = (List<string>)Session["unpaySelectedItemId"];
            //get item price
            List<decimal> listPrice = new List<decimal>();
            listPrice = (List<decimal>)Session["unpaySelectedPrice"];
            //show details of items which are selected by member to pay
            List<ItemWithPrice> listItemWithPrice = new List<ItemWithPrice>();
            foreach (string itemId in listItemId)
            {
                ItemWithPrice itemWithPrice = new ItemWithPrice();
                itemWithPrice = ItemWithPriceDB.getItemWithPriceByMemberIdItemId(memberId, itemId);
                listItemWithPrice.Add(itemWithPrice);
            }
            gvInvoice.DataSource = listItemWithPrice;
            gvInvoice.DataBind();
            //get the invoice id
            List<Invoice> listInvoice = new List<Invoice>();
            listInvoice = InvoiceDB.getAllInvoice();
            int autoNo = listInvoice.Count + 1;
            string invoiceId = "";
            if (1 <= autoNo && autoNo < 10)
                invoiceId = "invo000" + autoNo;
            else
            {
                if (10 <= autoNo && autoNo < 100)
                    invoiceId = "invo00" + autoNo;
                else
                {
                    if (100 <= autoNo && autoNo < 1000)
                        invoiceId = "invo0" + autoNo;
                    else
                    {
                        if (1000 <= autoNo && autoNo < 10000)
                            invoiceId = "invo" + autoNo;
                    }
                }
            }
            lblInvoiceId.Text = invoiceId.ToString();
            //invoice date (current date)
            lblInvoiceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //calculate subtotal price
            decimal subtotalPrice = 0;
            foreach (decimal price in listPrice)
            {
                subtotalPrice += price;
            }
            lblSubtotalPrice.Text = subtotalPrice.ToString("#0.00");
            //total price, if delivery is selected, $10 more
            decimal subtotal = Convert.ToDecimal(lblSubtotalPrice.Text);
            if (radioBtnListShipment.SelectedIndex == 0)
                lblTotalPrice.Text = (subtotal + 10).ToString("#0.00");
            else
                lblTotalPrice.Text = subtotal.ToString("#0.00");
        }
    }

    //shipment, if delivering the item, $10 more
    protected void radioBtnListShipment_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (radioBtnListShipment.SelectedIndex == 0)
        {
            lblTotalPrice.Text = (Convert.ToDecimal(lblSubtotalPrice.Text) + 10).ToString();
        }
        else
        {
            lblTotalPrice.Text = lblSubtotalPrice.Text;
        }
    }

    //make a payment
    protected void btnPay_Click(object sender, EventArgs e)
    {
        DateTime expiry = Convert.ToDateTime(tbxExpiryDate.Text);
        //check credit card is valid or not (expired)
        if (expiry>DateTime.Now)
        {
            //get the information of invoice, then insert new invoice into database
            DateTime invoiceDate = Convert.ToDateTime(lblInvoiceDate.Text);
            invoiceDate.ToString("dd-MM-yyyy");
            decimal subtotalPrice = Convert.ToDecimal(lblSubtotalPrice.Text);
            string shipment = radioBtnListShipment.Text;
            decimal totalPrice = Convert.ToDecimal(lblTotalPrice.Text);
            string creditCardType = radioBtnListCreditCardType.Text;
            int creditCardNumber = Convert.ToInt32(tbxCreditCardNumber.Text);
            int cvv2Number = Convert.ToInt32(tbxCVV2Number.Text);
            DateTime expiryDate = Convert.ToDateTime(tbxExpiryDate.Text);
            expiryDate.ToString("dd-MM-yyyy");
            string memberId = Session["memberId"].ToString();

            string invoiceId = lblInvoiceId.Text;
            List<string> listItemId = new List<string>();
            listItemId = (List<string>)Session["unpaySelectedItemId"];
            //insert new invoice into datebase, and update item details (invoice id (FK))
            int invoice = InvoiceDB.insertNewInvoice(invoiceDate, subtotalPrice, shipment, totalPrice, creditCardType, creditCardNumber, cvv2Number, expiryDate, memberId);
            int item = ItemDB.updateItemInvoiceId(listItemId, invoiceId);
            //insert and update successfully
            if (invoice > 0 && item > 0)
            {
                lblOutput.Text = "successful";
            }
            else
            {
                lblOutput.Text = "failed";
            }
        }
        else
        {
            //credit card is expire
            lblCardExpire.Text = "the card is expired";
            lblCardExpire.Visible = true;
        }
    }
}