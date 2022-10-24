using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICalling
    {
        private string phoneNumber;

        public StationaryPhone(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            PhoneNumber = this.phoneNumber;
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                List<char> number = phoneNumber.ToList();

                if (number.Any(x => Char.IsDigit(x) == false))
                {
                    throw new ArgumentException("Invalid number!");
                }

                phoneNumber = value;

            }
        }
        public string Call()
        {
            return $"Dialing... {PhoneNumber}";
        }
    }
}
