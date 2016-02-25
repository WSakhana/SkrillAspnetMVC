using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkrillAspnetMVC.Models
{
    public class SkrillPayRequest
    {
        public string pay_to_email { get; set; } = "demoqco@sun-fish.com";//Test with: demoqco@sun-fish.com

        public string return_url { get; set; } = "https://pay.skrill.com/payment_made.html";
        public string cancel_url { get; set; } = "https://pay.skrill.com/payment_cancelled.html";

        //You have to change ip @ with your own one
        public string status_url { get; set; } = "http://197.0.249.176/SkrillAspnetMVC/Skrill/Status";

        public string language { get; set; } = "FR";

        public string pay_from_email { get; set; }

        public string amount { get; set; } = "1.99";
        public string currency { get; set; } = "EUR";


        public string detail1_description { get; set; }
        public string detail1_text { get; set; }

        public string detail2_description { get; set; }
        public string detail2_text { get; set; }

        public string detail3_description { get; set; }
        public string detail3_text { get; set; }


        public string payment_methods { get; set; } = "WLT, PSC, ACC";
        
    }
}