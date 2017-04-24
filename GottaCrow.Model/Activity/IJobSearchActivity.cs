using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Model
{
    public interface IJobSearchActivity
    {
        int Id { get; set; }
        string Description { get; set; }
        string Notes { get; set; }
        DateTime Date { get; set; }

        ActivityType ActivityType { get; set; }
    }
}
