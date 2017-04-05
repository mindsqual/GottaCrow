using GottaCrowWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.ViewModels
{
    /// <summary>
    /// Passed to Create ActionMethod of the HomeController (so far...)
    /// </summary>
    public class JobSearchActivityEditViewModel
    {
        public JobSearchActivityType ActivityType { get; set; }
    }
}
