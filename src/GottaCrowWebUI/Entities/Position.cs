using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.Entities
{
    public interface IPosition
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        IEmployer Employer { get; set; }
        string EmployerTrackingCode { get; set; }
    }
    public class Position : IPosition
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEmployer Employer { get; set; }
        public string EmployerTrackingCode { get; set; }
    }
}
