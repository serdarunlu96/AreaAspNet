namespace AreaAspNet.Areas.Admin.Models
{
    public class SehirViewModel
    {
        public int Id { get; set; }
        public string BolgeAd { get; set; } = null!;
        public string SehirAd { get; set; } = null!;
        public int Nufus { get; set; }
    }
}
