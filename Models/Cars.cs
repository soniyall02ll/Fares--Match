using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viman.Models
{
    public class Cars
    {
        public string Provider { get; set; }
        public string CarId { get; set; }
        public string SessionId { get; set; }
        public string Sipp { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
        public int LargeBag { get; set; }
        public int SmallBag { get; set; }
        public bool HasAircondition { get; set; }
        public string Transmission { get; set; }
        public bool OnRequest { get; set; }
        public double NetCost { get; set; }
        public double DropCharge { get; set; }
        public double TotalCost { get; set; }
        public string RateType { get; set; }
        public string SupplierRateType { get; set; }
        public string AchRateType { get; set; }
        public string ValueAdd { get; set; }
        public string DeepLink { get; set; }
        public List<string> Extras { get; set; }
        public List<string> Charges { get; set; }
        public string Supplier { get; set; }
        public CarLocation PickupLocation { get; set; }
        public CarLocation DropoffLocation { get; set; }
        public List<CarsTerms> CarsTerms { get; set; }
        public List<CarsExtras> XsellLocal { get; set; }
        public List<CarsExtras> XsellExtra { get; set; }
    }

    public class CarsTerms
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class CarsExtras
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double Net { get; set; }
        public double Gross { get; set; }
        public string Description { get; set; }
        public bool IsSelect { get; set; }
    }

    public class CarsFare
    {
        public double CarTotal { get; set; }
        public double CarServiceCharge { get; set; }
        public double CarAtol { get; set; }
        public double CarAdditional { get; set; }
        public double CarOtherAtol { get; set; }
        public double CarCardCharge { get; set; }
        public double CarPnrCharge { get; set; }
    }

    public class CarsSearch
    {
        public long Id { get; set; }
        public string SearchId { get; set; }
        public string TranId { get; set; }
        public CarLocation FromLocation { get; set; }
        public CarLocation ToLocation { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime DropoffDate { get; set; }
        public int DriverAge { get; set; }
        public bool AvailableOnly { get; set; }
        public string Currency { get; set; }
        public string SiteCode { get; set; }
        public string SourceMedia { get; set; }
        public bool IsDeepLink { get; set; }
        public string ApiKey { get; set; }
    }

    public class CarLocation
    {
        public string LocationId { get; set; }
        public string LocationCode { get; set; }
        public string LocationType { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
    }

    public class CarsResult
    {
        public string Error { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public List<string> Supplier { get; set; }
        public CarsSearch CarsSearch { get; set; }
        public List<Cars> CarsList { get; set; }
    }

    public class CarsBooking
    {
        public long Id { get; set; }
        public long FlightBookingId { get; set; }
        public string SearchId { get; set; }
        public string BookingId { get; set; }
        public string TranscationId { get; set; }
        public string PNRNo { get; set; }
        public string CarBookingRef { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public CarsSearch CarsSearch { get; set; }
        public Cars Cars { get; set; }
        public BookerDetail BookerDetail { get; set; }
        public List<PassengerDetail> PassengerDetail { get; set; }
        public CarsFare CarsFare { get; set; }
        public PaymentDetail PaymentDetail { get; set; }
        public SagepayDetail SagepayDetail { get; set; }
        public string SiteCode { get; set; }
        public string SourceMedia { get; set; }
        public string SupplierCode { get; set; }
        public CarsFare SupplierFare { get; set; }
        public string SupplierStatus { get; set; }
        public string SupplierComment { get; set; }
        public string AgentCode { get; set; }
        public string AgentStatus { get; set; }
        public string AgentComment { get; set; }
        public string AdminStatus { get; set; }
        public string AdminComment { get; set; }
        public string PaymentStatus { get; set; }
        public string WorldResponse { get; set; }
        public string TranscationStatus { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}