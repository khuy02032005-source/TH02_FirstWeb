using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TH02_FirstWeb.Models;

namespace TH02_FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NameList()
        {
            List<string> danhSachTen = new List<string>
            {
                "Nguyễn Văn A",
                "Trần Thị B",
                "Lê Văn C",
                "Phạm Thị D"
            };

            return View(danhSachTen);
        }
    }
}
