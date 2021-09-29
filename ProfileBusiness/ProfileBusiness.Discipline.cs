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
        public List<DisciplineEmpDTO> GetEmployeeDesciplineID(decimal DesId)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.GetEmployeeDesciplineID(DesId);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DisciplineDTO> GetDiscipline(DisciplineDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log = null/* TODO Change to default(_) if this is not a reference type */, string Sorts = "CREATED_DATE desc")
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.GetDiscipline(_filter, PageIndex, PageSize, Total, log, Sorts);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DisciplineDTO GetDisciplineByID(DisciplineDTO _filter)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.GetDisciplineByID(_filter);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertDiscipline(DisciplineDTO objDiscipline, UserLog log, ref decimal gID, decimal ischeck)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                return rep.InsertDiscipline(objDiscipline, log, gID, ischeck);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ModifyDiscipline(DisciplineDTO objDiscipline, UserLog log, ref decimal gID)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                return rep.ModifyDiscipline(objDiscipline, log, gID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ModifyStatusDiscipline(DisciplineDTO objDiscipline, UserLog log, ref decimal gID)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                return rep.ModifyStatusDiscipline(objDiscipline, log, gID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidateDiscipline(string sType, DisciplineDTO obj)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateDiscipline(sType, obj);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteDiscipline(DisciplineDTO objDiscipline)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                return rep.DeleteDiscipline(objDiscipline);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ApproveDiscipline(DisciplineDTO objDiscipline)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                return rep.ApproveDiscipline(objDiscipline);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<DisciplineSalaryDTO> GetDisciplineSalary(DisciplineSalaryDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log = null/* TODO Change to default(_) if this is not a reference type */, string Sorts = "YEAR,MONTH,EMPLOYEE_CODE")
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.GetDisciplineSalary(_filter, PageIndex, PageSize, Total, log, Sorts);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DisciplineSalaryDTO GetDisciplineSalaryByID(DisciplineSalaryDTO _filter)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.GetDisciplineSalaryByID(_filter);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditDisciplineSalary(DisciplineSalaryDTO obj)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.EditDisciplineSalary(obj);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidateDisciplineSalary(DisciplineSalaryDTO obj, ref string sError)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.ValidateDisciplineSalary(obj, sError);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ApproveDisciplineSalary(List<decimal> lstID)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.ApproveDisciplineSalary(lstID);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ApprovePaid(List<DisciplineSalaryDTO> lstEmployee)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.ApprovePaid(lstEmployee);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool OpenApproveDisciplineSalary(List<decimal> lstID)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.OpenApproveDisciplineSalary(lstID);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool StopDisciplineSalary(List<decimal> lstID)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.StopDisciplineSalary(lstID);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool StartDisciplineSalary(List<decimal> lstID)
        {
            try
            {
                ProfileRepository rep = new ProfileRepository();
                var lst = rep.StartDisciplineSalary(lstID);
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
