using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GottaCrowWebUI.Entities;

namespace GottaCrowWebUI.Services
{
    /// <summary>
    /// Represents a local repository of job search data
    /// </summary>
    public class SqlJobSearchData : IJobSearchActivityData
    {
        private JobSearchActivityDbContext _context;

        public SqlJobSearchData(JobSearchActivityDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<JobSearchActivity> GetAll()
        {
            return _context.JobSearchActivities.ToList();
        }
        public JobSearchActivity Get(int id)
        {
            return _context.JobSearchActivities.FirstOrDefault(r => r.Id == id);
        }
        public void Add(JobSearchActivity newActivity)
        {
            _context.Add(newActivity);
            _context.SaveChanges();
        }
        public void Commit()
        {
            throw new NotImplementedException();
        }

        
    }
}
