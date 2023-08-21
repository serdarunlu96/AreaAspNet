using AreaAspNet.Areas.Admin.Data;
using AreaAspNet.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace AreaAspNet.Areas.Admin.Controllers
{
    public class TurkiyeController : Controller
    {
        [Area("Admin")]
        public IActionResult Sehirler()
        {
            List<SehirViewModel> sehirler = Veri.Sehirler()
                    .Select(x => new SehirViewModel()
                    {
                        Id = x.Id,
                        SehirAd = x.SehirAd,
                        BolgeAd = Veri.Bolgeler().First(b=>b.Id==x.BolgeId).BolgeAd,
                        Nufus = x.Nufus
                    })
                    .ToList();

            return View(sehirler);
        }
    }
}
