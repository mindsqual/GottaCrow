using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Model
{
    public interface ICompany
    {
        int Id { get; set; }
        string CompanyName { get; set; }
    }
}
