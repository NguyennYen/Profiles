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

// NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in both code and config file together.
namespace ProfileBusiness.ServiceImplementations
{
    public class ProfileBusinessIntegrated : IProfileBusinessIntegrated
    {
        public DataTable GetEmpAll(DateTime lastDate)
        {
            using (ProfileRepositoryIntegrated rep = new ProfileRepositoryIntegrated())
            {
                try
                {
                    return rep.GetEmpAll(lastDate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetOrgAll(DateTime lastDate)
        {
            using (ProfileRepositoryIntegrated rep = new ProfileRepositoryIntegrated())
            {
                try
                {
                    return rep.GetOrgAll(lastDate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetTitleAll(DateTime lastDate)
        {
            using (ProfileRepositoryIntegrated rep = new ProfileRepositoryIntegrated())
            {
                try
                {
                    return rep.GetTitleAll(lastDate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetTitleGroupAll(DateTime lastDate)
        {
            using (ProfileRepositoryIntegrated rep = new ProfileRepositoryIntegrated())
            {
                try
                {
                    return rep.GetTitleGroupAll(lastDate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetStaffRankAll(DateTime lastDate)
        {
            using (ProfileRepositoryIntegrated rep = new ProfileRepositoryIntegrated())
            {
                try
                {
                    return rep.GetStaffRankAll(lastDate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
