using System;
using System.Collections.Generic;
using System.IdentityModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SkrillAspnetMVC.Models;

namespace SkrillAspnetMVC.Controllers
{
    public class SkrillController : Controller
    {
        // GET: Skrill
        public ActionResult Status(SkrillStatus result)
        {
            //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(result);
        }

        public ActionResult Pay()
        {
            //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var model = new SkrillPayRequest();

            return View(model);
        }


        [HttpPost]
        public ActionResult Pay(SkrillPayRequest model)
        {
            string data = $"pay_to_email={model.pay_to_email}&" +
                          $"return_url={model.return_url}&" +
                          $"cancel_url={model.cancel_url}&" +
                          $"status_url={model.status_url}&" +
                          $"language={model.language}&" +
                          $"pay_from_email={model.pay_from_email}&" +
                          $"amount={model.amount}&" +
                          $"currency={model.currency}&" +
                          $"detail1_description={model.detail1_description}&" +
                          $"detail1_text={model.detail1_text}&" +
                          $"detail2_description={model.detail2_description}&" +
                          $"detail2_text={model.detail2_text}&" +
                          $"detail3_description={model.detail3_description}&" +
                          $"detail3_text={model.detail3_text}&" +
                          $"payment_methods={model.payment_methods}&";

            HttpWebRequest httpRequest = (HttpWebRequest) WebRequest.Create("https://pay.skrill.com/");

            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/x-www-form-urlencoded";
            
            httpRequest.ContentLength = data.Length;

            // write the data to the request stream         
            using (StreamWriter writer = new StreamWriter(httpRequest.GetRequestStream()))
            {
                writer.Write(data);
                writer.Close();
            }


            try
            {
                HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();

                return new HttpWebResponseResult(response);
            }
            catch (Exception ex)
            {
                //if the account used is not a merchant a bad request exception is thrown
                throw ex;
            }
            
        }
    }
}