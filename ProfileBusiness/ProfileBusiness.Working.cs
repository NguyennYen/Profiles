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
        public List<WorkingDTO> GetWorking(WorkingDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWorking(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<WorkingAllowanceDTO> GetWorkingAllowance(WorkingAllowanceDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "EMPLOYEE_CODE")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWorkingAllowance(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWorkingAllowance(WorkingAllowanceDTO objWorking, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWorkingAllowance(objWorking, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public WorkingDTO GetLastWorkingSalary(WorkingDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var obj = rep.GetLastWorkingSalary(_filter);
                    return obj;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public WorkingDTO GetWorkingByID(WorkingDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWorkingByID(_filter);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public WorkingDTO GetEmployeCurrentByID(WorkingDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetEmployeCurrentByID(_filter);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertWorking(WorkingDTO objWorking, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertWorking(objWorking, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWorking(WorkingDTO objWorking, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWorking(objWorking, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteWorking(WorkingDTO objWorking, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteWorking(objWorking, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateWorking(string sType, WorkingDTO obj)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateWorking(sType, obj);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<WorkingAllowanceDTO> GetAllowanceByDate(WorkingAllowanceDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetAllowanceByDate(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<WorkingAllowanceDTO> GetAllowanceByWorkingID(WorkingAllowanceDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetAllowanceByWorkingID(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteWorking3B(WorkingDTO objWorking)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteWorking3B(objWorking);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet GetChangeInfoImport(ParamDTO param, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetChangeInfoImport(param, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ImportChangeInfo(List<WorkingDTO> lstData, ref DataTable dtError, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ImportChangeInfo(lstData, dtError, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ReviewWorking(WorkingDTO objWorking, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ReviewWorking(objWorking, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public bool CheckWorking3B(WorkingDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckWorking3B(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<WorkingDTO> GetWorking3B(WorkingDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWorking3B(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool InsertWorking3B(WorkingDTO objWorking, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertWorking3B(objWorking, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWorking3b(WorkingDTO objWorking, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWorking3B(objWorking, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
