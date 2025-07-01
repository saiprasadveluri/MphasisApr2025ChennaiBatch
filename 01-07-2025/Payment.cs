using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Models
{
    public class AllPayments
    {
        [Required(ErrorMessage = "Please select a payment type.")]
        public string SelectedPaymentType { get; set; }

        public Payment Payment { get; set; }
        public Upi Upi { get; set; }
        public Card Card { get; set; }

        public AllPayments()
        {
            Payment = new Payment();
            Upi = new Upi();
            Card = new Card();
        }
    }
}
