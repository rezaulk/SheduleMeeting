using ScheduleMeeting.Entity;
using ScheduleMeeting.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleMeeting.Services
{
    public class UserService: IUserService
    {
        private ScheduleDBContext _scheduleDBContext;
        public UserService(ScheduleDBContext scheduleDBContext)
        {
            _scheduleDBContext = scheduleDBContext;
        }

        public bool Save(User user)
        {
            _scheduleDBContext.Users.Add(user);
            _scheduleDBContext.SaveChanges();
            return user.UserID > 0 ? true : false;
        }

        public List<User> GetAllUser()
        {
            return _scheduleDBContext.Users.ToList();

        }
    }

    public interface IUserService
    {
        List<User> GetAllUser();
        bool Save(User user);

    }
}
