using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using GottaCrowWebUI.Services;
using GottaCrowWebUI.ViewModels;
using GottaCrowWebUI.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GottaCrowWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IJobSearchActivityData _activities;
        
        //ctor
        public HomeController(
            IJobSearchActivityData repository,
            IGreeter greeter
            )
        {
            _greeter = greeter;
            _activities = repository;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.JobSearchActivities = _activities.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _activities.Get(id);
            if(model==null)
            { return HttpNotFound(); }
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(JobSearchActivityEditViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var newSearchActivity = new JobSearchActivity();
                newSearchActivity.ActivityType = viewModel.ActivityType;
                newSearchActivity.HappenedOn = DateTime.UtcNow;

                _activities.Add(newSearchActivity);
                //_activities.Commit(); TO-DO: finish implementation after applying EF changes...
                return RedirectToAction("Details", new { id = newSearchActivity.Id });
            }
            return View();
        }
    }
}
