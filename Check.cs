using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mail_LIB
{
    public class Check
    {
        public static bool check_mail(string mail)
        {
            string mailpattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(mail, mailpattern);
        }

        public static bool check_password(string password) {
            string passpattern = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*\W)(?!.*\s).{8,}$";

            return Regex.IsMatch(password, passpattern);
        }

        public static bool check_login(string login)
        {
            string logpattern = @"^[a-zA-Z0-9]{6,}$";
   
            return Regex.IsMatch(login, logpattern);
        }

        public static bool check_num(string str)
        {
            bool result = true;
            foreach (char s in str)
            {
                if (!char.IsDigit(s))
                    result = false;
            }
            return result;
        }
    }
}
