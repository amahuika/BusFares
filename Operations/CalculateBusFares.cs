namespace BusFares.Operations
{
    public class CalculateBusFares
    {

        public void CalcFare(string name, bool disabled, double age, List<string> results, double ashPrice, double timPrice, double invPrice, double dunPrice, double omaPrice, double discount)
        {

            if (disabled || age > 64 || age < 12)
            {
                ashPrice = ashPrice - (ashPrice / 100 * discount);
                timPrice = timPrice - (timPrice / 100 * discount);
                invPrice = invPrice - (invPrice / 100 * discount);
                dunPrice = dunPrice - (dunPrice / 100 * discount);
                omaPrice = omaPrice - (omaPrice / 100 * discount);

            }

            BusFareResultsAll.AllResults.Add($"Name: {name} Age: {age} Ash: {ashPrice:C} Tim: {timPrice:C} Oma: {omaPrice:C} Dun: {dunPrice:C} Inv: {invPrice:C}");

            results.AddRange(BusFareResultsAll.AllResults);

            results.Reverse();


        }
    }
}
