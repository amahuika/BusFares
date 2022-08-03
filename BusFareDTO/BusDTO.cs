using System.ComponentModel.DataAnnotations;

namespace BusFares.BusFareDTO
{
    public class BusDTO
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int Age { get; set; }
        [Display(Name = "Are you disabled?")]
        public bool Disabled { get; set; }

        public double Discount { get; set; } = 0.20;

        [Display(Name = "Ash")]
        public double AshburtonPrice { get; set; } = 17.99;

        [Display(Name = "Tim")]
        public double TimaruPrice { get; set; } = 24.77;
        [Display(Name = "Oma")]
        public double OmaruPrice { get; set; } = 24.44;

        [Display(Name = "Dun")]
        public double DunedinPrice { get; set; } = 35.66;
        [Display(Name = "Inv")]
        public double InvercargillPrice { get; set; } = 46.50;




    }
}
