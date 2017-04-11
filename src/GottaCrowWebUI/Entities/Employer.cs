using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.Entities
{
    public interface IEmployer
    {
        int Id { get; set; }
        string Name { get; set; }

    }
    public class Employer : IEmployer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// List of potential positions the seeker might apply for.
        /// </summary>
        public List<IPosition> Positions { get; set; }
    }
}
