using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        private string number;
        private string url;

        public Smartphone(string number)
        {
            this.number = number;
            Number = this.number;
        }

        public Smartphone(string number, string url) : this(number)
        {
            this.url = url;
            Url = this.url;
        }

        public string Number
        {
            get
            {
                return this.number;
            }
            set
            {
                char[] numbers = number.ToCharArray();

                if (numbers.Any(x => Char.IsDigit(x) == false))
                {
                    throw new ArgumentException("Invalid number!");
                }

                number = value;
            }
        }
        public string Url {
            get
            {
                return this.url;
            }
            set
            {
                char[] websites = url.ToCharArray();

                if (websites.Any(x => Char.IsDigit(x) == true))
                {
                    throw new ArgumentException("Invalid URL!");
                }

                url = value;
            }
        }
        public string Browse()
        {
            return $"Browsing: {Url}!";
        }

        public string Call()
        {
            return $"Calling... {Number}";
        }
    }
}
