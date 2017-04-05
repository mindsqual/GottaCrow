using GottaCrowWebUI.Entities;
using System.Collections.Generic;

namespace GottaCrowWebUI.Services
{
    /// <summary>
    /// Represents operations and properties of
    /// a collection of JobSearchActivity objects.
    /// </summary>
    public interface IJobSearchActivityData
    {
        IEnumerable<JobSearchActivity> GetAll();
        JobSearchActivity Get(int id);
        void Add(JobSearchActivity activity);
        void Commit();
    }
}
