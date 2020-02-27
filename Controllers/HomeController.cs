using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NextekkStaffManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace NextekkStaffManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index(Staffs userData)
        {
            if (User.IsInRole(Constants.Admin))
            {

                var db = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context();
                var user = db.Staffs.OrderBy(c => c.Firstname).ToList();
                string userInput = userData.Firstname;
                if(!string.IsNullOrEmpty(userInput))
                {
                    var staff = from s in db.Staffs select s;
                    userInput = userInput.ToUpper();
                     user = staff
                    .Where(s => s.Firstname.Contains(userInput) || s.Lastname.Contains(userInput))
                    .OrderBy(s => s.Firstname)
                    .ToList();
                    ViewBag.search = "true";

                    //staff = staff.Where(c => EF.Functions.Like(c.Firstname, userInput)).All();   
                }


                return View("Admin", user);
            }
            else
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;
                
                    // the principal identity is a claims identity.
                    // now we need to find the NameIdentifier claim
                    var userIdClaim = claimsIdentity.Claims
                        .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
                    var currentUserId = userIdClaim.Value;
                    var db = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context();
                    var staffDetails = db.Staffs.Where(c => c.AspNetUsersId == currentUserId).First();
                    if(staffDetails.Active == "Active")
                    {
                        var staffPageModel  = new StaffPageModel();
                        staffPageModel.Id = staffDetails.Id;
                        staffPageModel.Firstname = staffDetails.Firstname;
                        staffPageModel.Lastname = staffDetails.Lastname;
                        staffPageModel.Gender = staffDetails.Gender;
                        staffPageModel.Dob = staffDetails.Dob;
                        staffPageModel.NoOfChildren = staffDetails.NoOfChildren;
                        staffPageModel.MaritalStatus = staffDetails.MaritalStatus;
                        staffPageModel.Active = staffDetails.Active;
                        staffPageModel.DayEmployed = staffDetails.DayEmployed;
                        staffPageModel.School = staffDetails.School;
                        staffPageModel.HighestQualification = staffDetails.HighestQualification;
                        staffPageModel.TimeOfService = staffDetails.TimeOfService;
                        staffPageModel.Position = staffDetails.Position;
                        staffPageModel.LastPromoted = staffDetails.LastPromoted;
                        staffPageModel.AnnualSalary = staffDetails.AnnualSalary;
                        
                        var Subordinates = db.Staffs.Where(b => b.Supervisor ==  staffDetails.Id).ToList();

                        staffPageModel.Subordinates = Subordinates;

                        return View("StaffPortfolio", staffPageModel);
                    }
                    else
                    {
                        return View("UnActive");
                    }
        }
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult StaffPage(Staffs staff)
        {
            var db = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context();
            Staffs staffDetails = db.Staffs.Where(b => b.Id ==  staff.Id).First();
            var staffPageModel  = new StaffPageModel();
            staffPageModel.Id = staffDetails.Id;
            staffPageModel.Firstname = staffDetails.Firstname;
            staffPageModel.Lastname = staffDetails.Lastname;
            staffPageModel.Gender = staffDetails.Gender;
            staffPageModel.Dob = staffDetails.Dob;
            staffPageModel.NoOfChildren = staffDetails.NoOfChildren;
            staffPageModel.MaritalStatus = staffDetails.MaritalStatus;
            staffPageModel.Active = staffDetails.Active;
            staffPageModel.DayEmployed = staffDetails.DayEmployed;
            staffPageModel.School = staffDetails.School;
            staffPageModel.HighestQualification = staffDetails.HighestQualification;
            staffPageModel.TimeOfService = staffDetails.TimeOfService;
            staffPageModel.Position = staffDetails.Position;
            staffPageModel.LastPromoted = staffDetails.LastPromoted;
            staffPageModel.AnnualSalary = staffDetails.AnnualSalary;
            
            var Subordinates = db.Staffs.Where(b => b.Supervisor ==  staff.Id).ToList();

            staffPageModel.Subordinates = Subordinates;

            return View(staffPageModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditStaff(Staffs staff)
        {
            var db = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context();
            Staffs staffDetails = db.Staffs.Where(b => b.Id ==  staff.Id).First();
            var staffPageModel  = new StaffPageModel();
            staffPageModel.Id = staffDetails.Id;
            staffPageModel.Firstname = staffDetails.Firstname;
            staffPageModel.Lastname = staffDetails.Lastname;
            staffPageModel.Gender = staffDetails.Gender;
            staffPageModel.Dob = staffDetails.Dob;
            staffPageModel.NoOfChildren = staffDetails.NoOfChildren;
            staffPageModel.MaritalStatus = staffDetails.MaritalStatus;
            staffPageModel.Active = staffDetails.Active;
            staffPageModel.DayEmployed = staffDetails.DayEmployed;
            staffPageModel.School = staffDetails.School;
            staffPageModel.HighestQualification = staffDetails.HighestQualification;
            staffPageModel.TimeOfService = staffDetails.TimeOfService;
            staffPageModel.Position = staffDetails.Position;
            staffPageModel.LastPromoted = staffDetails.LastPromoted;
            staffPageModel.AnnualSalary = staffDetails.AnnualSalary;
            
            var Subordinates = db.Staffs.ToList();

            staffPageModel.Subordinates = Subordinates;
            return View(staffPageModel);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Staffs staff)
        {
            var db = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context();
            Staffs staffDetails = db.Staffs.Where(b => b.Id ==  staff.Id).First();
            if(staffDetails != null)
            {
                if(!string.IsNullOrEmpty(staff.Active) && staffDetails.Active != staff.Active)
                {
                    staffDetails.Active = staff.Active;
                }
                if(staffDetails.DayEmployed != staff.DayEmployed)
                {
                    staffDetails.DayEmployed = staff.DayEmployed;
                }
                if(staffDetails.HighestQualification != staff.HighestQualification)
                {
                    staffDetails.HighestQualification = staff.HighestQualification;
                }
                if(staffDetails.School != staff.School)
                {
                    staffDetails.School = staff.School;
                }
                if(staffDetails.TimeOfService != staff.TimeOfService)
                {
                    staffDetails.TimeOfService = staff.TimeOfService;
                }
                if(staffDetails.Position != staff.Position)
                {
                    staffDetails.Position = staff.Position;
                }
                if(staffDetails.LastPromoted != staff.LastPromoted)
                {
                    staffDetails.LastPromoted = staff.LastPromoted;
                }
                if(staffDetails.AnnualSalary != staff.AnnualSalary)
                {
                    staffDetails.AnnualSalary = staff.AnnualSalary;
                }
                if(staffDetails.Supervisor != staff.Supervisor)
                {
                    staffDetails.Supervisor = staff.Supervisor;
                }

            }
            db.Update(staffDetails);
            db.SaveChanges();
            var Details = db.Staffs.ToList();
            return View("Admin", Details);
        }


        [HttpPost]
        [Authorize]
        public IActionResult StaffEdit(Staffs staff)
        {
            var db = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context();
            Staffs staffDetails = db.Staffs.Where(b => b.Id ==  staff.Id).First();

            return View(staffDetails);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edited(Staffs staff)
        {
            var db = new aspnetnextekkstaffmanager11A04C4EF18F4B39BEC3D02923AE7589Context();
            Staffs staffDetails = db.Staffs.Where(b => b.Id ==  staff.Id).First();
            if(staffDetails != null)
            {
                if(!string.IsNullOrEmpty(staff.Firstname) && staffDetails.Firstname != staff.Firstname)
                {
                    staffDetails.DayEmployed = staff.Firstname.ToUpper();
                }
                if(!string.IsNullOrEmpty(staff.Lastname) && staffDetails.Lastname != staff.Lastname)
                {
                    staffDetails.Lastname = staff.Lastname.ToUpper();
                }
                if(!string.IsNullOrEmpty(staff.Gender) && (staffDetails.Gender != staff.Gender))
                {
                    staffDetails.Gender = staff.Gender;
                }
                if(!string.IsNullOrEmpty(staff.Dob) && (staffDetails.Dob != staff.Dob))
                {
                    staffDetails.Dob = staff.Dob;
                }
                if(!string.IsNullOrEmpty(staff.MaritalStatus) && staffDetails.MaritalStatus != staff.MaritalStatus)
                {
                    staffDetails.MaritalStatus = staff.MaritalStatus;
                }
            }
            db.Update(staffDetails);
            db.SaveChanges();
            var staffRecord = db.Staffs.Where(b => b.Id ==  staff.Id).First();
            return Redirect("Index");
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
