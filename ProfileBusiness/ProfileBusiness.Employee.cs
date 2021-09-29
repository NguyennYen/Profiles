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


        /// <summary>
        ///         ''' Lay thong tin nhan vien tu EmployeeCode
        ///         ''' </summary>
        ///         ''' <param name="sEmployeeCode"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public EmployeeDTO GetEmployeeByEmployeeID(decimal empID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeByEmployeeID(empID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public byte[] GetEmployeeImage(decimal gEmpID, ref string sError)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeImage(gEmpID, sError);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertEmployee(EmployeeDTO objEmp, UserLog log, ref decimal gID, ref string _strEmpCode, byte[] _imageBinary, EmployeeCVDTO objEmpCV = null/* TODO Change to default(_) if this is not a reference type */, EmployeeEduDTO objEmpEdu = null/* TODO Change to default(_) if this is not a reference type */, EmployeeHealthDTO objEmpHealth = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertEmployee(objEmp, log, gID, _strEmpCode, _imageBinary, IIf(objEmpCV != null, objEmpCV, null/* TODO Change to default(_) if this is not a reference type */)
                                                , IIf(objEmpEdu != null, objEmpEdu, null/* TODO Change to default(_) if this is not a reference type */)
                                                , IIf(objEmpHealth != null, objEmpHealth, null/* TODO Change to default(_) if this is not a reference type */));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyEmployee(EmployeeDTO objEmp, UserLog log, ref decimal gID, byte[] _imageBinary, EmployeeCVDTO objEmpCV = null/* TODO Change to default(_) if this is not a reference type */, EmployeeEduDTO objEmpEdu = null/* TODO Change to default(_) if this is not a reference type */, EmployeeHealthDTO objEmpHealth = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyEmployee(objEmp, log, gID, _imageBinary, IIf(objEmpCV != null, objEmpCV, null/* TODO Change to default(_) if this is not a reference type */), IIf(objEmpEdu != null, objEmpEdu, null/* TODO Change to default(_) if this is not a reference type */), IIf(objEmpHealth != null, objEmpHealth, null/* TODO Change to default(_) if this is not a reference type */));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<EmployeeDTO> GetListEmployee(List<decimal> _orgIds, EmployeeDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetListEmployee(_orgIds, _filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<OrgChartDTO> GetEmployeeOrgChart(List<decimal> lstOrg, UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeOrgChart(lstOrg, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<EmployeeDTO> GetListEmployeePaging(EmployeeDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetListEmployeePaging(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<EmployeeDTO> GetListEmployeePortal(EmployeeDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetListEmployeePortal(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteEmployee(List<decimal> lstEmpID, UserLog log, ref string sError)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteEmployee(lstEmpID, log, sError);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateEmployee(string sType, string sEmpCode, string value)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateEmployee(sType, sEmpCode, value);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        ///         ''' Hàm kiểm tra nhân viên có hợp đồng hay chưa.
        ///         ''' </summary>
        ///         ''' <param name="strEmpCode"></param>
        ///         ''' <returns>true: nếu có</returns>
        ///         ''' <remarks></remarks>
        public bool CheckEmpHasContract(string strEmpCode)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckEmpHasContract(strEmpCode);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<EmployeeDTO> GetLineManager(string username)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetLineManager(username);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public decimal? GetOrgFromUsername(string username)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetOrgFromUsername(username);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool UnactiveEmployee(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.UnactiveEmployee(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool GetEmployeeAllByID(decimal sEmployeeID, ref EmployeeCVDTO empCV, ref EmployeeEduDTO empEdu, ref EmployeeHealthDTO empHealth)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeAllByID(sEmployeeID, empCV, empEdu, empHealth);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<WorkingBeforeDTO> GetEmpWorkingBefore(WorkingBeforeDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetWorkingBefore(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertWorkingBefore(WorkingBeforeDTO objWorkingBefore, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertWorkingBefore(objWorkingBefore, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWorkingBefore(WorkingBeforeDTO objWorkingBefore, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWorkingBefore(objWorkingBefore, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteWorkingBefore(List<decimal> lstDecimals, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteWorkingBefore(lstDecimals, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<ProfileDAL.CommendDTO> GetCommendProccess(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetCommendProccess(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.ContractDTO> GetContractProccess(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetContractProccess(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.DisciplineDTO> GetDisciplineProccess(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetDisciplineProccess(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetInsuranceProccess(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetInsuranceProccess(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetEmployeeHistory(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeHistory(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.FamilyDTO> GetFamily(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetFamily(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.WorkingDTO> GetSalaryProccess(decimal _empId, UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetSalaryProccess(_empId, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.WelfareMngDTO> GetWelfareProccess(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetWelfareProccess(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.WorkingBeforeDTO> GetWorkingBefore(System.Decimal _empId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetWorkingBefore(_empId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<ProfileDAL.WorkingDTO> GetWorkingProccess(decimal _empId, UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetWorkingProccess(_empId, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<HU_PRO_TRAIN_OUT_COMPANYDTO> GetProcessTraining(HU_PRO_TRAIN_OUT_COMPANYDTO _filter, ref int PageIndex = 0, int PageSize = int.MaxValue, int Total = 0, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetProcessTraining(_filter, PageIndex, PageSize, Total, Sorts);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertProcessTraining(HU_PRO_TRAIN_OUT_COMPANYDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertProcessTraining(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyProcessTraining(HU_PRO_TRAIN_OUT_COMPANYDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyProcessTraining(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteProcessTraining(List<decimal> lstID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteProcessTraining(lstID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public EmployeeEditDTO GetEmployeeEditByID(EmployeeEditDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeEditByID(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertEmployeeEdit(EmployeeEditDTO objEmployeeEdit, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertEmployeeEdit(objEmployeeEdit, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyEmployeeEdit(EmployeeEditDTO objEmployeeEdit, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyEmployeeEdit(objEmployeeEdit, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteEmployeeEdit(List<decimal> lstDecimals, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteEmployeeEdit(lstDecimals, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool SendEmployeeEdit(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.SendEmployeeEdit(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool UpdateStatusEmployeeEdit(List<decimal> lstID, string status, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.UpdateStatusEmployeeEdit(lstID, status, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<EmployeeEditDTO> GetApproveEmployeeEdit(EmployeeEditDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetApproveEmployeeEdit(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<HU_PRO_TRAIN_OUT_COMPANYDTOEDIT> GetProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetProcessTrainingEdit(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT objTrainOutCompany, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertProcessTrainingEdit(objTrainOutCompany, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT objTrainOutCompany, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyProcessTrainingEdit(objTrainOutCompany, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteProcessTrainingEdit(List<decimal> lstDecimals, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteProcessTrainingEdit(lstDecimals, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public HU_PRO_TRAIN_OUT_COMPANYDTOEDIT CheckExistProcessTrainingEdit(decimal pk_key)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckExistProcessTrainingEdit(pk_key);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool SendProcessTrainingEdit(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.SendProcessTrainingEdit(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool UpdateStatusProcessTrainingEdit(List<decimal> lstID, string status, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.UpdateStatusProcessTrainingEdit(lstID, status, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<HU_PRO_TRAIN_OUT_COMPANYDTOEDIT> GetApproveProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_ID desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetApproveProcessTrainingEdit(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<WorkingBeforeDTOEdit> GetWorkingBeforeEdit(WorkingBeforeDTOEdit _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetWorkingBeforeEdit(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertWorkingBeforeEdit(WorkingBeforeDTOEdit objWorkingBefore, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertWorkingBeforeEdit(objWorkingBefore, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWorkingBeforeEdit(WorkingBeforeDTOEdit objWorkingBefore, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWorkingBeforeEdit(objWorkingBefore, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteWorkingBeforeEdit(List<decimal> lstDecimals, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteWorkingBeforeEdit(lstDecimals, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public WorkingBeforeDTOEdit CheckExistWorkingBeforeEdit(decimal pk_key)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckExistWorkingBeforeEdit(pk_key);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool SendWorkingBeforeEdit(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.SendWorkingBeforeEdit(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool UpdateStatusWorkingBeforeEdit(List<decimal> lstID, string status, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.UpdateStatusWorkingBeforeEdit(lstID, status, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<WorkingBeforeDTOEdit> GetApproveWorkingBeforeEdit(WorkingBeforeDTOEdit _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_ID desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetApproveWorkingBeforeEdit(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }





        public List<HU_EMPLOYEE_BHDDTO> GetEmployeeBHLD(HU_EMPLOYEE_BHDDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, UserLog log, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeBHLD(_filter, PageIndex, PageSize, Total, _param, log, Sorts);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public HU_EMPLOYEE_BHDDTO GetEmployeeBHLDByID(HU_EMPLOYEE_BHDDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetEmployeeBHLDByID(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertEmployeeBHLD(HU_EMPLOYEE_BHDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertEmployeeBHLD(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyEmployeeBHLD(HU_EMPLOYEE_BHDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyEmployeeBHLD(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteEmployeeBHLD(HU_EMPLOYEE_BHDDTO objWorking, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteEmployeeBHLD(objWorking, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }




        public List<CalculateTongHopDTO> GetListCALCULATE(CalculateTongHopDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetListCALCULATE(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Calculate_data(int OrgId, int pv_year, int IsDissolve, int IsLoad, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.Calculate_data(OrgId, pv_year, IsDissolve, 1, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
