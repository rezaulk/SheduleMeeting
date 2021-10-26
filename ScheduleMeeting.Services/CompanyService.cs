using ScheduleMeeting.Entity;
using ScheduleMeeting.Infrustructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleMeeting.Services
{
    public class CompanyService: ICompanyService
    {
        private ScheduleDBContext _scheduleDBContext;
        public CompanyService(ScheduleDBContext scheduleDBContext)
        {
            _scheduleDBContext = scheduleDBContext;

        }

        public bool Save(Company company)
        {
            _scheduleDBContext.Companys.Add(company);
            _scheduleDBContext.SaveChanges();
            return company.CompanyID > 0 ? true : false;
        }

        public List<Company> GetAllCompany()
        {
            return _scheduleDBContext.Companys.ToList();
        }
    }
    public interface ICompanyService
    {
         List<Company> GetAllCompany();
        bool Save(Company company);


    }
}
