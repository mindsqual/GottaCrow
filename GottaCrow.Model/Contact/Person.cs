using System;

namespace JobSearch.Model
{
    public class Person : IPerson, IModificationHistory
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        #region//history tracking
        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsDirty { get; set; }
        #endregion
    }

}
