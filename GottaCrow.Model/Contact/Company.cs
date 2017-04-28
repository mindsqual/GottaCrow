using System;
using System.Collections.Generic;

namespace JobSearch.Model
{
    public class Company : ICompany, IModificationHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Employees { get; set; }

        #region//history tracking
        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsDirty { get; set; }
        #endregion
    }
}
