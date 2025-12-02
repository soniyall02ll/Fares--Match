using System;

using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Data;
using Newtonsoft.Json;
using System.Web.Helpers;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using SqlData.Data;
using Viman.Models;
using System.Security.Cryptography;
using System.Net.Mail;
using System;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using static System.Collections.Specialized.BitVector32;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace Viman.Models
{
    public class Common
    {
        public static string WebsiteURL = ConfigurationManager.AppSettings["WebsiteURL"];
        public static string StaticURL = ConfigurationManager.AppSettings["StaticURL"];
        public static string ApiURL = ConfigurationManager.AppSettings["ApiURL"];

        public static string ImgURL = ConfigurationManager.AppSettings["ImgURL"];

        public static string FolderPath = "/";

        public static string Currency = ConfigurationManager.AppSettings["Currency"];
        public static string CurrencyCode = ConfigurationManager.AppSettings["CurrencyCode"];
        public static string ApiKey = "83c2d9894f4d96312a79ae50418f9338";  //VIMAN
        public static string WebsiteCC = ConfigurationManager.AppSettings["WebsiteCC"];

        public static string UserName = ConfigurationManager.AppSettings["UserName"];
        public static string Password = ConfigurationManager.AppSettings["Password"];
        public static string _smtp = ConfigurationManager.AppSettings["SMTPCLINT"];
        public static string EmailID = ConfigurationManager.AppSettings["EmailID"];


        public static string[] GetPhoneNumber(string requrl)
        {
            string[] Phone_Folder = new string[2];
            string FolderName = "";
            if (requrl.Split('/').Length > 2)
            {
                FolderName = requrl.Substring(1, requrl.Length - 1).Substring(0, requrl.Substring(1, requrl.Length - 1).IndexOf('/'));
            }
            else if (requrl.Split('/').Length == 2)
            {
                FolderName = requrl.Substring(1, requrl.Length - 1);
            }
            string Folder = "";
            if (string.IsNullOrEmpty(FolderName))
            {
                FolderPath = "";
                Folder = "HOME";

            }
            else
            {

                Folder = FolderName;
            }
            try
            {

                DataTable dtphone = SqlHelperData.ExecuteDataset(SqlHelperData.ConnectionString, CommandType.Text, "SELECT top 1 Marketing,Platforms,Flight_sitePhone FROM ControlPermission where  marketing='" + Folder.ToUpper() + "' and Flights_IsActive=1").Tables[0];
                if (dtphone != null && dtphone.Rows.Count > 0)
                {
                    FolderPath = FolderName;
                    Phone_Folder[0] = dtphone.Rows[0]["Flight_sitePhone"].ToString();
                    Phone_Folder[1] = (Folder.ToUpper() == "HOME") ? "FLIGHTOFFICE" : FolderName;
                    return Phone_Folder;

                }
                else
                {
                    FolderPath = "";
                    Phone_Folder[0] = "0203 745 4455";
                    Phone_Folder[1] = "FLIGHTOFFICE";
                    return Phone_Folder;

                }

            }
            catch (Exception ex)
            {
                FolderPath = "";

                Phone_Folder[0] = "0203 745 4455";
                Phone_Folder[1] = "FLIGHTOFFICE";
                return Phone_Folder;
            }
        }


        public static string MD5(string s)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }
        }

        public static string GetId()
        {
            return Guid.NewGuid().ToString();
        }

        public static string GetSetting(string slug)
        {
            string ret_data = "";
            string qry = "SELECT * FROM Setting WHERE Slug='" + slug + "'";
            DataSet ds = SqlHelper.ExecuteDataset(qry, null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                ret_data = dr["Value"].ToString();
            }
            return ret_data;
        }
        public static string GetLocalIP()
        {
            string ip = HttpContext.Current.Request.UserHostAddress;
            return ip;
            /*var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");*/
        }

        public static string UcFirst(string input)
        {
            if (String.IsNullOrEmpty(input))
                return "";
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }

        public static int GetFlightWay(string wayType)
        {
            switch (wayType)
            {
                case "OneWay":
                    return 1;
                case "RoundTrip":
                    return 2;
            }
            return 2;
        }

        public static int GetFlightClass(string classType)
        {
            switch (classType)
            {
                case "First":
                    return 1;
                case "Business":
                    return 2;
                case "EconomyPremium":
                    return 3;
                case "Economy":
                    return 4;
            }
            return 4;
        }

        public static string GetMD5(string str)
        {
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(str)))
                    builder.Append(b.ToString("x2").ToLower());

                return builder.ToString();
            }
        }

        public static int GetTime(DateTime d2, DateTime d1)
        {
            TimeSpan span = d2.Subtract(d1);
            return (int)span.TotalMinutes;
        }
        public static string Encrypt(string PlainText)
        {
            string _securityKey = "FLIGHTOFFICEUK";

            byte[] toEncryptedArray = UTF8Encoding.UTF8.GetBytes(PlainText);
            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(_securityKey));
            objMD5CryptoService.Clear();
            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
            objTripleDESCryptoService.Key = securityKeyArray;
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;
            var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor();
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);

            objTripleDESCryptoService.Clear();

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public static string Decrypt(string CipherText)
        {
            string _securityKey = "FLIGHTOFFICEUK";

            byte[] toEncryptArray = Convert.FromBase64String((CipherText).Replace(" ", "+"));
            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(_securityKey));
            objMD5CryptoService.Clear();
            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();
            objTripleDESCryptoService.Key = securityKeyArray;
            objTripleDESCryptoService.Mode = CipherMode.ECB;
            objTripleDESCryptoService.Padding = PaddingMode.PKCS7;
            var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor();
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            objTripleDESCryptoService.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }


        public static byte[] GeneratePdfFromHtml(string htmlContent)
        {

           

            string wrappedHtml = "<html><head><meta charset='UTF-8'/></head><body>"
                                 + htmlContent +
                                 "</body></html>";

            using (MemoryStream stream = new MemoryStream())
            {
                // Create PDF document
                using (Document pdfDoc = new Document(PageSize.A4, 20f, 20f, 20f, 20f))
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    try
                    {
                        using (var htmlStream = new MemoryStream(Encoding.UTF8.GetBytes(wrappedHtml)))
                        {
                            
                            XMLWorkerHelper.GetInstance().ParseXHtml(
                                writer,
                                pdfDoc,
                                htmlStream,
                                null,
                                Encoding.UTF8,
                                new XMLWorkerFontProvider()
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        pdfDoc.NewPage();
                        pdfDoc.Add(new Paragraph("Error rendering HTML: " + ex.Message));
                    }

                    
                    if (writer.PageNumber == 0)
                    {
                        pdfDoc.NewPage();
                        pdfDoc.Add(new Paragraph("No content rendered from HTML."));
                    }

                    pdfDoc.Close();
                }

                return stream.ToArray();
            }
        }




        public static string SendEmailWithPdf(string ToEmail, string EmailSubject, string EMailBody, string EmailCC = "", string EmailBCC = "")
        {
            try
            {
                // Convert HTML body to PDF
                byte[] pdfBytes = GeneratePdfFromHtml(EMailBody);

                // Create the mail message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("booking@faresmatch.com", "FaresMatch"); // display name optional
                mail.To.Add(ToEmail);
                if (!string.IsNullOrEmpty(EmailCC)) mail.CC.Add(EmailCC);
                if (!string.IsNullOrEmpty(EmailBCC)) mail.Bcc.Add(EmailBCC);

                mail.Subject = EmailSubject;
                mail.Body = "Dear Customer,\n\nPlease find your ticket attached as a PDF.\n\nThank you for booking with FaresMatch!";
                mail.IsBodyHtml = false;

                // Attach PDF
                using (MemoryStream pdfStream = new MemoryStream(pdfBytes))
                {
                    pdfStream.Position = 0;
                    Attachment attachment = new Attachment(pdfStream, "Ticket_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf", "application/pdf");
                    mail.Attachments.Add(attachment);

                    // Configure SMTP
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new System.Net.NetworkCredential("booking@faresmatch.com", "dbdi fovt aozs fesk"); 
                    smtp.EnableSsl = true;

                    smtp.Send(mail);
                }

                return "success";
            }
            catch (Exception ex)
            {
                return "Error sending mail: " + ex.Message;
            }
        }




        //public static string SendEmail(string ToEmail, string EmailSubject, string EMailBody, string EmailCC = "", string EmailBCC = "", bool isBodyHtml = true)
        //{
        //    try
        //    {
        //        //WebMail.SmtpServer = "smtp.gmail.com";
        //        //WebMail.SmtpPort = 587;
        //        //WebMail.SmtpUseDefaultCredentials = true;
        //        //WebMail.EnableSsl = true;
        //        //WebMail.UserName = "deepanshujoshi09@gmail.com";
        //        //WebMail.Password = "blpx eghx zdkn vfto";
        //        //WebMail.From = "Deepanshujoshi <deepanshujoshi09@gmail.com>";              


        //        WebMail.Send(to: ToEmail, subject: EmailSubject, body: EMailBody, cc: EmailCC, bcc: EmailBCC, isBodyHtml: true);
        //        return "success";
        //    }
        //    catch (Exception e)
        //    {
        //        return e.ToString();
        //    }
        //}

        //public static string GetPhone(string ClickType, string SiteCode, string SourceMedia)
        //{
        //    string SitePhone = "0203 745 4455";
        //    DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM SitePhone WHERE SiteCode='" + SiteCode + "' AND SourceMedia='" + SourceMedia + "' AND LinkType='" + ClickType + "'", null);
        //    if (ds != null && ds.Tables[0].Rows.Count > 0)
        //    {
        //        DataRow dr = ds.Tables[0].Rows[0];
        //        SitePhone = dr["Phone"].ToString();
        //    }
        //    return SitePhone;
        //}

        public static string SendEmailNew(string ToEmail, string EmailSubject, string EMailBody, string EmailCC = "", string EmailBCC = "", bool isBodyHtml = true)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(EmailID);
                message.To.Add(new MailAddress(ToEmail));
                message.Subject = EmailSubject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = EMailBody;
                smtp.Port = 587;
                smtp.Host = _smtp; //for gmail host  

                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(UserName, Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                //  smtp.Send(message);


                try
                {
                    smtp.Send(message);
                    return ("true");
                }
                catch (Exception ex)
                {
                    return ("" + ex.ToString());
                }
            }
            catch (Exception e)
            {
                return "failure";
                //return e.ToString();
            }
        }
        public static string GetPhone(string ClickType, string SiteCode, string SourceMedia)
        {
            string SitePhone = "0203 745 4455";
            string marketing = "HOME";
            if (SourceMedia.ToUpper() != "VIMAN")
            {
                marketing = SourceMedia.ToUpper();

            }

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM ControlPermission WHERE marketing='" + marketing + "' AND Platforms='" + ClickType + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                SitePhone = dr["Viman_SitePhone"].ToString();
            }
            return SitePhone;
        }
        public static void SaveClick(string ClickType, string SourceMedia, string Linkurl, FlightsSearch flightSearch)
        {
            SqlParameter[] commandParameters = new SqlParameter[10];
            commandParameters[0] = new SqlParameter("@clicktype", SqlDbType.VarChar, 50) { Value = ClickType };
            commandParameters[1] = new SqlParameter("@sourcemedia", SqlDbType.VarChar, 50) { Value = SourceMedia };
            commandParameters[2] = new SqlParameter("@linkurl", SqlDbType.VarChar) { Value = Linkurl };
            commandParameters[3] = new SqlParameter("@flightsearch", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(flightSearch) };
            commandParameters[4] = new SqlParameter("@status", SqlDbType.VarChar, 50) { Value = "active" };
            commandParameters[5] = new SqlParameter("@timestamp", SqlDbType.DateTime) { Value = DateTime.Now };
            commandParameters[6] = new SqlParameter("@sitecode", SqlDbType.VarChar, 50) { Value = SiteCode.VIMAN.ToString() };

            DataSet ds = SqlHelper.ExecuteDataset("INSERT INTO FlightClick(ClickType,SiteCode,SourceMedia,LinkUrl,FlightSearch,Status,Timestamp) VALUES(@clicktype,@sitecode,@sourcemedia,@linkurl,@flightsearch,@status,@timestamp) SELECT SCOPE_IDENTITY()", commandParameters);
        }

        public static void SaveTrackSearch(FlightsSearch flightSearch)
        {
            string usersIpAddress = Common.GetLocalIP();
            // save search data in database
            SqlParameter[] commandParameters = new SqlParameter[16];
            commandParameters[0] = new SqlParameter("@fromairport", SqlDbType.VarChar, 50) { Value = flightSearch.From.Code };
            commandParameters[1] = new SqlParameter("@toairport", SqlDbType.VarChar, 50) { Value = flightSearch.To.Code };
            commandParameters[2] = new SqlParameter("@depdate", SqlDbType.Date) { Value = flightSearch.DepDate };
            commandParameters[3] = new SqlParameter("@retdate", SqlDbType.Date) { Value = flightSearch.RetDate };
            commandParameters[4] = new SqlParameter("@adult", SqlDbType.Int) { Value = flightSearch.Adult };
            commandParameters[5] = new SqlParameter("@child", SqlDbType.Int) { Value = flightSearch.Child };
            commandParameters[6] = new SqlParameter("@infant", SqlDbType.Int) { Value = flightSearch.Infant };
            commandParameters[7] = new SqlParameter("@flightway", SqlDbType.VarChar, 50) { Value = flightSearch.FlightWay };
            commandParameters[8] = new SqlParameter("@flightclass", SqlDbType.VarChar, 50) { Value = flightSearch.FlightClass };
            commandParameters[9] = new SqlParameter("@isdirect", SqlDbType.Int) { Value = flightSearch.IsDirect };
            commandParameters[10] = new SqlParameter("@isflexi", SqlDbType.Int) { Value = flightSearch.IsFlexi };
            commandParameters[11] = new SqlParameter("@sitecode", SqlDbType.VarChar, 50) { Value = flightSearch.SiteCode };
            commandParameters[12] = new SqlParameter("@sourcemedia", SqlDbType.VarChar, 50) { Value = flightSearch.SourceMedia };
            commandParameters[13] = new SqlParameter("@ip", SqlDbType.VarChar, 50) { Value = usersIpAddress };
            commandParameters[14] = new SqlParameter("@FetchType", SqlDbType.VarChar, 50) { Value = (flightSearch.IsDeepLink) ? "DEEPLINK" : "META" };
            commandParameters[15] = new SqlParameter("@timestamp", SqlDbType.DateTime) { Value = DateTime.Now };

            SqlParameter[] commandParameters1 = commandParameters;
            string allowedIps = ConfigurationManager.AppSettings["allowedIPs"].Replace(" ", "").Trim();
            string[] ips = allowedIps.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            //  string sqlquery = "INSERT INTO FlightTrack(FromAirport,ToAirport,DepDate,RetDate,Adult,Child,Infant,FlightWay,FlightClass,IsDirect,IsFlexi,SiteCode,SourceMedia,Ip,FetchType,Timestamp) VALUES('" + flightSearch.From.Code.Replace("'", "''") + "','" + flightSearch.To.Code.Replace("'", "''") + "'," + flightSearch.DepDate + "," + flightSearch.RetDate + "," + flightSearch.Adult + "," + flightSearch.Child + "," + flightSearch.Infant + ",'" + flightSearch.FlightWay + "','" + flightSearch.FlightClass.ToString().Replace("'", "''") + "','" + flightSearch.IsDirect + "','" + flightSearch.IsFlexi + "','" + flightSearch.SiteCode + "','" + flightSearch.SourceMedia + "','" + usersIpAddress + "','" + Fetchtype + "'," + DateTime.Now + ")";

            //if (!ips.Contains(usersIpAddress))
            if (!ips.Contains(usersIpAddress))
            {
                string sqlquery = "INSERT INTO FlightTrack(FromAirport,ToAirport,DepDate,RetDate,Adult,Child,Infant,FlightWay,FlightClass,IsDirect,IsFlexi,SiteCode,SourceMedia,Ip,FetchType,Timestamp) VALUES(@fromairport,@toairport,@depdate,@retdate,@adult,@child,@infant,@flightway,@flightclass,@isdirect,@isflexi,@sitecode,@sourcemedia,@ip,@FetchType,@timestamp)";
                int c = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringTrack, CommandType.Text, sqlquery, commandParameters);
            }
        }
        public static Markup GetMarkup(string Provider)
        {
            Markup markup = new Markup();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM Markup WHERE Provider='" + Provider + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                markup.AdultMarkup = Double.Parse(dr["AdultMarkup"].ToString());
                markup.ChildMarkup = Double.Parse(dr["ChildMarkup"].ToString());
                markup.InfantMarkup = Double.Parse(dr["InfantMarkup"].ToString());
            }

            return markup;
        }

        public static List<Trustpilot> GetTrustpilot()
        {
            List<Trustpilot> objTrustpilot = new List<Trustpilot>();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT TOP 15 * FROM Trustpilot WHERE SiteCode='FlyGlobe' AND (Rate=4 OR Rate=5) ORDER BY PublishDate DESC");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objTrustpilot.Add(new Trustpilot()
                    {
                        Id = Convert.ToInt32(dr["Id"].ToString()),
                        Rate = Convert.ToInt32(dr["Rate"].ToString()),
                        Title = dr["Title"].ToString(),
                        Message = dr["Message"].ToString(),
                        Name = dr["Name"].ToString(),
                        TimeAgo = GetTimeAgo(Convert.ToDateTime(dr["PublishDate"]))
                    });
                }
            }
            return objTrustpilot;
        }

        public static string GetDateDiffDay(DateTime d1, DateTime d2)
        {
            TimeSpan t = d1.Date - d2.Date;

            return t.Days + "";
        }

        public static string GetCardType(string CardNumber)
        {
            return "VISA";
        }
        public static List<CarLocation> GetAllLocation(string str = null)
        {
            List<CarLocation> location = new List<CarLocation>();
            string qry = "SELECT * FROM CarLocation";
            if (str != null && !str.Equals(""))
                qry = "SELECT * FROM CarLocation WHERE Name LIKE '%" + str + "%'";
            qry += " ORDER BY Name";

            DataSet ds = SqlHelper.ExecuteDataset(qry, null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    location.Add(new CarLocation()
                    {
                        LocationId = dr["Id"].ToString(),
                        LocationCode = dr["LocationCode"].ToString(),
                        LocationType = dr["LocationType"].ToString().ToLower(),
                        CityCode = dr["CityCode"].ToString(),
                        CityName = dr["CityName"].ToString(),
                        Name = dr["Name"].ToString(),
                        Address = dr["Address1"].ToString(),
                        State = dr["State"].ToString(),
                        Zip = dr["Zip"].ToString(),
                        Latitude = dr["Latitude"].ToString(),
                        Longtitude = dr["Longtitude"].ToString()
                    });
                }
            }
            List<CarLocation> location_dis = location.GroupBy(s => s.CityCode).Select(grp => grp.FirstOrDefault()).ToList();

            return location_dis;
        }
        public static CarsResult SearchCar(CarsSearch carSearch)
        {
            CarsResult carsResult = new CarsResult();

            try
            {
                if (carSearch != null)
                {
                    string url = ApiURL + "cars/search";
                    string serialisedData = JsonConvert.SerializeObject(carSearch);
                    WebClient webClient = new WebClient();
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = webClient.UploadString(url, serialisedData);

                    carsResult = JsonConvert.DeserializeObject<CarsResult>(result.ToString());
                }
            }
            catch (Exception e)
            {
                carsResult.Error = e.Message.ToString();
                carsResult.CarsSearch = carSearch;
            }
            return carsResult;
        }
        public static CarsBooking GetCarById(string fid)
        {
            CarsBooking carsBooking = new CarsBooking();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM CarsBooking WHERE TranscationId='" + fid + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                carsBooking.Id = long.Parse(dr["Id"].ToString());
                carsBooking.BookingId = dr["BookingId"].ToString();
                carsBooking.SearchId = dr["SearchId"].ToString();
                carsBooking.TranscationId = dr["TranscationId"].ToString();
                carsBooking.PNRNo = dr["PNRNo"].ToString();
                carsBooking.FullName = dr["FullName"].ToString();
                carsBooking.Email = dr["Email"].ToString();
                carsBooking.PhoneNo = dr["PhoneNo"].ToString();
                carsBooking.CarsSearch = JsonConvert.DeserializeObject<CarsSearch>(dr["CarsSearch"].ToString());
                carsBooking.Cars = JsonConvert.DeserializeObject<Cars>(dr["Cars"].ToString());
                carsBooking.BookerDetail = JsonConvert.DeserializeObject<BookerDetail>(dr["BookerDetail"].ToString());
                carsBooking.PassengerDetail = JsonConvert.DeserializeObject<List<PassengerDetail>>(dr["PassengerDetail"].ToString());
                carsBooking.CarsFare = JsonConvert.DeserializeObject<CarsFare>(dr["CarsFare"].ToString());
                carsBooking.PaymentDetail = JsonConvert.DeserializeObject<PaymentDetail>(dr["PaymentDetail"].ToString());
                carsBooking.SagepayDetail = JsonConvert.DeserializeObject<SagepayDetail>(dr["SagepayDetail"].ToString());
                carsBooking.SiteCode = dr["SiteCode"].ToString();
                carsBooking.SourceMedia = dr["SourceMedia"].ToString();
                carsBooking.PaymentStatus = dr["PaymentStatus"].ToString();
                carsBooking.WorldResponse = dr["WorldResponse"].ToString();
                carsBooking.TranscationStatus = dr["TranscationStatus"].ToString();
                carsBooking.Status = dr["Status"].ToString();
                carsBooking.Timestamp = Convert.ToDateTime(dr["Timestamp"]);
            }

            return carsBooking;
        }
        public static CarsResult FillCarPrice(CarsResult car)
        {
            CarsResult newCar = new CarsResult();
            newCar.Error = car.Error;
            newCar.CarsSearch = car.CarsSearch;
            newCar.CarsList = new List<Cars>();
            newCar.CarsList.AddRange(car.CarsList);

            // min max count
            newCar.MinPrice = (int)Math.Floor(car.CarsList.Min(f => f.TotalCost));
            newCar.MaxPrice = (int)Math.Ceiling(car.CarsList.Max(f => f.TotalCost));

            // supplier list
            newCar.Supplier = new List<string>();
            List<Cars> carList = newCar.CarsList.GroupBy(f => f.Supplier).Select(g => g.FirstOrDefault()).ToList();
            foreach (Cars item in carList)
            {
                newCar.Supplier.Add(item.Supplier);
            }

            return newCar;
        }
        public static string GetCarBookingId(string pre = null)
        {
            string str = "";

            DataSet ds = SqlHelper.ExecuteDataset("SELECT TOP 1 * FROM CarsBooking ORDER BY Id DESC", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                string max_id = (int.Parse(dr["Id"].ToString()) + 1) + "";

                str = pre + max_id.PadLeft(6, '0');
            }
            else
            {
                str = pre + "000001";
            }

            return str;
        }
        public static CarsBooking CarRequest(CarsBooking carsBooking, string _url)
        {
            CarsBooking responseCars = new CarsBooking();
            responseCars = carsBooking;

            try
            {
                if (carsBooking != null)
                {
                    string url = ApiURL + _url;
                    string serialisedData = JsonConvert.SerializeObject(carsBooking);
                    WebClient webClient = new WebClient();
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = webClient.UploadString(url, serialisedData);

                    responseCars = JsonConvert.DeserializeObject<CarsBooking>(result.ToString());
                }
            }
            catch (Exception e)
            {
                responseCars.TranscationStatus = "error";
            }

            return responseCars;
        }
        public static string UpperCaseWords(string value)
        {
            value = value.ToLower();
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public static string GetTimeAgo(DateTime strDate)
        {
            string strTime = string.Empty;

            TimeSpan t = DateTime.UtcNow - Convert.ToDateTime(strDate);
            double deltaSeconds = t.TotalSeconds;

            double deltaMinutes = deltaSeconds / 60.0f;
            int minutes;

            if (deltaSeconds < 5)
            {
                return "Just now";
            }
            else if (deltaSeconds < 60)
            {
                return Math.Floor(deltaSeconds) + " seconds ago";
            }
            else if (deltaSeconds < 120)
            {
                return "A minute ago";
            }
            else if (deltaMinutes < 60)
            {
                return Math.Floor(deltaMinutes) + " minutes ago";
            }
            else if (deltaMinutes < 120)
            {
                return "An hour ago";
            }
            else if (deltaMinutes < (24 * 60))
            {
                minutes = (int)Math.Floor(deltaMinutes / 60);
                return minutes + " hours ago";
            }
            else if (deltaMinutes < (24 * 60 * 2))
            {
                return "Yesterday";
            }
            else if (deltaMinutes < (24 * 60 * 7))
            {
                minutes = (int)Math.Floor(deltaMinutes / (60 * 24));
                return minutes + " days ago";
            }
            else if (deltaMinutes < (24 * 60 * 14))
            {
                return "Last week";
            }
            else if (deltaMinutes < (24 * 60 * 31))
            {
                minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 7));
                return minutes + " weeks ago";
            }
            else if (deltaMinutes < (24 * 60 * 61))
            {
                return "Last month";
            }
            else if (deltaMinutes < (24 * 60 * 365.25))
            {
                minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 30));
                return minutes + " months ago";
            }
            else if (deltaMinutes < (24 * 60 * 731))
            {
                return "Last year";
            }

            minutes = (int)Math.Floor(deltaMinutes / (60 * 24 * 365));
            return minutes + " years ago";
        }

        public static List<BestDeal> GetBestDeal()
        {
            List<BestDeal> objTrustpilot = new List<BestDeal>();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT TOP 12 * FROM BestDeal WHERE SiteCode='VIMAN' AND DealType='BestDeal' ORDER BY Id DESC");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objTrustpilot.Add(new BestDeal()
                    {
                        Id = Convert.ToInt32(dr["Id"].ToString()),
                        DealType = dr["DealType"].ToString(),
                        RefNo = dr["RefNo"].ToString(),
                        Title = dr["Title"].ToString(),
                        Discount = Convert.ToInt32(dr["Discount"].ToString()),
                        Price = dr["Price"].ToString(),
                        ImagePath = dr["ImagePath"].ToString(),
                        Status = dr["Status"].ToString(),
                    });
                }
            }
            return objTrustpilot;
        }

        public static List<HolidayOffer> GetHolidayOffer()
        {
            List<HolidayOffer> objTrustpilot = new List<HolidayOffer>();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT TOP 12 * FROM BestDeal WHERE SiteCode='VIMAN' AND DealType='HolidayOffer' ORDER BY Id DESC");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objTrustpilot.Add(new HolidayOffer()
                    {
                        Id = Convert.ToInt32(dr["Id"].ToString()),
                        DealType = dr["DealType"].ToString(),
                        RefNo = dr["RefNo"].ToString(),
                        Title = dr["Title"].ToString(),
                        Discount = Convert.ToInt32(dr["Discount"].ToString()),
                        Price = dr["Price"].ToString(),
                        Night = dr["Night"].ToString(),
                        ImagePath = dr["ImagePath"].ToString(),
                        Status = dr["Status"].ToString(),
                    });
                }
            }
            return objTrustpilot;
        }

        public static string GetBookingId(string pre = null)
        {
            string str = "";

            DataSet ds = SqlHelper.ExecuteDataset("SELECT TOP 1 * FROM FlightsBooking ORDER BY Id DESC", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                string max_id = (int.Parse(dr["Id"].ToString()) + 1) + "";

                str = pre + max_id.PadLeft(6, '0');
            }
            else
            {
                str = pre + "000001";
            }

            return str;
        }


        public static CarLocation GetCarLocation(string Code)
        {
            CarLocation location = new CarLocation();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM CarLocation WHERE Id=" + Code, null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                location.LocationId = dr["Id"].ToString();
                location.LocationType = "airport";
                location.LocationCode = dr["LocationCode"].ToString();
                location.CityCode = dr["CityCode"].ToString();
                location.CityName = dr["CityName"].ToString();
                location.Name = dr["Name"].ToString();
                location.State = dr["State"].ToString();
                location.Address = dr["Address1"].ToString();
                location.Latitude = dr["Latitude"].ToString();
                location.Longtitude = dr["Longtitude"].ToString();
            }
            else
            {
                location.LocationId = "";
                location.LocationType = "airport";
                location.LocationCode = Code;
                location.CityCode = Code;
                location.CityName = Code;
                location.State = Code;
                location.Address = Code;
                location.Latitude = "";
                location.Longtitude = "";
            }

            return location;
        }
        public static string GetEnquiryId(string pre = null)
        {
            string str = "";

            DataSet ds = SqlHelper.ExecuteDataset("SELECT TOP 1 * FROM FlightsEnquiry ORDER BY Id DESC", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                string max_id = (int.Parse(dr["Id"].ToString()) + 1) + "";

                str = pre + max_id.PadLeft(6, '0');
            }
            else
            {
                str = pre + "000001";
            }

            return str;
        }

        public static FlightsResult SearchFlight(FlightsSearch flightSearch)
        {
            //FlightsResult flightsResult = new FlightsResult();

            FlightsResult resultModel = new FlightsResult
            {
                FlightsList = new List<Flights>()
            };


            try
            {
                if (flightSearch != null)
                {
                    object requestObj;


                    string url = "http://farematch.onlyfortravels.com/api/Search/GetLowfares";
                    if (flightSearch.FlightWay == FlightWay.RoundTrip)
                    {
                        requestObj = new
                        {
                            Authentication = new
                            {
                                CompanyId = "FRMT",
                                CredentialId = "FRMT",
                                CredentialPassword = "3@MR!#",
                                CredentialType = "LIVE"
                            },
                            TypeOfTrip = "Return",
                            Segments = new[]
                            {
    new
    {
        Origin = flightSearch.From.Code,
        Destination = flightSearch.To.Code,
        DepartureDate = flightSearch.DepDate.ToString("dd-MM-yyyy"),
        DepartureTime = "00:01",
        DepartureTimeTo = "23:59",
        ClassOfService = flightSearch.FlightClass.ToString()
    },
    new
    {
        Origin = flightSearch.To.Code,
        Destination = flightSearch.From.Code,
        DepartureDate = flightSearch.RetDate.ToString("dd-MM-yyyy"),
        DepartureTime = "00:01",
        DepartureTimeTo = "23:59",
        ClassOfService = flightSearch.FlightClass.ToString()
    }
},
                            PaxDetail = new
                            {
                                Adults = flightSearch.Adult,
                                Child = flightSearch.Child,
                                Infants = flightSearch.Infant,
                                Youths = 0
                            },
                            Flexi = flightSearch.IsFlexi ? 1 : 0,
                            Direct = flightSearch.IsDirect ? 1 : 3,
                            ClassOfService = flightSearch.FlightClass.ToString(),
                            Airlines = new[] { "" },
                            FareFamily = (string)null,
                            TravelType = "",
                            RefundableOnly = "false",
                            Currency = "USD",
                            SearchId = flightSearch.SearchId
                        };
                    }
                    else
                    {
                        // One Way Trip
                        requestObj = new
                        {
                            Authentication = new
                            {
                                CompanyId = "FRMT",
                                CredentialId = "FRMT",
                                CredentialPassword = "3@MR!#",
                                CredentialType = "LIVE"
                            },
                            TypeOfTrip = "OneWay",
                            Segments = new[]
                            {
                                new
                                      {
                                          Origin = flightSearch.From.Code,
                                          Destination = flightSearch.To.Code,
                                          DepartureDate = flightSearch.DepDate.ToString("dd-MM-yyyy"),
                                          DepartureTime = "00:01",
                                          DepartureTimeTo = "23:59",
                                          ClassOfService = flightSearch.FlightClass.ToString()
                                       }
                                    },
                            PaxDetail = new
                            {
                                Adults = flightSearch.Adult,
                                Child = flightSearch.Child,
                                Infants = flightSearch.Infant,
                                Youths = 0
                            },
                            Flexi = flightSearch.IsFlexi ? 1 : 0,
                            Direct = flightSearch.IsDirect ? 1 : 3,
                            ClassOfService = flightSearch.FlightClass.ToString(),
                            Airlines = new[] { "" },
                            FareFamily = (string)null,
                            TravelType = "",
                            RefundableOnly = "false",
                            Currency = flightSearch.Currency,
                            SearchId = flightSearch.SearchId
                        };
                    }

                    string serialisedData = JsonConvert.SerializeObject(requestObj);
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        string response = webClient.UploadString(url, serialisedData);

                        // Deserialize new API format
                        List<Root> apiResponse = JsonConvert.DeserializeObject<List<Root>>(response);

                        if (apiResponse != null && apiResponse.Any())
                        {
                            foreach (var item in apiResponse)
                            {
                                Flights mappedFlight = MapToExistingModel(item);
                                resultModel.FlightsList.Add(mappedFlight);
                            }

                            resultModel.MinPrice = (int)apiResponse.Min(x => x.grandTotal);
                            resultModel.MaxPrice = (int)apiResponse.Max(x => x.grandTotal);
                        }

                        resultModel.FlightsSearch = flightSearch;
                    }
                }
            }
            catch (Exception ex)
            {
                resultModel.Error = ex.Message;
                resultModel.FlightsSearch = flightSearch;
            }

            return resultModel;
        }


        private static Flights MapToExistingModel(Root src)
        {
            if (src == null) return null;

            // Ensure sectors lists are not null
            var onward = src.sectors?.Where(s => s.group == "0").ToList() ?? new List<Sector>();
            var inbound = src.sectors?.Where(s => s.group == "1").ToList() ?? new List<Sector>();
            var firstWithAirline = src.sectors?.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s.airlineCode));

            var flight = new Flights
            {
                Provider = src.provider,
                FlightId = src.uid,
                SessionId = src.searchID,
                Currency = src.currency,
                TotalCost = src.grandTotal,
                FareRules = src.fareFamily,
                IsDeal = src.promotionalFare,
                DeepLink = "",

                TotalTime = GetTotalMinutes(src.sectors.FirstOrDefault()?.travelTime), // Already int
                Stops = (onward.Count > 0 ? onward.Count - 1 : 0),



                Airline = new Airline
                {
                    Code = firstWithAirline?.airlineCode ?? "",
                    Name = firstWithAirline?.airlineName ?? ""
                },

                //Airline = new Airline
                //{
                //    Code = src.sectors.FirstOrDefault()?.airlineCode ?? "",
                //    Name = src.sectors.FirstOrDefault()?.airlineName ?? ""
                //},
                FlightFare = MapFare(src.priceBreakup),
                Outbound = MapSegments(onward, false),
                Inbound = MapSegments(inbound, true),
                OutboundList = new List<List<FlightsSegment>>(),
                InboundList = new List<List<FlightsSegment>>(),
                Baglimit = MapBaglimit(onward.FirstOrDefault())
            };

            if (flight.Outbound.Any())
                flight.OutboundList.Add(flight.Outbound);
            else
                flight.OutboundList.Add(new List<FlightsSegment>()); // ensure list is never empty

            if (flight.Inbound.Any())
                flight.InboundList.Add(flight.Inbound);
            else
                flight.InboundList.Add(new List<FlightsSegment>()); // ensure list is never empty

            return flight;
        }


        private static FlightsFare MapFare(List<PriceBreakup> breakups)
        {
            FlightsFare fare = new FlightsFare();

            if (breakups == null) return fare;

            foreach (var item in breakups)
            {
                switch (item.passengerType?.ToLower())
                {
                    case "adt":
                    case "adult":
                        fare.AdultFare = item.baseFare;
                        fare.AdultTax = item.tax;
                        fare.AdultMarkup = item.markUp;
                        fare.Adult = item.noOfPassenger;
                        break;

                    case "cnn":
                    case "child":
                        fare.ChildFare = item.baseFare;
                        fare.ChildTax = item.tax;
                        fare.ChildMarkup = item.markUp;
                        fare.Child = item.noOfPassenger;
                        break;

                    case "inf":
                    case "infant":
                        fare.InfantFare = item.baseFare;
                        fare.InfantTax = item.tax;
                        fare.InfantMarkup = item.markUp;
                        fare.Infant = item.noOfPassenger;
                        break;
                }
            }
            return fare;
        }

        private static List<FlightsSegment> MapSegments(List<Sector> sectors, bool isReturn)
        {
            var segments = new List<FlightsSegment>();
            if (sectors == null) return segments;

            foreach (var s in sectors)
            {
                var totalMinutes = GetTotalMinutes(s.travelTime);



                var seg = new FlightsSegment
                {
                    OptionRef = s.fareBasisCode,
                    SagementRef = s.fareBasisCode,

                    DepartureDate = CombineDateTime(s.departure?.date, s.departure?.time),
                    ArrivalDate = CombineDateTime(s.arrival?.date, s.arrival?.time),



                    FromAirport = new Airport
                    {
                        Code = s.departure?.code,
                        Name = s.departure?.name,
                        CityCode = s.departure?.cityCode,
                        CityName = s.departure?.cityName,
                        CountryCode = s.departure?.countryCode,
                        CountryName = s.departure?.countryName
                    },
                    ToAirport = new Airport
                    {
                        Code = s.arrival?.code,
                        Name = s.arrival?.name,
                        CityCode = s.arrival?.cityCode,
                        CityName = s.arrival?.cityName,
                        CountryCode = s.arrival?.countryCode,
                        CountryName = s.arrival?.countryName
                    },

                    Airline = new Airline
                    {
                        Code = s.marketingCarrier?.code,
                        Name = s.marketingCarrier?.name
                    },
                    OperatingAirline = new Airline
                    {
                        Code = s.operatingCarrier?.code,
                        Name = s.operatingCarrier?.name
                    },

                    FlightNo = s.fltNum,
                    EquipmentType = s.equipType,
                    FromTerminal = s.departure?.terminal,
                    ToTerminal = s.arrival?.terminal,
                    Distance = s.distance,
                    ETicket = s.eTicket,
                    ChangePlane = s.changeOfPlane,
                    BaggageAllowance = s.baggageInfo,
                    ElapsedTime = s.travelTime,
                    TotalTime = totalMinutes.ToString(),
                    CabinClass = s.cabinClass,
                    Availability = s.availabilitySource,
                    BookingCode = s.fareBasisCode,
                    IsReturn = isReturn
                };

                segments.Add(seg);
            }

            return segments;
        }



        private static Baglimit MapBaglimit(Sector sector)
        {
            if (sector == null) return null;

            return new Baglimit
            {
                hand_weight = sector.handBaggage,
                hold_weight = sector.baggageInfo
            };
        }

        private static DateTime CombineDateTime(string date, string time)
        {
            if (string.IsNullOrWhiteSpace(date))
                return DateTime.MinValue;

            string combined = string.IsNullOrWhiteSpace(time) ? date : $"{date} {time}";
            DateTime result;


            //string[] formats = {
            //    "dd/MM/yyyy HH:mm",
            //    "dd/MM/yyyy",
            //    "dd-MMM-yyyy HH:mm:ss",
            //    "dd-MMM-yyyy",
            //    "yyyy-MM-ddTHH:mm:ss",
            //    "yyyy-MM-dd",
            //    "HH:mm"
            //};

            string[] formats = {
                "dd-MM-yyyy HH:mm",
                "dd/MM/yyyy HH:mm",
                "dd-MMM-yyyy HH:mm:ss",
                "dd-MMM-yyyy HH:mm",
                "yyyy-MM-ddTHH:mm:ss",
                "yyyy-MM-dd HH:mm:ss",
                "yyyy-MM-ddTHH:mm",
                "yyyy-MM-dd",
                "dd-MM-yyyy",
                "HH:mm"
            };

            if (DateTime.TryParseExact(
                    combined,
                    formats,
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out result))
            {
                return result;
            }

            // Final fallback
            if (DateTime.TryParse(combined, out result))
                return result;

            return DateTime.MinValue;
        }






        //private static int GetTotalMinutes(object time)
        //{
        //    if (time == null) return 0;

        //    string timeStr = time.ToString();
        //    if (string.IsNullOrWhiteSpace(timeStr)) return 0;


        //    TimeSpan ts;
        //    if (TimeSpan.TryParse(timeStr, out ts))
        //        return (int)ts.TotalMinutes;


        //    var parts = timeStr.Split(':');
        //    int hours, minutes;
        //    if (parts.Length == 2 && int.TryParse(parts[0], out hours) && int.TryParse(parts[1], out minutes))
        //        return hours * 60 + minutes;


        //    double total;
        //    if (double.TryParse(timeStr, out total))
        //        return (int)total;


        //    return 0;
        //}


        private static int GetTotalMinutes(object time)
        {
            if (time == null) return 0;

            string timeStr = time.ToString().Trim().ToLower();
            if (string.IsNullOrWhiteSpace(timeStr)) return 0;

            // Try normal TimeSpan parsing (e.g. "02:45")
            TimeSpan ts;
            if (TimeSpan.TryParse(timeStr, out ts))
                return (int)ts.TotalMinutes;

            // Handle formats like "2h:45m", "2h45m", "1h 5m"
            int hours = 0, minutes = 0;

            // Extract hours (if present)
            int hIndex = timeStr.IndexOf('h');
            int h;
            if (hIndex > 0 && int.TryParse(timeStr.Substring(0, hIndex).Trim().Replace(":", ""), out h))
                hours = h;

            // Extract minutes (if present)
            int mIndex = timeStr.IndexOf('m');
            if (mIndex > 0)
            {
                string minPart;
                if (hIndex > 0 && mIndex > hIndex)
                    minPart = timeStr.Substring(hIndex + 1, mIndex - hIndex - 1);
                else
                    minPart = timeStr.Substring(0, mIndex);

                int m;
                if (int.TryParse(minPart.Replace(":", "").Trim(), out m))
                    minutes = m;
            }

            // Handle simple "hh:mm" split fallback
            if (hours == 0 && minutes == 0)
            {
                var parts = timeStr.Split(':');
                if (parts.Length == 2)
                {
                    int h2, m2;
                    if (int.TryParse(parts[0], out h2) && int.TryParse(parts[1], out m2))
                        return h2 * 60 + m2;
                }
            }

            // Handle plain numeric string fallback (e.g. "120" means 120 minutes)
            double total;
            if (hours == 0 && minutes == 0 && double.TryParse(timeStr, out total))
                return (int)total;

            return hours * 60 + minutes;
        }



        public static FlightsResult GetItineraryFlight(string searchId)
        {
            FlightsResult flightsResult = new FlightsResult();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM FlightSearch WHERE SearchId='" + searchId + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                string apiResult = DecompressString(dr["ApiResult"].ToString());
                flightsResult = JsonConvert.DeserializeObject<FlightsResult>(apiResult);
            }

            return flightsResult;
        }

        public static FlightsBooking CheckFare(FlightsBooking flightsBooking)
        {
            FlightsBooking responseFlights = new FlightsBooking();
            responseFlights = flightsBooking;

            try
            {
                if (flightsBooking != null)
                {
                    string url = ApiURL + "flights/farecheck";
                    string serialisedData = JsonConvert.SerializeObject(flightsBooking);
                    WebClient webClient = new WebClient();
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = webClient.UploadString(url, serialisedData);

                    responseFlights = JsonConvert.DeserializeObject<FlightsBooking>(result.ToString());
                }
            }
            catch (Exception e)
            {
                responseFlights.FlightsFare = flightsBooking.Flights.FlightFare;
                responseFlights.TranscationStatus = e.Message.ToString();
            }
            return responseFlights;
        }

        public static FlightsBooking CheckFareMAN(FlightsBooking flightsBooking)
        {
            FlightsBooking responseFlights = new FlightsBooking();
            responseFlights = flightsBooking;

            try
            {
                if (flightsBooking != null)
                {
                    responseFlights.FlightsFare = flightsBooking.Flights.FlightFare;
                    responseFlights.TranscationStatus = "Connection error";
                }
            }
            catch (Exception e)
            {
                responseFlights.FlightsFare = flightsBooking.Flights.FlightFare;
                responseFlights.TranscationStatus = e.Message.ToString();
            }
            return responseFlights;
        }

        public static FlightsBooking BookFlight(FlightsBooking flightsBooking)
        {
            FlightsBooking responseFlights = new FlightsBooking();
            responseFlights = flightsBooking;

            try
            {
                if (flightsBooking != null)
                {
                    string url = ApiURL + "flights/bookflight";
                    string serialisedData = JsonConvert.SerializeObject(flightsBooking);
                    WebClient webClient = new WebClient();
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = webClient.UploadString(url, serialisedData);

                    responseFlights = JsonConvert.DeserializeObject<FlightsBooking>(result.ToString());
                }
            }
            catch (Exception)
            {
                responseFlights.TranscationStatus = "pnr error";
            }

            return responseFlights;
        }

        public static FlightsBooking GetFlightById(string fid)
        {
            FlightsBooking flightsBooking = new FlightsBooking();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM FlightsBooking WHERE TranscationId='" + fid + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                flightsBooking.Id = long.Parse(dr["Id"].ToString());
                flightsBooking.BookingId = dr["BookingId"].ToString();
                flightsBooking.SearchId = dr["SearchId"].ToString();
                flightsBooking.TranscationId = dr["TranscationId"].ToString();
                flightsBooking.PNRNo = dr["PNRNo"].ToString();
                flightsBooking.FullName = dr["FullName"].ToString();
                flightsBooking.Email = dr["Email"].ToString();
                flightsBooking.PhoneNo = dr["PhoneNo"].ToString();
                flightsBooking.FlightsSearch = JsonConvert.DeserializeObject<FlightsSearch>(dr["FlightsSearch"].ToString());
                flightsBooking.Flights = JsonConvert.DeserializeObject<Flights>(dr["Flights"].ToString());
                flightsBooking.BookerDetail = JsonConvert.DeserializeObject<BookerDetail>(dr["BookerDetail"].ToString());
                flightsBooking.PassengerDetail = JsonConvert.DeserializeObject<List<PassengerDetail>>(dr["PassengerDetail"].ToString());
                flightsBooking.PaymentDetail = JsonConvert.DeserializeObject<PaymentDetail>(dr["PaymentDetail"].ToString());
                flightsBooking.SagepayDetail = JsonConvert.DeserializeObject<SagepayDetail>(dr["SagepayDetail"].ToString());
                flightsBooking.SiteCode = dr["SiteCode"].ToString();
                flightsBooking.SourceMedia = dr["SourceMedia"].ToString();
                flightsBooking.FlightsFare = JsonConvert.DeserializeObject<FlightsFare>(dr["FlightsFare"].ToString());
                flightsBooking.PaymentStatus = dr["PaymentStatus"].ToString();
                flightsBooking.WorldResponse = dr["WorldResponse"].ToString();
                flightsBooking.IsHotel = dr["IsHotel"].ToString();
                flightsBooking.TranscationStatus = dr["TranscationStatus"].ToString();
                flightsBooking.Status = dr["Status"].ToString();
                flightsBooking.Timestamp = Convert.ToDateTime(dr["Timestamp"]);
                flightsBooking.BagPrice = JsonConvert.DeserializeObject<BagsPrice>(dr["BagsPrice"].ToString());
            }

            return flightsBooking;
        }

        public static FlightsBooking GetFlightByIdFlightoffice(string fid)
        {
            FlightsBooking flightsBooking = new FlightsBooking();

            DataSet ds = SqlHelper.ExecuteDatasetFlightoffice("SELECT * FROM FlightsBooking WHERE TranscationId='" + fid + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                flightsBooking.Id = long.Parse(dr["Id"].ToString());
                flightsBooking.BookingId = dr["BookingId"].ToString();
                flightsBooking.SearchId = dr["SearchId"].ToString();
                flightsBooking.TranscationId = dr["TranscationId"].ToString();
                flightsBooking.PNRNo = dr["PNRNo"].ToString();
                flightsBooking.FullName = dr["FullName"].ToString();
                flightsBooking.Email = dr["Email"].ToString();
                flightsBooking.PhoneNo = dr["PhoneNo"].ToString();
                flightsBooking.FlightsSearch = JsonConvert.DeserializeObject<FlightsSearch>(dr["FlightsSearch"].ToString());
                flightsBooking.Flights = JsonConvert.DeserializeObject<Flights>(dr["Flights"].ToString());
                flightsBooking.BookerDetail = JsonConvert.DeserializeObject<BookerDetail>(dr["BookerDetail"].ToString());
                flightsBooking.PassengerDetail = JsonConvert.DeserializeObject<List<PassengerDetail>>(dr["PassengerDetail"].ToString());
                flightsBooking.PaymentDetail = JsonConvert.DeserializeObject<PaymentDetail>(dr["PaymentDetail"].ToString());
                flightsBooking.SagepayDetail = JsonConvert.DeserializeObject<SagepayDetail>(dr["SagepayDetail"].ToString());
                flightsBooking.SiteCode = dr["SiteCode"].ToString();
                flightsBooking.SourceMedia = dr["SourceMedia"].ToString();
                flightsBooking.FlightsFare = JsonConvert.DeserializeObject<FlightsFare>(dr["FlightsFare"].ToString());
                flightsBooking.PaymentStatus = dr["PaymentStatus"].ToString();
                flightsBooking.WorldResponse = dr["WorldResponse"].ToString();
                flightsBooking.IsHotel = dr["IsHotel"].ToString();
                flightsBooking.TranscationStatus = dr["TranscationStatus"].ToString();
                flightsBooking.Status = dr["Status"].ToString();
                flightsBooking.Timestamp = Convert.ToDateTime(dr["Timestamp"]);
                flightsBooking.BagPrice = JsonConvert.DeserializeObject<BagsPrice>(dr["BagsPrice"].ToString());
            }

            return flightsBooking;
        }


        public static string GetTranscationId(string fid)
        {
            string TranscationId = "";
            DataSet ds = SqlHelper.ExecuteDatasetFlightoffice("SELECT * FROM FlightsBooking WHERE SearchId='" + fid + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                TranscationId = dr["TranscationId"].ToString();
            }
            return TranscationId;
        }
        public static Location GetLocation(string Code)
        {
            Location location = new Location();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM City WHERE TravellandaCityId='" + Code + "'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                location.CityId = dr["CityId"].ToString();
                location.TravellandaCityId = dr["TravellandaCityId"].ToString();
                location.CityName = dr["CityName"].ToString();
                location.StateCode = dr["StateCode"].ToString();
                location.StateName = dr["StateCode"].ToString();
                location.CountryCode = dr["CountryCode"].ToString();
                location.CountryName = dr["CountryName"].ToString();
                location.Latitude = "";
                location.Longtitude = "";
            }
            else
            {
                location.CityId = Code;
                location.CityName = Code;
                location.StateName = Code;
                location.CountryCode = Code;
                location.CountryName = Code;
                location.Latitude = "";
                location.Longtitude = "";
            }

            return location;
        }
        public static HotelsResult SearchHotel(HotelsSearch hotelSearch)
        {
            HotelsResult hotelsResult = new HotelsResult();

            try
            {
                if (hotelSearch != null)
                {
                    string url = ApiURL + "hotels/search";
                    string serialisedData = JsonConvert.SerializeObject(hotelSearch);
                    WebClient webClient = new WebClient();
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = webClient.UploadString(url, serialisedData);

                    hotelsResult = JsonConvert.DeserializeObject<HotelsResult>(result.ToString());
                }
            }
            catch (Exception e)
            {
                hotelsResult.Error = e.Message.ToString();
                hotelsResult.HotelsSearch = hotelSearch;
            }
            return hotelsResult;
        }
        public static HotelsResult FillHotelPrice(HotelsResult flight)
        {
            HotelsResult newHotel = new HotelsResult();
            newHotel.Error = flight.Error;
            newHotel.HotelsSearch = flight.HotelsSearch;
            newHotel.HotelsList = new List<Hotels>();
            newHotel.HotelsList.AddRange(flight.HotelsList);

            // min max count
            newHotel.MinPrice = (int)Math.Floor(flight.HotelsList.Min(f => f.PerNightPrice));
            newHotel.MaxPrice = (int)Math.Ceiling(flight.HotelsList.Max(f => f.PerNightPrice));

            // star rating
            List<Hotels> star1 = newHotel.HotelsList.Where(f => Convert.ToInt32(Math.Floor(Convert.ToDouble(f.StarRating))) == 1).OrderBy(f => f.LowestPrice).ToList();
            List<Hotels> star2 = newHotel.HotelsList.Where(f => Convert.ToInt32(Math.Floor(Convert.ToDouble(f.StarRating))) == 2).OrderBy(f => f.LowestPrice).ToList();
            List<Hotels> star3 = newHotel.HotelsList.Where(f => Convert.ToInt32(Math.Floor(Convert.ToDouble(f.StarRating))) == 3).OrderBy(f => f.LowestPrice).ToList();
            List<Hotels> star4 = newHotel.HotelsList.Where(f => Convert.ToInt32(Math.Floor(Convert.ToDouble(f.StarRating))) == 4).OrderBy(f => f.LowestPrice).ToList();
            List<Hotels> star5 = newHotel.HotelsList.Where(f => Convert.ToInt32(Math.Floor(Convert.ToDouble(f.StarRating))) == 5).OrderBy(f => f.LowestPrice).ToList();
            newHotel.StarExtra = new List<HotelsExtra>();
            newHotel.StarExtra.Add(new HotelsExtra() { TotalCount = (star1.Count == 0) ? 0 : star1.Count, ExtraType = "star1" });
            newHotel.StarExtra.Add(new HotelsExtra() { TotalCount = (star2.Count == 0) ? 0 : star2.Count, ExtraType = "star2" });
            newHotel.StarExtra.Add(new HotelsExtra() { TotalCount = (star3.Count == 0) ? 0 : star3.Count, ExtraType = "star3" });
            newHotel.StarExtra.Add(new HotelsExtra() { TotalCount = (star4.Count == 0) ? 0 : star4.Count, ExtraType = "star4" });
            newHotel.StarExtra.Add(new HotelsExtra() { TotalCount = (star5.Count == 0) ? 0 : star5.Count, ExtraType = "star5" });

            // boarding type, near by place
            newHotel.BoardType = new string[] { };
            newHotel.NearByLocation = new string[] { };
            foreach (Hotels item in newHotel.HotelsList)
            {
                if (item.OnBoardType != null && item.OnBoardType != "")
                    newHotel.BoardType = newHotel.BoardType.Concat(item.OnBoardType.Split(',').Select(f => f.Trim())).ToArray();
                if (item.NearByLocation != null && item.NearByLocation != "")
                    newHotel.NearByLocation = newHotel.NearByLocation.Concat(item.NearByLocation.Split(',').Select(f => f.Trim())).ToArray();

            }
            newHotel.BoardType = newHotel.BoardType.Distinct().ToArray();
            newHotel.NearByLocation = newHotel.NearByLocation.Distinct().ToArray();

            return newHotel;
        }
        public static string GetHotelBookingId(string pre = null)
        {
            string str = "";

            DataSet ds = SqlHelper.ExecuteDataset("SELECT TOP 1 * FROM HotelsBooking ORDER BY Id DESC", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                string max_id = (int.Parse(dr["Id"].ToString()) + 1) + "";

                str = pre + max_id.PadLeft(6, '0');
            }
            else
            {
                str = pre + "000001";
            }

            return str;
        }
        public static HotelsBooking CheckHotel(HotelsBooking hotelsBooking)
        {
            HotelsBooking responseHotels = new HotelsBooking();
            responseHotels = hotelsBooking;

            try
            {
                if (hotelsBooking != null)
                {
                    string url = ApiURL + "hotels/checkhotel";
                    string serialisedData = JsonConvert.SerializeObject(hotelsBooking);
                    WebClient webClient = new WebClient();
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = webClient.UploadString(url, serialisedData);

                    responseHotels = JsonConvert.DeserializeObject<HotelsBooking>(result.ToString());
                }
            }
            catch (Exception)
            {
                responseHotels.TranscationStatus = "error";
            }

            return responseHotels;
        }
        public static HotelsBooking GetHotelById(string fid)
        {
            HotelsBooking hotelsBooking = new HotelsBooking();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM HotelsBooking WHERE TranscationId='" + fid + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                hotelsBooking.Id = long.Parse(dr["Id"].ToString());
                hotelsBooking.BookingId = dr["BookingId"].ToString();
                hotelsBooking.SearchId = dr["SearchId"].ToString();
                hotelsBooking.TranscationId = dr["TranscationId"].ToString();
                hotelsBooking.PNRNo = dr["PNRNo"].ToString();
                hotelsBooking.FullName = dr["FullName"].ToString();
                hotelsBooking.Email = dr["Email"].ToString();
                hotelsBooking.PhoneNo = dr["PhoneNo"].ToString();
                hotelsBooking.HotelsSearch = JsonConvert.DeserializeObject<HotelsSearch>(dr["HotelsSearch"].ToString());
                hotelsBooking.Hotels = JsonConvert.DeserializeObject<Hotels>(dr["Hotels"].ToString());
                hotelsBooking.BookerDetail = JsonConvert.DeserializeObject<BookerDetail>(dr["BookerDetail"].ToString());
                hotelsBooking.PassengerDetail = JsonConvert.DeserializeObject<List<PassengerDetail>>(dr["PassengerDetail"].ToString());
                hotelsBooking.PaymentDetail = JsonConvert.DeserializeObject<PaymentDetail>(dr["PaymentDetail"].ToString());
                hotelsBooking.SagepayDetail = JsonConvert.DeserializeObject<SagepayDetail>(dr["SagepayDetail"].ToString());
                hotelsBooking.SiteCode = dr["SiteCode"].ToString();
                hotelsBooking.SourceMedia = dr["SourceMedia"].ToString();
                hotelsBooking.PaymentStatus = dr["PaymentStatus"].ToString();
                hotelsBooking.WorldResponse = dr["WorldResponse"].ToString();
                hotelsBooking.TranscationStatus = dr["TranscationStatus"].ToString();
                hotelsBooking.Status = dr["Status"].ToString();
                hotelsBooking.Timestamp = Convert.ToDateTime(dr["Timestamp"]);
            }

            return hotelsBooking;
        }
        public static HotelsBooking BookHotel(HotelsBooking hotelsBooking)
        {
            HotelsBooking responseHotels = new HotelsBooking();
            responseHotels = hotelsBooking;

            try
            {
                if (hotelsBooking != null)
                {
                    string url = ApiURL + "hotels/bookhotel";
                    string serialisedData = JsonConvert.SerializeObject(hotelsBooking);
                    WebClient webClient = new WebClient();
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = webClient.UploadString(url, serialisedData);

                    responseHotels = JsonConvert.DeserializeObject<HotelsBooking>(result.ToString());
                }
            }
            catch (Exception)
            {
                responseHotels.TranscationStatus = "pnr error";
            }

            return responseHotels;
        }
        public static string GetApiKey(string vendor)
        {
            string apikey = "";

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM ApiService WHERE VendorCode='" + vendor + "'", null);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                apikey = dr["ApiKey"].ToString();
            }

            return apikey;
        }

        public static Airport GetAirport(string Code)
        {
            Airport airport = new Airport();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM Airport WHERE Code='" + Code + "'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                airport.Code = dr["Code"].ToString();
                airport.Name = dr["Name"].ToString();
                airport.CityCode = dr["CityCode"].ToString();
                airport.CityName = dr["CityName"].ToString();
                airport.StateCode = dr["StateCode"].ToString();
                airport.StateName = dr["StateName"].ToString();
                airport.CountryCode = dr["CountryCode"].ToString();
                airport.CountryName = dr["CountryName"].ToString();
                airport.Continent = dr["Continent"].ToString();
                airport.Latitude = dr["Latitude"].ToString();
                airport.Longtitude = dr["Longtitude"].ToString();
            }
            else
            {
                airport.Code = Code;
                airport.Name = Code;
                airport.CityCode = Code;
                airport.CityName = Code;
                airport.StateCode = Code;
                airport.StateName = Code;
                airport.CountryCode = Code;
                airport.CountryName = Code;
                airport.Continent = Code;
                airport.Latitude = Code;
                airport.Longtitude = Code;
            }

            return airport;
        }

        public static Airline GetAirline(string Code)
        {
            Airline airline = new Airline();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM Airline WHERE Code='" + Code + "'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                airline.Code = dr["Code"].ToString();
                airline.Name = dr["Name"].ToString();
            }
            else
            {
                airline.Code = Code;
                airline.Name = Code;
            }

            return airline;
        }

        public static List<Airport> GetAllAirport(string str = null)
        {
            List<Airport> airport = new List<Airport>();
            string qry = "SELECT * FROM Airport";
            if (str != null && !str.Equals(""))
                qry = "SELECT * FROM Airport WHERE Code LIKE '" + str + "%' OR Name LIKE '" + str + "%' OR CityName LIKE '" + str + "%'";
            qry += " ORDER BY Code";

            DataSet ds = SqlHelper.ExecuteDataset(qry, null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    airport.Add(new Airport()
                    {
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString(),
                        CityCode = dr["CityCode"].ToString(),
                        CityName = dr["CityName"].ToString(),
                        StateCode = dr["StateCode"].ToString(),
                        StateName = dr["StateName"].ToString(),
                        CountryCode = dr["CountryCode"].ToString(),
                        CountryName = dr["CountryName"].ToString(),
                        Continent = dr["Continent"].ToString(),
                        Latitude = dr["Latitude"].ToString(),
                        Longtitude = dr["Longtitude"].ToString()
                    });
                }
            }

            return airport;
        }

        public static List<Airline> GetAllAirline()
        {
            List<Airline> airline = new List<Airline>();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM Airline ORDER BY Name", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    airline.Add(new Airline()
                    {
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString()
                    });
                }
            }

            return airline;
        }
        public static string ConvertJson(HotelsResult hotelResult)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

            return serializer.Serialize(hotelResult);
        }
        public static List<Country> GetAllCountry(string str = null)
        {
            List<Country> country = new List<Country>();
            string qry = "SELECT * FROM Country";
            if (str != null && !str.Equals(""))
                qry = "SELECT * FROM Country WHERE Code LIKE '" + str + "%' OR Name LIKE '" + str + "%'";
            qry += " ORDER BY Name";

            DataSet ds = SqlHelper.ExecuteDataset(qry, null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    country.Add(new Country()
                    {
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString()
                    });
                }
            }

            return country;
        }

        public static List<City> GetAllCity(string str = null)
        {
            List<City> city = new List<City>();
            string qry = "SELECT * FROM City";
            if (str != null && !str.Equals(""))
                qry = "SELECT * FROM City WHERE CityName LIKE '%" + str + "%'";
            qry += " ORDER BY CityName";

            DataSet ds = SqlHelper.ExecuteDataset(qry, null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    city.Add(new City()
                    {
                        TravellandaCityId = dr["TravellandaCityId"].ToString(),
                        CityName = dr["CityName"].ToString(),
                        StateCode = dr["StateCode"].ToString(),
                        CountryCode = dr["CountryCode"].ToString(),
                        CountryName = dr["CountryName"].ToString(),
                        SearchName = dr["SearchName"].ToString()
                    });
                }
            }

            return city;
        }

        public static string CompressString(string _content)
        {
            if (string.IsNullOrEmpty(_content))
                return string.Empty;

            MemoryStream memoryStream = null, outStream = null;
            GZipStream zip = null;

            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(_content);
                memoryStream = new MemoryStream();

                using (zip = new GZipStream(memoryStream, CompressionMode.Compress, true))
                {
                    zip.Write(buffer, 0, buffer.Length);
                }

                memoryStream.Position = 0;
                outStream = new MemoryStream();

                byte[] compressed = new byte[memoryStream.Length];
                memoryStream.Read(compressed, 0, compressed.Length);

                byte[] gzBuffer = new byte[compressed.Length + 4];
                Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
                Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
                return Convert.ToBase64String(gzBuffer);

            }
            finally
            {
                if (zip != null)
                {
                    zip.Dispose();
                    zip = null;
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                    memoryStream = null;
                }

                if (outStream != null)
                {
                    outStream.Dispose();
                    outStream = null;
                }
            }
        }

        public static string DecompressString(string _content)
        {
            if (string.IsNullOrEmpty(_content))
                return string.Empty;

            GZipStream zip = null;
            MemoryStream memoryStream = null;

            try
            {
                byte[] gzBuffer = Convert.FromBase64String(_content);
                memoryStream = new MemoryStream();

                int contentLength = BitConverter.ToInt32(gzBuffer, 0);
                memoryStream.Write(gzBuffer, 4, gzBuffer.Length - 4);

                byte[] buffer = new byte[contentLength];

                memoryStream.Position = 0;
                zip = new GZipStream(memoryStream, CompressionMode.Decompress);

                zip.Read(buffer, 0, buffer.Length);

                return Encoding.UTF8.GetString(buffer);
            }
            catch (FormatException)
            {
                return _content;
            }
            finally
            {
                if (zip != null)
                {
                    zip.Dispose();
                    zip = null;
                }

                if (memoryStream != null)
                {
                    memoryStream.Dispose();
                    memoryStream = null;
                }
            }
        }

        public static List<FilterResult> FilterFlight(FlightsResult flight)
        {
            List<FilterResult> filterSegment = new List<FilterResult>();

            foreach (Flights flightItem in flight.FlightsList)
            {
                List<FilterSegment> outboundFilter = new List<FilterSegment>();
                List<FilterSegment> inboundFilter = new List<FilterSegment>();

                foreach (List<FlightsSegment> outbound in flightItem.OutboundList)
                {
                    outboundFilter.Add(new FilterSegment()
                    {
                        Stops = (outbound.Count - 1),
                        PlaneTime = int.Parse(outbound[0].DepartureDate.ToString("HHmm"))
                    });
                }
                if (flight.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                {
                    foreach (List<FlightsSegment> inbound in flightItem.InboundList)
                    {
                        inboundFilter.Add(new FilterSegment()
                        {
                            Stops = (inbound.Count - 1),
                            PlaneTime = int.Parse(inbound[0].DepartureDate.ToString("HHmm"))
                        });
                    }
                }

                filterSegment.Add(new FilterResult()
                {
                    Price = float.Parse(flightItem.TotalCost.ToString("0.00")),
                    Airline = flightItem.Airline.Code,
                    OutboundFilter = outboundFilter,
                    InboundFilter = inboundFilter
                });
            }

            return filterSegment;
        }

        public static FlightsResult FillFlightPrice(FlightsResult flight)
        {
            FlightsResult newFlight = new FlightsResult();
            newFlight.Error = flight.Error;
            newFlight.FlightsSearch = flight.FlightsSearch;
            newFlight.FlightsList = new List<Flights>();
            newFlight.FlightsList.AddRange(flight.FlightsList);
            // remove phone deal from operation
            List<Flights> dealFlights = newFlight.FlightsList.Where(f => f.IsDeal == true).ToList();
            foreach (Flights dealFlight in dealFlights)
            {
                newFlight.FlightsList.Remove(dealFlight);
            }

            // min max count
            newFlight.MinPrice = (int)Math.Floor(flight.FlightsList.Min(f => f.TotalCost));
            newFlight.MaxPrice = (int)Math.Floor(flight.FlightsList.Max(f => f.TotalCost));

            // stop counts
            List<Flights> nonStop = newFlight.FlightsList.Where(f => f.Stops == 0).OrderBy(f => f.TotalCost).ToList();
            List<Flights> oneStop = newFlight.FlightsList.Where(f => f.Stops == 1).OrderBy(f => f.TotalCost).ToList();
            List<Flights> twoStop = newFlight.FlightsList.Where(f => f.Stops >= 2).OrderBy(f => f.TotalCost).ToList();
            newFlight.StopExtra = new List<FlightsExtra>();
            newFlight.StopExtra.Add(new FlightsExtra() { TotalCost = (nonStop.Count == 0) ? 0 : (int)Math.Floor(nonStop.Min(f => f.TotalCost)), FlightId = (nonStop.Count == 0) ? "" : nonStop[0].FlightId, ExtraType = "nonstop" });
            newFlight.StopExtra.Add(new FlightsExtra() { TotalCost = (oneStop.Count == 0) ? 0 : (int)Math.Floor(oneStop.Min(f => f.TotalCost)), FlightId = (oneStop.Count == 0) ? "" : oneStop[0].FlightId, ExtraType = "onestop" });
            newFlight.StopExtra.Add(new FlightsExtra() { TotalCost = (twoStop.Count == 0) ? 0 : (int)Math.Floor(twoStop.Min(f => f.TotalCost)), FlightId = (twoStop.Count == 0) ? "" : twoStop[0].FlightId, ExtraType = "twostop" });

            // top bar counts
            Flights cheapest = newFlight.FlightsList.OrderBy(f => f.TotalCost).FirstOrDefault();
            Flights shortest = newFlight.FlightsList.OrderBy(f => f.TotalTime).FirstOrDefault();
            Flights best = newFlight.FlightsList.OrderBy(f => f.TotalCost).FirstOrDefault();
            newFlight.BarExtra = new List<FlightsExtra>();
            newFlight.BarExtra.Add(new FlightsExtra() { TotalCost = cheapest.TotalCost, TotalTime = cheapest.TotalTime, Airline = cheapest.Airline, TotalStop = cheapest.Stops, FlightId = cheapest.FlightId, ExtraType = "cheapest" });
            newFlight.BarExtra.Add(new FlightsExtra() { TotalCost = shortest.TotalCost, TotalTime = shortest.TotalTime, Airline = shortest.Airline, TotalStop = shortest.Stops, FlightId = shortest.FlightId, ExtraType = "shortest" });
            newFlight.BarExtra.Add(new FlightsExtra() { TotalCost = best.TotalCost, TotalTime = best.TotalTime, Airline = best.Airline, TotalStop = best.Stops, FlightId = best.FlightId, ExtraType = "best" });

            // airline counts
            List<Flights> airlineList = newFlight.FlightsList.GroupBy(f => f.Airline.Code).Select(g => g.FirstOrDefault()).ToList();
            newFlight.AirlineExtra = new List<FlightsExtra>();
            foreach (Flights item in airlineList)
            {
                newFlight.AirlineExtra.Add(new FlightsExtra() { TotalCost = item.TotalCost, TotalTime = item.TotalTime, Airline = item.Airline, TotalStop = item.Stops, ExtraType = item.Airline.Code });
            }
            newFlight.AirlineExtra.OrderBy(f => f.TotalCost).ToList();

            List<Flights> newFlightList = new List<Flights>();
            newFlightList.AddRange(newFlight.FlightsList);
            var priorityAirlines = new List<string> { "AM", "EK", "ET", "CM" };
            // Codes: Aero Mexico = AM, Emirates = EK, Ethiopian = ET, Copa = CM

            newFlight.FlightsList = newFlightList
                .OrderBy(f => priorityAirlines.Contains(f.Airline.Code) ? 0 : 1) // put priority first
                .ThenBy(f => f.TotalCost) // then sort by cost
                .ToList();

            //return newFlight;

            // mearge flight segment list
            //List<Flights> newFlightList = new List<Flights>();
            //List<List<Flights>> mergeList = newFlight.FlightsList.GroupBy(f => new { f.TotalCost, f.Airline.Code }).Select(g => g.ToList()).ToList();
            //foreach (List<Flights> itemList in mergeList)
            //{
            //    Flights flightItem = itemList[0];
            //    List<string> outboundOption = new List<string>();
            //    List<string> inboundOption = new List<string>();
            //    flightItem.OutboundList = new List<List<FlightsSegment>>();
            //    flightItem.InboundList = new List<List<FlightsSegment>>();

            //    foreach (Flights item in itemList)
            //    {
            //        if (!outboundOption.Contains(string.Join(",", item.Outbound.Select(a => a.SagementRef))))
            //        {
            //            outboundOption.Add(string.Join(",", item.Outbound.Select(a => a.SagementRef)));
            //            flightItem.OutboundList.Add(item.Outbound);
            //        }
            //        if (newFlight.FlightsSearch.FlightWay == FlightWay.RoundTrip && !inboundOption.Contains(string.Join(",", item.Inbound.Select(a => a.SagementRef))))
            //        {
            //            inboundOption.Add(string.Join(",", item.Inbound.Select(a => a.SagementRef)));
            //            flightItem.InboundList.Add(item.Inbound);
            //        }
            //    }
            //    newFlightList.Add(flightItem);
            //}

            //// add deal flights
            //foreach (Flights dealFlight in dealFlights)
            //{
            //    dealFlight.OutboundList = new List<List<FlightsSegment>>();
            //    dealFlight.InboundList = new List<List<FlightsSegment>>();
            //    dealFlight.OutboundList.Add(dealFlight.Outbound);
            //    dealFlight.InboundList.Add(dealFlight.Inbound);
            //    newFlightList.Add(dealFlight);
            //}

            //newFlight.FlightsList = newFlightList.OrderBy(f => f.TotalCost).ToList();

            return newFlight;
        }

        public static void WriteLog(string provider, string flightSearch, string apiRequest, string apiResponse)
        {
            try
            {
                string filename = "FileSearch-" + DateTime.Now.ToString("ddMMyyyy");
                StringBuilder logMessage = new StringBuilder();
                logMessage.Append(Environment.NewLine + Environment.NewLine + "---------------------------Flight Search Request-------------------------" + Environment.NewLine);
                logMessage.Append(flightSearch);
                logMessage.Append(Environment.NewLine + Environment.NewLine + "-----------------------------API Send Request----------------------------" + Environment.NewLine);
                logMessage.Append(apiRequest);
                logMessage.Append(Environment.NewLine + Environment.NewLine + "------------------------------API Get Request----------------------------" + Environment.NewLine);
                logMessage.Append(apiResponse);

                using (StreamWriter txtWriter = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + "\\Media\\Log\\" + provider + "\\" + filename + ".txt"))
                {
                    txtWriter.WriteLine("{0}", logMessage);
                }
            }
            catch (Exception)
            {
            }
        }

        public static void WriteLog(string fileName, string data)
        {
            string dt = DateTimeOffset.Now.ToString("ddMMyyyy");

            string filePath = "C:\\Logs\\" + fileName + ".txt";

            using (FileStream fs = System.IO.File.Create(filePath))
            {
                byte[] info = new System.Text.UTF8Encoding(true).GetBytes(data);
                fs.Write(info, 0, info.Length);
            }
        }



        public static List<MetaAirport> GetAllDetail(string country, string url)
        {
            List<MetaAirport> ContinentList = new List<MetaAirport>();

            DataSet ds = new DataSet();

            DataSet dsCode = new DataSet();
            string strURL = "";
            string ContCode = "";
            string Continent = "";
            if (url != null && url.ToLower() == "flights-to-usa-")
            {
                strURL = "flights-to-usa";
            }
            else
            {
                strURL = url;
            }
            dsCode = SqlHelper.ExecuteDataset("select Distinct Code,CountryCode,CountryName,Continent,ImagePath from  metaAirport where Slug='" + strURL + "'", null);


            ContCode = dsCode.Tables[0].Rows[0]["CountryName"].ToString();
            Continent = dsCode.Tables[0].Rows[0]["Continent"].ToString();
            if (country == null && url == null)
            {
                ds = SqlHelper.ExecuteDataset("select * from [dbo].[MetaAirport] where Code='Continent' and  isnull(Slug,'') !=''", null);
            }
            if (country == null && url != null && ContCode == "")
            {
                ds = SqlHelper.ExecuteDataset("select Slug,CountryName  Continent,ImagePath from [dbo].[MetaAirport] where Code='Conuntry' and Continent='" + Continent + "'  ", null);
            }


            if (country == null && ContCode != "" && Continent != "")
            {
                ds = SqlHelper.ExecuteDataset("select Slug,CityName  Continent,ImagePath from [dbo].[MetaAirport] where Code='City' and CountryName='" + ContCode + "'  ", null);
            }

            if (country != null && url != null)
            {
                ds = SqlHelper.ExecuteDataset("select Slug,CityName  Continent,ImagePath from [dbo].[MetaAirport] where Code='City' and CountryName= '" + country + "'", null);
            }

            //if (ds != null && ds.Tables[0].Rows.Count == 0)
            //{
            //    ds = SqlHelper.ExecuteDataset("select Slug,CityName  Continent,ImagePath  from [dbo].[MetaAirport] where Code='city' and CountryName=REPLACE('" + url + "','-',' ')", null);
            //}

            //if (ds != null && ds.Tables[0].Rows.Count == 0)
            //{
            //    ds = SqlHelper.ExecuteDataset("Select Slug,CityName  Continent,ImagePath from metaAirport where CountryCode= '" + ContCode + "'", null);
            //}

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ContinentList.Add(new MetaAirport()
                    {
                        Continent = dr["Continent"].ToString(),
                        Slug = dr["Slug"].ToString(),
                        ImagePath = dr["ImagePath"].ToString(),
                        CountryCode = ContCode,
                    });
                }
            }
            return ContinentList;
        }


        public static List<MetaAirport> GetAllDeals(string country, string url)
        {
            List<MetaAirport> ContinentList = new List<MetaAirport>();

            DataSet ds = new DataSet();

            if (country == null && url == null)
            {
                ds = SqlHelper.ExecuteDataset(" Select * from  [dbo].[HolidayDeals]  ", null);
            }
            if (country == null && url != null)
            {
                //ds = SqlHelper.ExecuteDataset("Select * from  [dbo].[HolidayDeals]  where Slug='" + url + "'", null);
                ds = SqlHelper.ExecuteDataset("Select * from  [dbo].[HolidayDeals] ", null);
            }
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ContinentList.Add(new MetaAirport()
                    {
                        Continent = dr["Name"].ToString(),
                        Slug = dr["Slug"].ToString(),
                        ImagePath = dr["ImagePath"].ToString()
                    });
                }
            }
            return ContinentList;
        }


        public static List<MetaAirport> GetAllDealsDescription(string country, string url)
        {
            List<MetaAirport> ContinentList = new List<MetaAirport>();

            DataSet ds = new DataSet();

            if (country == null && url == null)
            {
                ds = SqlHelper.ExecuteDataset("Select top 1 * from  [dbo].[HolidayDeals] ", null);
            }

            if (country == null && url != null)
            {
                ds = SqlHelper.ExecuteDataset("Select * from  [dbo].[HolidayDeals]  where Slug='" + url + "'", null);
            }
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ContinentList.Add(new MetaAirport()
                    {
                        Continent = dr["Name"].ToString(),
                        Slug = dr["Slug"].ToString(),
                        Description = dr["Description"].ToString(),
                        ImagePath = dr["ImagePath"].ToString(),
                    });
                }
            }
            return ContinentList;
        }


        public static List<MetaAirport> GetFlightDescription(string country, string url)
        {
            List<MetaAirport> ContinentList = new List<MetaAirport>();

            DataSet ds = new DataSet();

            DataSet dsCode = new DataSet();

            string ContCode = "";
            string Continent = "";

            dsCode = SqlHelper.ExecuteDataset("select Distinct Code,CountryCode,CountryName,Continent,ImagePath from  metaAirport where Slug='" + url + "'", null);

            ContCode = dsCode.Tables[0].Rows[0]["CountryName"].ToString();
            Continent = dsCode.Tables[0].Rows[0]["Continent"].ToString();

            if (country == null && url == null)
            {
                ds = SqlHelper.ExecuteDataset("Select top 1 * from  [dbo].[MetaAirport] ", null);
            }

            if (country == null && url != null)
            {
                ds = SqlHelper.ExecuteDataset("select * from  MetaAirport where Slug='" + url + "'", null);
            }

            if (country != null && url != null)
            {
                ds = SqlHelper.ExecuteDataset("select * from  MetaAirport where Slug='" + url + "'", null);
            }

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ContinentList.Add(new MetaAirport()
                    {

                        Continent = dr["Name"].ToString(),
                        Slug = dr["Slug"].ToString(),
                        Description = dr["Description"].ToString(),
                        ImagePath = dr["ImagePath"].ToString(),
                    });
                }
            }
            return ContinentList;
        }


        public static List<MetaAirport> GetAllContinent()
        {
            List<MetaAirport> ContinentList = new List<MetaAirport>();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT DISTINCT Continent,Slug FROM MetaAirport where CountryName is null and isnull(Continent,'')<>''", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ContinentList.Add(new MetaAirport()
                    {
                        Continent = dr["Continent"].ToString(),
                        Slug = dr["Slug"].ToString(),

                    });
                }
            }

            return ContinentList;
        }

        public static List<MetaAirport> GetAllContry(string Contry)
        {
            List<MetaAirport> ContrytList = new List<MetaAirport>();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT * FROM MetaAirport where CountryName is not null and REPLACE(Continent,' ','-')='" + Contry + "' and isnull(Continent,'')<>'' and CountryCode is null", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ContrytList.Add(new MetaAirport()
                    {
                        Continent = dr["CountryName"].ToString(),
                        Slug = dr["Slug"].ToString(),
                    });
                }
            }

            return ContrytList;
        }

        public static List<MetaAirport> GetAllCityName(string City)
        {
            List<MetaAirport> ContinentList = new List<MetaAirport>();

            DataSet ds = SqlHelper.ExecuteDataset("SELECT DISTINCT Continent,Slug FROM MetaAirport where CountryName is null and isnull(Continent,'')<>''", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ContinentList.Add(new MetaAirport()
                    {
                        Continent = dr["Continent"].ToString(),
                        Slug = dr["Slug"].ToString(),
                    });
                }
            }

            return ContinentList;
        }







        public static DataTable SelectContinent()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct continent from  destinations", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }
        public static DataTable SelectCountry()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Africa'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountryAsia()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Asia'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }


        public static DataTable SelectCountryAustralasia()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Australasia'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountryCaribbean()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Caribbean'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountryCentralAmerica()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Central America'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }


        public static DataTable SelectCountryEurope()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Europe'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountryFarEast()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Far East'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountryMiddleEast()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Middle East'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountryNorthAmerica()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='North America'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountryPacific()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='Pacific'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCountrySouthAmerica()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct Country from  destinations where continent='South America'", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }

        public static DataTable SelectCity()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct City from  destinations", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }
        public static DataTable SelectAirport()
        {
            DataTable Table = new DataTable();
            DataSet ds = SqlHelper.ExecuteDataset("Select distinct airport_code from  destinations", null);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Table = ds.Tables[0];
            }
            return Table;
        }
    }

    public class Country
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class City
    {
        public long Id { get; set; }
        public string TravellandaCityId { get; set; }
        public string CityName { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string SearchName { get; set; }
    }


    public class State
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }


}