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
        public DataTable CalculateTerminate(decimal EmployeeId, DateTime TerLateDate, decimal orgId, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.CalculateTerminate(EmployeeId, TerLateDate, orgId, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<LabourProtectionMngDTO> GetLabourProtectByTerminate(decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetLabourProtectByTerminate(gID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<AssetMngDTO> GetAssetByTerminate(decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetAssetByTerminate(gID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<TerminateDTO> GetTerminate(TerminateDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTerminate(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public TerminateDTO GetTerminateByID(TerminateDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTerminateByID(_filter);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public EmployeeDTO GetEmployeeByID(decimal gEmployeeID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetEmployeeByID(gEmployeeID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertTerminate(TerminateDTO objTerminate, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertTerminate(objTerminate, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyTerminate(TerminateDTO objTerminate, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyTerminate(objTerminate, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteTerminate(decimal objID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteTerminate(objID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteBlackList(decimal objID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteBlackList(objID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ApproveTerminate(TerminateDTO objTerminate)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ApproveTerminate(objTerminate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckTerminateNo(TerminateDTO objTerminate)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckTerminateNo(objTerminate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckTerminateEmp(TerminateDTO objTerminate)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckTerminateEmp(objTerminate);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetTyleNV()
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetTyleNV();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetSalaryNew(ref int P_EMPLOYEEID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetSalaryNew(P_EMPLOYEEID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Terminate3BDTO> GetTerminate3b(Terminate3BDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTerminate3b(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Terminate3BDTO GetTerminate3bByID(Terminate3BDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTerminate3bByID(_filter);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public EmployeeDTO GetTerminate3bEmployeeByID(decimal gEmployeeID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTerminate3bEmployeeByID(gEmployeeID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertTerminate3b(Terminate3BDTO objTerminate3b, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertTerminate3b(objTerminate3b, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyTerminate3b(Terminate3BDTO objTerminate3b, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyTerminate3b(objTerminate3b, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckExistApproveTerminate3b(decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckExistApproveTerminate3b(gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteTerminate3b(decimal objID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteTerminate3b(objID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
