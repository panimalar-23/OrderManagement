
namespace OrderManagement
{
    public class OrderService
    {
        public decimal CalculateOrderTotal()
        {
            decimal itemPrice = 500.00m;
            int quantity = 3;
            decimal shippingCharge = 50.00m;

            decimal total = (itemPrice * quantity) + shippingCharge;

            return total;
        }
        public double CalculateDiscount(double total)
        {
            return total * 0.10;
        }
    }
}
