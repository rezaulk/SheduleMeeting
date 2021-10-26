using ScheduleMeeting.Entity;
using ScheduleMeeting.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleMeeting.Services
{
    public class CountryService: ICountryService
    {

        private ScheduleDBContext _scheduleDBContext;
        public CountryService(ScheduleDBContext scheduleDBContext)
        {
            _scheduleDBContext = scheduleDBContext;
        }

        public bool Save(Country country)
        {
            _scheduleDBContext.Countrys.Add(country);
            _scheduleDBContext.SaveChanges();
            return country.CountryId > 0 ? true : false;
        }

        public List<Country> GetAllCountry()
        {
            return _scheduleDBContext.Countrys.ToList();
        }

    }

    public interface ICountryService
    {
        bool Save(Country country);
        List<Country> GetAllCountry();

    }

}
