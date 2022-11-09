using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger p)
        {
            p.fullName.FirstName = p.fullName.FirstName[0].ToString().ToUpper()+p.fullName.FirstName.Substring(1);
            p.fullName.LastName = p.fullName.LastName[0].ToString().ToUpper()+p.fullName.LastName.Substring(1);

        }

    }
}
