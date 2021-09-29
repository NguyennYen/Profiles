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
        public List<FamilyDTO> GetEmployeeFamily(FamilyDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeFamily(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertEmployeeFamily(FamilyDTO objFamily, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertEmployeeFamily(objFamily, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyEmployeeFamily(FamilyDTO objFamily, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyEmployeeFamily(objFamily, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteEmployeeFamily(List<decimal> lstDecimals, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteEmployeeFamily(lstDecimals, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateFamily(FamilyDTO objFamily)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateFamily(objFamily);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<FamilyEditDTO> GetEmployeeFamilyEdit(FamilyEditDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeFamilyEdit(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertEmployeeFamilyEdit(FamilyEditDTO objFamilyEdit, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertEmployeeFamilyEdit(objFamilyEdit, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyEmployeeFamilyEdit(FamilyEditDTO objFamilyEdit, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyEmployeeFamilyEdit(objFamilyEdit, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteEmployeeFamilyEdit(List<decimal> lstDecimals, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteEmployeeFamilyEdit(lstDecimals, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public FamilyEditDTO CheckExistFamilyEdit(decimal pk_key)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckExistFamilyEdit(pk_key);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool SendEmployeeFamilyEdit(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.SendEmployeeFamilyEdit(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool UpdateStatusEmployeeFamilyEdit(List<decimal> lstID, string status, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.UpdateStatusEmployeeFamilyEdit(lstID, status, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<FamilyEditDTO> GetApproveFamilyEdit(FamilyEditDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetApproveFamilyEdit(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
