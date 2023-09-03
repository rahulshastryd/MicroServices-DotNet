namespace Mango.Services.CouponAPI.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string CouponCodes { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
