using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion33.Models
{
    public class Paypal
    {
        public string USER { get; set; }
//        &PWD=merchant_password
        public string PWD { get; set; }
//&SIGNATURE=merchant_signature
        public string SIGNATURE { get; set; }
//&METHOD=SetExpressCheckout
        public string METHOD { get; set; }
        //&VERSION=89
        public string VERSION { get; set; }
        //&cancelUrl=http://www.yourdomain.com/cancel.html #For use if the consumer decides not to proceed with payment
        public string cancelURL { get; set; }
        //&returnUrl=http://www.yourdomain.com/success.html #For use if the consumer proceeds with payment
        public string returnURL { get; set; }
//&PAYMENTREQUEST_0_CURRENCYCODE=USD #The currency, e.g. US dollars
        public string PAYMENTREQUEST_0_CURRENCYCODE { get; set; }
//&PAYMENTREQUEST_0_PAYMENTACTION=SALE #Payment for a sale
        public string PAYMENTREQUEST_0_PAYMENTACTION { get; set; }
//&PAYMENTREQUEST_0_AMT=21 #The amount authorized
        public string PAYMENTREQUEST_0_AMT { get; set; }
//&PAYMENTREQUEST_0_ITEMAMT=21
        public string PAYMENTREQUEST_0_ITEMAMT { get; set; }
//&L_PAYMENTREQUEST_0_ITEMCATEGORY0=Digital #The item category must be set to Digital
        public string L_PAYMENTREQUEST_0_ITEMCATEGORY0 { get; set; }
//&L_PAYMENTREQUEST_0_NAME0=my_movie
        public string L_PAYMENTREQUEST_0_NAME0 { get; set; }
//&L_PAYMENTREQUEST_0_QTY0=1
        public string L_PAYMENTREQUEST_0_QTY0 { get; set; }
//&L_PAYMENTREQUEST_0_AMT0=21
        public string L_PAYMENTREQUEST_0_AMT0 { get; set; }

        public string baseURL { get; set; }

        public string parameters
        {
            get
            {
                string _actionURL = string.Format("{0}={1}", "USER", USER);
                _actionURL += string.Format("&{0}={1}", "PWD", PWD);
                _actionURL += string.Format("&{0}={1}", "SIGNATURE", SIGNATURE);
                _actionURL += string.Format("&{0}={1}", "METHOD", METHOD);
                _actionURL += string.Format("&{0}={1}", "VERSION", VERSION);
                _actionURL += string.Format("&{0}={1}", "cancelURL", cancelURL);
                _actionURL += string.Format("&{0}={1}", "returnURL", returnURL);
                _actionURL += string.Format("&{0}={1}", "PAYMENTREQUEST_0_CURRENCYCODE", PAYMENTREQUEST_0_CURRENCYCODE);
                _actionURL += string.Format("&{0}={1}", "PAYMENTREQUEST_0_PAYMENTACTION", PAYMENTREQUEST_0_PAYMENTACTION);
                _actionURL += string.Format("&{0}={1}", "PAYMENTREQUEST_0_AMT", PAYMENTREQUEST_0_AMT);
                _actionURL += string.Format("&{0}={1}", "PAYMENTREQUEST_0_ITEMAMT", PAYMENTREQUEST_0_ITEMAMT);
                _actionURL += string.Format("&{0}={1}", "L_PAYMENTREQUEST_0_ITEMCATEGORY0", L_PAYMENTREQUEST_0_ITEMCATEGORY0);
                _actionURL += string.Format("&{0}={1}", "L_PAYMENTREQUEST_0_NAME0", L_PAYMENTREQUEST_0_NAME0);
                _actionURL += string.Format("&{0}={1}", "L_PAYMENTREQUEST_0_QTY0", L_PAYMENTREQUEST_0_QTY0);
                _actionURL += string.Format("&{0}={1}", "L_PAYMENTREQUEST_0_AMT0", L_PAYMENTREQUEST_0_AMT0);

                return "";
            }
        }
    }
}