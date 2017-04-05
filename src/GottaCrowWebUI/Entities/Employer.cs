using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.Entities
{
    public interface IEmployer
    {
        string Name { get; set; }

    }
    public class Employer : IEmployer
    {
        public string Name { get; set; }
    }
}
