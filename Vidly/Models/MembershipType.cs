namespace Vidly.Models
{
    public class MembershipType
    {
      
        public byte Id { get; set; }
        public decimal SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set;}

    }
}