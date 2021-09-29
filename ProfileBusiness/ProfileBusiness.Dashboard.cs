using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using ProfileBusiness.ServiceContracts;
using ProfileDAL;
using Framework.Data;
using System.ServiceModel.Activation;
using System.Configuration;

namespace ProfileBusiness.ServiceImplementations
{
    partial class ProfileBusiness
    {
        public System.Collections.Generic.List<ProfileDAL.StatisticDTO> GetEmployeeStatistic(string _type, UserLog log)
        {
            using (ProfileDashboardRepository rep = new ProfileDashboardRepository())
            {
                try
                {
                    var lst = rep.GetEmployeeStatistic(_type, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public System.Collections.Generic.List<ProfileDAL.OtherListDTO> GetListEmployeeStatistic()
        {
            using (ProfileDashboardRepository rep = new ProfileDashboardRepository())
            {
                try
                {
                    var lst = rep.GetListEmployeeStatistic();
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.StatisticDTO> GetChangeStatistic(string _type, UserLog log)
        {
            using (ProfileDashboardRepository rep = new ProfileDashboardRepository())
            {
                try
                {
                    var lst = rep.GetChangeStatistic(_type, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public System.Collections.Generic.List<ProfileDAL.OtherListDTO> GetListChangeStatistic()
        {
            using (ProfileDashboardRepository rep = new ProfileDashboardRepository())
            {
                try
                {
                    var lst = rep.GetListChangeStatistic();
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public System.Collections.Generic.List<ProfileDAL.ReminderLogDTO> GetRemind(string _dayRemind, UserLog log)
        {
            using (ProfileDashboardRepository rep = new ProfileDashboardRepository())
            {
                try
                {
                    return rep.GetRemind(_dayRemind, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public System.Collections.Generic.List<ProfileDAL.StatisticDTO> GetCompanyNewInfo(UserLog log)
        {
            using (ProfileDashboardRepository rep = new ProfileDashboardRepository())
            {
                try
                {
                    return rep.GetCompanyNewInfo(log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
