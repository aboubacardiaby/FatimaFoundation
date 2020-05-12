using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FatimaFoundation.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            var apiContext = GetApiContext();

            var sales = Payment.List(apiContext);

            return View(sales);
        }

        public ActionResult Refund(string saleId)
        {
            var apiContext = GetApiContext();

            var sale = new Sale()
            {
                id = saleId
            };

            // A refund with no details refunds the entire amount.
            var refund = sale.Refund(apiContext, new Refund());

            return RedirectToAction("Index");
        }

        private APIContext GetApiContext()
        {
            // Authenticate with PayPal
            var config = ConfigManager.Instance.GetProperties();
            var accessToken = new OAuthTokenCredential(config).GetAccessToken();
            var apiContext = new APIContext(accessToken);
            return apiContext;
        }
    }
}