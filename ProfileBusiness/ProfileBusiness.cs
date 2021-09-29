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
    public class ProfileBusiness : IProfileBusiness
    {
        public DataTable GetOtherList(string sType, string sLang, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOtherList(sType, sLang, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool OpenBusinessByID(string sAction, List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.OpenBusinessByID(sAction, lstID, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetBankList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBankList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetBankBranchList(decimal bankID, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBankBranchList(bankID, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetTitleByOrgID(decimal orgID, string sLang, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTitleByOrgID(orgID, sLang, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetTitleList(string sLang, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTitleList(sLang, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetWardList(decimal districtID, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWardList(districtID, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetDistrictList(decimal provinceID, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetDistrictList(provinceID, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public DataTable GetSizeBHLDTheoGioiTinh(decimal GenderID, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSizeBHLDTheoGioiTinh(GenderID, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetSizeGiayTheoGioiTinh(decimal GenderID, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSizeGiayTheoGioiTinh(GenderID, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public DataTable GetProvinceList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetProvinceList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetNationList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetNationList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetStaffRankList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetStaffRankList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetSalaryGroupList(DateTime dateValue, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSalaryGroupList(dateValue, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetSalaryLevelList(decimal salGroupID, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSalaryLevelList(salGroupID, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetSalaryRankList(decimal salLevelID, bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSalaryRankList(salLevelID, isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetHU_AllowanceList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetHU_AllowanceList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetPA_ObjectSalary(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetPA_ObjectSalary(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetOT_WageTypeList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOT_WageTypeList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetOT_MissionTypeList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOT_MissionTypeList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetOT_TripartiteTypeList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOT_TripartiteTypeList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetHU_TemplateType(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetHU_TemplateType(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetHU_MergeFieldList(bool isBlank, decimal isTemplateType)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetHU_MergeFieldList(isBlank, isTemplateType);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetHU_TemplateList(bool isBlank, decimal isTemplateType)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetHU_TemplateList(isBlank, isTemplateType);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetHU_DataDynamic(decimal dID, decimal tempID, ref string folderName)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetHU_DataDynamic(dID, tempID, folderName);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckExistInDatabase(List<decimal> lstID, ProfileCommon.TABLE_NAME table)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.CheckExistInDatabase(lstID, table);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string AutoGenCode(string firstChar, string tableName, string colName)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.AutoGenCode(firstChar, tableName, colName);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool UpdateMergeField(List<MergeFieldDTO> lstData, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.UpdateMergeField(lstData, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet GetDataPrintBBBR(decimal id)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetDataPrintBBBR(id);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet GetDataPrintBBBR3B(decimal id)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetDataPrintBBBR3B(id);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetInsRegionList(bool isBlank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetInsRegionList(isBlank);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<OrganizationDTO> GetAllOrgDisplays()
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOrgsTree;
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public bool GetComboList(ref ProfileDAL.ComboBoxDataDTO _combolistDTO)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetComboList(_combolistDTO);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckAndUpdateEmployeeInformation()
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckAndUpdateEmployeeInformation;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckAndSendMailReminder()
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckAndSendMailReminder;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<Se_ReportDTO> GetReportById(Se_ReportDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log, string Sorts = "CODE ASC")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetReportById(_filter, PageIndex, PageSize, Total, log, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable ProfileReport(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, int sOrg, string sUserName, string sLang)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ProfileReport(sPkgName, sStartDate, sEndDate, sOrg, sUserName, sLang);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet GetEmployeeCVByID(string sPkgName, string sEmployee_id)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetEmployeeCVByID(sPkgName, sEmployee_id);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet ExportReport(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ExportReport(sPkgName, sStartDate, sEndDate, sOrg, IsDissolve, sUserName, sLang);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet ExportReport_0107(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ExportReport_0107(sPkgName, sStartDate, sEndDate, sOrg, IsDissolve, sUserName, sLang);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet ExportReport_0108(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ExportReport_0108(sPkgName, sStartDate, sEndDate, sOrg, IsDissolve, sUserName, sLang);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet ExportReport_0115(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ExportReport_0115(sPkgName, sStartDate, sEndDate, sOrg, IsDissolve, sUserName, sLang);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public DataSet ExportRPT_CHITIET(string sPkgName, decimal sYear, string sOrgId, decimal IsDissolve, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ExportRPT_CHITIET(sPkgName, sYear, sOrgId, IsDissolve, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataSet ExportRPT_TH(string sPkgName, decimal sYear, string sOrgId, decimal IsDissolve, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ExportRPT_CHITIET(sPkgName, sYear, sOrgId, IsDissolve, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
