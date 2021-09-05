using System;
using Persistence;
using LoginBl;

namespace LoginBl
{
    public class StaffBl
    {
        private StaffDal dal = new StaffDal();
        public int Login(Staff staff){
            return dal.Login(staff);
        }
    }
}