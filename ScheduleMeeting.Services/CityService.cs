using ScheduleMeeting.Entity;
using ScheduleMeeting.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleMeeting.Services
{
    public class CityService : ICityService
    {
        private ScheduleDBContext _scheduleDBContext;
        public CityService(ScheduleDBContext scheduleDBContext)
        {
            _scheduleDBContext = scheduleDBContext;

        }

        public bool Save(City city)
        {
            _scheduleDBContext.Citys.Add(city);
            _scheduleDBContext.SaveChanges();
            return city.CityId > 0 ? true : false;
        }

        public List<City> GetAllCities()
        {
            return _scheduleDBContext.Citys.ToList();
        }
    }
    public interface ICityService
    {
        public bool Save(City city);
        public List<City> GetAllCities();


    }
}
