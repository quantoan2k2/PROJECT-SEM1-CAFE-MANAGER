using System;
using Persistence;
using LoginDal;

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