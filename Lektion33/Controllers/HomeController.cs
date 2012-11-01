using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion33.Models;
using System.Text;
using System.Net;
using System.IO;

namespace Lektion33.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string Message = "")
        {
            if (!string.IsNullOrEmpty(Message))
                ViewBag.Message = Message;
            else
                ViewBag.Message = "Welcome to ASP.NET MVC!";

            var model = new CheckoutModel { item = "TestProduct", amount = 7.99 };
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ViewResult PostToPaypal(string item, double amount)
        {
            Paypal paypalModel = new Paypal();
            bool UseSandbox = true;

            if (UseSandbox)
                paypalModel.baseURL = "https://api-3t.sandbox.paypal.com/nvp";
            else
                paypalModel.baseURL = "https://www.paypal.com/cgi-bin/webscr";

            paypalModel.USER = "awt2.s_1351761616_biz_api1.gmail.com";
            paypalModel.PWD = "1351761636";
            paypalModel.SIGNATURE = "AU-jRNpB0FT4OkwJwOgVyc-GO3hWACA6p4donLO46ju7ujhoOLJEhKIj";
            paypalModel.METHOD = "SetExpressCheckout";
            paypalModel.VERSION = "89";
            paypalModel.cancelURL = "http://localhost:54947/Home/About";
            paypalModel.returnURL = "http://localhost:54947/Home/Index?Message=Successfully_Bought_TestProduct";
            paypalModel.PAYMENTREQUEST_0_CURRENCYCODE = "USD";
            paypalModel.PAYMENTREQUEST_0_PAYMENTACTION = "SALE";
            paypalModel.PAYMENTREQUEST_0_AMT = string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:0.00}", amount);
            paypalModel.PAYMENTREQUEST_0_ITEMAMT = string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:0.00}", amount);
            paypalModel.L_PAYMENTREQUEST_0_ITEMCATEGORY0 = "Digital";
            paypalModel.L_PAYMENTREQUEST_0_NAME0 = item;
            paypalModel.L_PAYMENTREQUEST_0_QTY0 = "1";
            paypalModel.L_PAYMENTREQUEST_0_AMT0 = string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:0.00}", amount); //"YOU ARE SENDING PLAIN TEXT USERNAME AND PASSWORD ETC - see: https://www.x.com/developers/paypal/documentation-tools/how-to-guides/how-accept-basic-digital-goods-payment-using-express-checkout";

            return View(paypalModel);
        }
    }
}
