using System;

namespace Persistence
{
    public class Staff
    {
        public int StaffId {set;get;}

        public string StaffName {set;get;}

        public string UserName {set;get;}

        public string Password {set;get;}

        public string Telephone {set;get;}

        public int Role {set;get;}

        public static int SALE_ROLE = 1;
        
        public static int CASH_ROLE = 2;
    }
}
