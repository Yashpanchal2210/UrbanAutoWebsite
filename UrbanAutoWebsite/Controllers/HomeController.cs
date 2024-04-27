using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UrbanAutoWebsite.DataProvider;
using UrbanAutoWebsite.Models;
using UrbanAutoWebsite.Service;

namespace UrbanAutoWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly UrbanAutoMasterContext _context;
        private readonly EmailService _emailService;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, UrbanAutoMasterContext context, EmailService emailService)
        {
            _logger = logger;
            _configuration = configuration;
            _context = context;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Enquirypost(EnquiryViewModel enquiryViewModel)
        {
            if (ModelState.IsValid)
            {

                var enquiry = new CustomerEnquiry
                {
                    FirstName = enquiryViewModel.FirstName,
                    LastName = enquiryViewModel.LastName,
                    Email = enquiryViewModel.Email,
                    Phone = "+91 " + enquiryViewModel.Phone,
                    State = enquiryViewModel.State,
                    City = enquiryViewModel.City,
                    Description = enquiryViewModel.Description,
                };

                var templatePath = "D:\\GitUrbanAutoWeb\\UrbanAutoWebsite\\UrbanAutoWebsite\\UrbanAutoWebsite\\EmailTemplate\\WelcomEmail.cshtml";
                var userName = enquiryViewModel.FirstName + " " + enquiryViewModel.LastName;
                //_emailService.SendEmail(enquiryViewModel.Email, "Enquiry Submitted", templatePath, userName);

                _context.CustomerEnquiries.Add(enquiry);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        public IActionResult TermsandCondition()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ErrorView()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
