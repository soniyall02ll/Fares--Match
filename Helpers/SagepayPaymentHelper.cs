using SagePay.IntegrationKit.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using SagePay.IntegrationKit;
using Newtonsoft.Json;
using Viman.Models;

namespace Viman
{
    public static class SagepayPaymentHelper
    {
        public static string BuildPaymentResponse(string hotelInfo, string objType, string referenceId)
        {
            string crypt = string.Empty;

            SagePayFormIntegration sagePayFormIntegration = new SagePayFormIntegration();

            IFormPayment request = sagePayFormIntegration.FormPaymentRequest();
            SetSagePayAPIData(request, hotelInfo, objType, referenceId);

            var errors = sagePayFormIntegration.Validation(request);

            if (errors == null || errors.Count == 0)
            {
                sagePayFormIntegration.ProcessRequest(request);               
                crypt = request.Crypt;
            }

            return crypt;
        }

        public static IFormPaymentResult GetPaymentResponse(string Crypt)
        {
            SagePayFormIntegration sagePayFormIntegration = new SagePayFormIntegration();
            var obj = sagePayFormIntegration.ProcessResult(Crypt);

            return obj;
        }

        private static void SetSagePayAPIData(IFormPayment request, string bookingInfo, string objType, string referenceId)
        {
            Booking booking = new Booking();
            string returnUrl = "";
            
            if (objType.Equals("flightBooking"))
            {
                FlightsBooking flightInfo = JsonConvert.DeserializeObject<FlightsBooking>(bookingInfo);

                booking.TotalAmount = (flightInfo.FlightsFare.GrandTotal + flightInfo.FlightsFare.AtolCharge) + "";
                booking.Currency = Common.CurrencyCode;
                booking.FirstName = flightInfo.BookerDetail.FirstName;
                booking.LastName = flightInfo.BookerDetail.LastName;
                booking.Email = flightInfo.BookerDetail.Email;
                booking.Phone = flightInfo.BookerDetail.PhoneNo;
                booking.Address1 = flightInfo.BookerDetail.Address1;
                booking.Address2 = flightInfo.BookerDetail.Address2;
                booking.Town = flightInfo.BookerDetail.City;
                booking.State = flightInfo.BookerDetail.State;
                booking.Country = flightInfo.BookerDetail.Country;
                booking.Zip = flightInfo.BookerDetail.PostCode;

                returnUrl = Common.WebsiteURL + "flight/notification";
            }
            else if (objType.Equals("quickPayment"))
            {
                QuickPayment quickInfo = JsonConvert.DeserializeObject<QuickPayment>(bookingInfo);

                booking.TotalAmount = quickInfo.Amount;
                booking.Currency = Common.CurrencyCode;
                booking.FirstName = quickInfo.FirstName;
                booking.LastName = quickInfo.LastName;
                booking.Email = quickInfo.Email;
                booking.Phone = quickInfo.Phone;
                booking.Address1 = quickInfo.Address;
                booking.Address2 = "";
                booking.Town = quickInfo.City;
                booking.State = "";
                booking.Country = quickInfo.Country;
                booking.Zip = quickInfo.Postcode;

                returnUrl = Common.WebsiteURL + "home/quickpaymentresponse";
            }

            var isCollectRecipientDetails = SagePaySettings.IsCollectRecipientDetails;

            request.VpsProtocol = SagePaySettings.ProtocolVersion;
            request.TransactionType = SagePaySettings.DefaultTransactionType;
            request.Vendor = SagePaySettings.VendorName;

            //Assign Vendor tx Code.
            request.VendorTxCode = referenceId;

            request.Amount = Decimal.Parse(booking.TotalAmount);
            request.Currency = booking.Currency;
            request.Description = "Payment to " + SagePaySettings.VendorName;
            request.SuccessUrl = returnUrl;
            request.FailureUrl = returnUrl;
            
            request.BillingSurname = booking.LastName;
            request.BillingFirstnames = booking.FirstName;
            request.BillingAddress1 = booking.Address1;
            request.BillingCity = booking.Town;
            request.BillingCountry = booking.Country;

            request.DeliverySurname = booking.LastName;
            request.DeliveryFirstnames = booking.FirstName;
            request.DeliveryAddress1 = booking.Address1;
            request.DeliveryCity = booking.Town;
            request.DeliveryCountry = booking.Country;

            //Optional
            request.CustomerName = booking.FirstName + " " + booking.LastName;
            request.CustomerEmail = booking.Email;
            request.VendorEmail = SagePaySettings.VendorEmail;
            request.SendEmail = SagePaySettings.SendEmail;

            request.EmailMessage = SagePaySettings.EmailMessage;
            request.BillingAddress2 = booking.Address2;
            request.BillingPostCode = booking.Zip;
            request.BillingPhone = booking.Phone;
            request.DeliveryAddress2 = booking.Address2;
            request.DeliveryPostCode = booking.Zip;
            request.DeliveryPhone = booking.Phone;

            request.AllowGiftAid = SagePaySettings.AllowGiftAid;
            request.ApplyAvsCv2 = SagePaySettings.ApplyAvsCv2;
            request.Apply3dSecure = SagePaySettings.Apply3dSecure;

            request.BillingAgreement = "";
            request.ReferrerId = SagePaySettings.ReferrerID;
            
            request.SurchargeXml = SagePaySettings.SurchargeXML;
            
            //set vendor data
            request.VendorData = ""; //Use this to pass any data you wish to be displayed against the transaction in My Sage Pay.
        }
    }
}