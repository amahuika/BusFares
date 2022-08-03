using BusFares.BusFareDTO;
using BusFares.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusFares.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        public BusDTO busDTO = new BusDTO();

        public List<string> Results = new List<string>();

        public void OnPost(BusDTO busDTO)
        {
            CalculateBusFares Calc = new CalculateBusFares();

            Results.AddRange(Calc.CalcFare(busDTO));

        }



        public void OnGet()
        {

        }
    }
}