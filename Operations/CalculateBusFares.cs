using BusFares.BusFareDTO;

namespace BusFares.Operations
{
    public class CalculateBusFares
    {

        public List<string> CalcFare(BusDTO busDTO)
        {

            if (busDTO.Disabled || busDTO.Age > 64 || busDTO.Age < 12)
            {
                busDTO.AshburtonPrice = CalcDiscount(busDTO.AshburtonPrice, busDTO.Discount);
                busDTO.TimaruPrice = CalcDiscount(busDTO.TimaruPrice, busDTO.Discount);
                busDTO.InvercargillPrice = CalcDiscount(busDTO.InvercargillPrice, busDTO.Discount);
                busDTO.DunedinPrice = CalcDiscount(busDTO.DunedinPrice, busDTO.Discount);
                busDTO.OmaruPrice = CalcDiscount(busDTO.OmaruPrice, busDTO.Discount);

            }

            BusFareResultsAll.AllResults.Add($"Name: {busDTO.Name} Age: {busDTO.Age} Ash: {busDTO.AshburtonPrice:C} Tim: {busDTO.TimaruPrice:C} Oma: {busDTO.OmaruPrice:C} Dun: {busDTO.DunedinPrice:C} Inv: {busDTO.InvercargillPrice:C}");

            return BusFareResultsAll.AllResults;

        }

        private double CalcDiscount(double price, double discount)
        {
            price = price - (price * discount);

            return price;
        }
    }
}
