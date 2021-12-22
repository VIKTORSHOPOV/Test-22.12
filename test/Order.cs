using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Order
    {
        string orderNumber;
        string recieverName;
        string phone;
        string email;
        double priceProduct;
        int payMethod;
        double priceShipping;

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public string RecieverName
        {
            get { return recieverName; }
            set { recieverName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double PriceProduct
        {
            get { return priceProduct; }
            set { if (value > 0) priceProduct = value; }
        }

        public int PayMethod
        {
            get { return payMethod; }
            set { payMethod = value; }
        }

        public double PriceShipping
        {
            get { return priceShipping; }
            set { if (value > 0) priceShipping = value; }
        }

        public Order()
        {
            OrderNumber = string.Empty;
            RecieverName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            PriceProduct = 0;
            PayMethod = 0;
            PriceShipping = 0;
        }

        public Order(string aOrderNumber, string aRecieverName, string aPhone, string aEmail, double apriceProduct, int aPayMethod, double aPriceShipping)
        {
            OrderNumber = aOrderNumber;
            RecieverName = aRecieverName;
            Phone = aPhone;
            Email = aEmail;
            PriceProduct = apriceProduct;
            PayMethod = aPayMethod;
            PriceShipping = aPriceShipping;
        }

        public double FinalPrice()
        {
            return PriceShipping + PriceProduct;
        }

        public string ShowInfo()
        {
            string pay = "";
            switch (PayMethod)
            {
                case 1: pay = "Cash on Delivery"; break;
                case 2: pay = "Bank transfer"; break;
                default:
                    break;
            }

            return $"{recieverName} e-mail: {Email}/phone:" +
                $" {Phone} Price – {priceProduct}" +
                $"/Pay {pay} " +
                $"Price delivery – {PriceShipping} " +
                $"Total – {FinalPrice()}";
        }

    }
}
