using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.Entities
{
    public interface IPhoneNumber
    {
        int Id { get; set; }
        string FullNumber { get; }
    }
    public class PhoneNumber : IPhoneNumber
    {

        private readonly string _fullNumber;
        public int Id { get; set; }
        public PhoneNumber(string number)
        {
            //TO-DO: client-side validation and parsing of this string
            //I could have this ctor check the format of the number 
            //and throw exception if not correct...???
            _fullNumber = number;
        }
        public string FullNumber { get { return _fullNumber; } }
    }

}
