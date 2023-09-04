using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class TinhLuongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(string Luong, string Heso, string Pcap)
        {
            double luongnv, lcb = 0, hs = 0, pc = 0;
            string ketqua;


            if (!String.IsNullOrEmpty(Luong)) lcb = Convert.ToDouble(Luong);
            if (!String.IsNullOrEmpty(Heso)) hs = Convert.ToDouble(Heso);
            if (!String.IsNullOrEmpty(Pcap)) pc = Convert.ToDouble(Pcap);

            luongnv = (lcb * hs) + pc;

            ketqua = "Muc luong hien tai cua ban la " + luongnv ;

            ViewBag.tinhluong = ketqua;
            return View();

        }


    }
}