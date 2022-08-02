using BusFares.BusFareDTO;
using BusFares.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusFares.Pages
{

    public class IndexModel : PageModel
    {

        [BindProperty]
        public BusDTO busDTO { get; set; } = new BusDTO();
        public void OnPost()
        {
            CalculateBusFares Calc = new CalculateBusFares();

           Calc.CalcFare(busDTO.Name, busDTO.Disabled, busDTO.Age, busDTO.Results, busDTO.AshburtonPrice, busDTO.TimaruPrice, busDTO.InvercargillPrice, busDTO.DunedinPrice, busDTO.OmaruPrice, busDTO.Discount);

        }



        public void OnGet()
        {

        }
    }
}