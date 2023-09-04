using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class GiaiPTController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(string hsoA, string hsoB, string hsoC)
        {
            double delta, x1, x2, a = 0, b = 0, c = 0;
            string ketqua;

           if(!String.IsNullOrEmpty(hsoA)) a = Convert.ToDouble(hsoA);
           if(!String.IsNullOrEmpty(hsoB)) b = Convert.ToDouble(hsoB);
           if(!String.IsNullOrEmpty(hsoC)) c = Convert.ToDouble(hsoC);

            if (a == 0) ketqua = "Không phải phương trình bậc 2!";

            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta < 0) ketqua = "Phương trình vô nghiệm";

                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    ketqua = "Phương trình có nghiệm kép = " + x1;
                }
                else
                {
                    x1 = Math.Round(-b + (Math.Sqrt(delta) / (2 * a)), 2);
                    x2 = Math.Round(-b - (Math.Sqrt(delta) / (2 * a)), 2);
                    ketqua = "Phương trình có 2 nghiệm phân biệt x1 = " + x1 + ", x2 = " + x2;

                }
            }

            ViewBag.thongbao = ketqua;
            return View();
        }

    }
}