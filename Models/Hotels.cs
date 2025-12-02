using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viman.Models
{
    public class Hotels
    {
        public string Provider { get; set; }
        public string HotelId { get; set; }
        public string HotelName { get; set; }
        public string StarRating { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public float PerNightPrice { get; set; }
        public float LowestPrice { get; set; }
        public string OnBoardType { get; set; }
        public string NearByLocation { get; set; }
        public string NearByDistance { get; set; }
        public string SessionId { get; set; }
        public bool IsGym { get; set; }
        public bool IsSmoking { get; set; }
        public bool IsResturant { get; set; }
        public bool IsAir { get; set; }
        public bool IsWifi { get; set; }
        public bool IsBar { get; set; }
        public bool IsCoffee { get; set; }
        public bool Is24Hours { get; set; }
        public HotelsSearch HotelSearch { get; set; }
        public List<HotelsImage> HotelImage { get; set; }
        public List<HotelsFacility> HotelFacility { get; set; }
        public List<HotelsOptions> HotelOption { get; set; }
    }

    public class HotelsImage
    {
        public string Image { get; set; }
    }

    public class HotelsFacility
    {
        public string FacilityType { get; set; }
        public string FacilityName { get; set; }
    }

    public class HotelsOptions
    {
        public string OptionId { get; set; }
        public string BoardType { get; set; }
        public string TotalPrice { get; set; }
        public string DiscountApplied { get; set; }
        public string DealName { get; set; }
        public string OnRequest { get; set; }
        public string CancellationDeadline { get; set; }
        public List<HotelsRooms> HotelRoom { get; set; }
    }

    public class HotelsRooms
    {
        public string RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomImage { get; set; }
        public string NoAdults { get; set; }
        public string NoChilds { get; set; }
        public string RoomPrice { get; set; }
        public string DailyPrice { get; set; }
    }

    public class HotelsSearch
    {
        public long Id { get; set; }
        public string SearchId { get; set; }
        public string TranId { get; set; }
        public Location Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Rooms { get; set; }
        public string[] Adults { get; set; }
        public string[][] Childs { get; set; }
        public string Nationality { get; set; }
        public string Currency { get; set; }
        public string SiteCode { get; set; }
        public string SourceMedia { get; set; }
        public bool IsAvilableOnly { get; set; }
        public bool IsDeepLink { get; set; }
        public string ApiKey { get; set; }
    }

    public class HotelsResult
    {
        public string Error { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public List<HotelsExtra> StarExtra { get; set; }
        public string[] BoardType { get; set; }
        public string[] NearByLocation { get; set; }
        public HotelsSearch HotelsSearch { get; set; }
        public List<Hotels> HotelsList { get; set; }
    }

    public class HotelsExtra
    {
        public int TotalCount { get; set; }
        public string ExtraType { get; set; }
    }

    public class HotelPolicies
    {
        public string CancellationDeadline { get; set; }
        public List<string> Restrictions { get; set; }
        public List<string> Alerts { get; set; }
        public List<HotelPolicy> Policies { get; set; }
    }

    public class HotelPolicy
    {
        public string PolicyFrom { get; set; }
        public string PolicyType { get; set; }
        public string PolicyValue { get; set; }
    }

    public class HotelsBooking
    {
        public long Id { get; set; }
        public long FlightBookingId { get; set; }
        public string SearchId { get; set; }
        public string BookingId { get; set; }
        public string TranscationId { get; set; }
        public string PNRNo { get; set; }
        public string HotelBookingRef { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public HotelsSearch HotelsSearch { get; set; }
        public Hotels Hotels { get; set; }
        public HotelPolicies HotelPolicies { get; set; }
        public BookerDetail BookerDetail { get; set; }
        public List<PassengerDetail> PassengerDetail { get; set; }
        public PaymentDetail PaymentDetail { get; set; }
        public SagepayDetail SagepayDetail { get; set; }
        public string SiteCode { get; set; }
        public string SourceMedia { get; set; }
        public string SupplierCode { get; set; }
        public decimal SupplierFare { get; set; }
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

    public class Location
    {
        public string CityId { get; set; }
        public string TravellandaCityId { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}