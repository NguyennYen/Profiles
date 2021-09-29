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
        public List<CommendDTO> GetCommend(CommendDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetCommend(_filter, PageIndex, PageSize, Total, log, Sorts);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public List<CommendEmpDTO> GetEmployeeCommendByID(decimal ComId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeCommendByID(ComId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public CommendDTO GetCommendByID(CommendDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetCommendByID(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertCommend(CommendDTO objCommend, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertCommend(objCommend, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyCommend(CommendDTO objCommend, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyCommend(objCommend, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateCommend(string sType, CommendDTO obj)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateCommend(sType, obj);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteCommend(CommendDTO objCommend)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteCommend(objCommend);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ApproveCommend(CommendDTO objCommend)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ApproveCommend(objCommend);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
