using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkrillAspnetMVC.Models
{
    public class SkrillStatus
    {
        /*
            mb_amount 
            mb_currency
            status 
            failed_reason_code 
            md5sig MD5 signature (see MD5 signature, onpage 72). Yes 327638C253A4637199CEBA6642371F20
            sha2sig SHA2 signature (see SHA2 signature,on page 74). No (4) dbb7101322257a311f08d1c527053058fc7e464e30bcfb4613f09053c22dd1f8            
        */

        /// <summary>
        /// Your email address.
        /// </summary>
        public string pay_to_email { get; set; }

        /// <summary>
        /// Email address of the customer who is making the payment
        /// </summary>
        public string pay_from_email { get; set; }

        /// <summary>
        /// Unique ID of your Skrill account
        /// </summary>
        public string merchant_id { get; set; }

        /// <summary>
        /// If the customer pays using a Skrill Wallet
        /// </summary>
        public string customer_id { get; set; }

        /// <summary>
        /// A unique reference or identification number provided by you in your HTML form.
        /// </summary>
        public string transaction_id { get; set; }

        /// <summary>
        /// The total amount of the payment in the currency of your Skrill Digital Wallet account. Exp (25.46 / 25.4 / 25)
        /// </summary>
        public string mb_amount { get; set; }

        /// <summary>
        ///  Currency of mb_amount. exp Yes GBP
        /// </summary>
        public string mb_currency { get; set; }

        /// <summary>
        /// Status of the transaction: 
        /// ‐2 failed / 2 processed / 0 pending / ‐1 cancelled
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// If the transaction has a status value ‐2(failed), 
        /// this field will contain a code detailing the reason for the failure. 
        /// </summary>
        public string failed_reason_code { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string md5sig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string sha2sig { get; set; }


    }
}