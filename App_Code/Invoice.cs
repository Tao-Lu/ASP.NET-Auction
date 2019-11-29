using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Invoice
/// </summary>
public class Invoice
{
    private string invoiceId;
    private DateTime invoiceDate;
    private decimal subtotalPrice;
    private string shipment;
    private decimal  totalPrice;
    private string creditCardType;
    private int creditCardNumber;
    private int cvv2Number;
    private DateTime expiryDate;
    private string memberId;

    public Invoice() {  }

    public Invoice(string invoiceId, DateTime invoiceDate, decimal subtotalPrice, string shipment, decimal totalPrice, string creditCardType, int creditCardNumber, int cvv2Number, DateTime expiryDate, string memberId)
    {
        this.invoiceId = invoiceId;
        this.invoiceDate = invoiceDate;
        this.subtotalPrice = subtotalPrice;
        this.shipment = shipment;
        this.totalPrice = totalPrice;
        this.creditCardType = creditCardType;
        this.creditCardNumber = creditCardNumber;
        this.cvv2Number = cvv2Number;
        this.expiryDate = expiryDate;
        this.memberId = memberId;
    }

    public string InvoiceId { get { return invoiceId; } set { invoiceId = value; } }
    public DateTime InvoiceDate { get { return invoiceDate; } set { invoiceDate = value; } }
    public decimal SubtotalPrice { get { return subtotalPrice; } set { subtotalPrice = value; } }
    public string Shipment { get { return shipment; } set { shipment = value; } }
    public decimal TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
    public string CreditCardType { get { return creditCardType; } set { creditCardType = value; } }
    public int CreditCardNumber { get { return creditCardNumber; } set { creditCardNumber = value; } }
    public int CVV2Number { get { return cvv2Number; } set { cvv2Number = value; } }
    public DateTime ExpiryDate { get { return expiryDate; } set { expiryDate = value; } }
    public string MemberId { get { return memberId; } set { memberId = value; } }
}