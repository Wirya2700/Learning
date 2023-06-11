using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Learning
{
    public static class RegularExpression
    {
        public static bool IsEmail(string email)
        {
            try
            {
                Regex regexEmail = new Regex(
                    @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
                    RegexOptions.IgnoreCase, 
                    TimeSpan.FromSeconds(5));

                return regexEmail.IsMatch(email);
            }
            catch
            {
                throw;
            }
        }

        public static bool IsPhone(string phone)
        {
            try
            {
                Regex regexNumber = new Regex(
                    @"^(\+\d{1,3}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$",
                    RegexOptions.IgnoreCase, 
                    TimeSpan.FromSeconds(5));

                return regexNumber.IsMatch(phone);
            }
            catch
            {
                throw;
            }
        }

        public static bool IsDocumentNumber(string documentNumber)
        {
            try
            {
                //format document: ABC/2023/VII/00001

                Regex regexDocNo = new Regex(
                    @"^(\w{3})/(\d{4})/(I|II|III|IV|V|VI|VII|VIII|IX|X|XI|XII)/(\d{5,})$",
                    RegexOptions.IgnoreCase,
                    TimeSpan.FromSeconds(5));

                return regexDocNo.IsMatch(documentNumber);
            }
            catch
            {
                throw;
            }
        }
    }
}
