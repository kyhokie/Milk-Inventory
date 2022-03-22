namespace MilkInventory2
{
    public class MilkInventory
    {
        public int Amount { get; set; }
        
        public int GetInventory()
        {
            return Amount;
        }

        public int Withdraw(int amountToWithdraw)
        {
            Amount -= amountToWithdraw;

            return Amount;
        }

        public int Add(int amountToAdd)
        {
            Amount += amountToAdd;

            Amount;
        }

        //MilkInventory()
        //{
        //}
    }
}