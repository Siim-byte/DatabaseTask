using DatabaseTask.Data;
using DatabaseTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace DatabaseTask.Controllers
{
    public class HomeController : Controller
    {
        public DatabaseTaskDbContext _context;
        public IConfiguration _confiq;

        private readonly ILogger<HomeController> _logger;


        public HomeController
            (
            ILogger<HomeController> logger,
            DatabaseTaskDbContext context,
            IConfiguration config
            )
        {
            _logger = logger;
            _context = context;
            _confiq = config;
        }


        [HttpGet]
        public IActionResult Index()
        {
            string connectionStr = _confiq.GetConnectionString("DefaultConnection");

            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "dbo.spGetPatient";
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();



                return View();
            }
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
    }
}