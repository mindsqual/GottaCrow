using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Model
{
    /// <summary>
    /// Represents an activity that a
    /// job seekers does as part of their job search.
    /// </summary>
    public class JobSearchActivity : IJobSearchActivity, IModificationHistory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public ActivityType ActivityType { get; set; }

        public Person Person { get; set; }

        #region//history tracking
        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsDirty { get; set; }
        #endregion
    }
}
