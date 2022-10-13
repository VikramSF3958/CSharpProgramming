
namespace FoodDelivery
{
    public interface IBalance
    {
        double Balance { get; set; }

        void WalletRecharge(double amount);


    }
}