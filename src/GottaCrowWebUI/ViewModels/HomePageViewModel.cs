using GottaCrowWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.ViewModels
{
    public class HomePageViewModel
    {
        public string CurrentGreeting { get; set; }
        public IEnumerable<JobSearchActivity> JobSearchActivities { get; set; }
    }
}
