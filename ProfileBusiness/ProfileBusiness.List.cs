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
        public List<TitleDTO> GetTitle(TitleDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTitle(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertTitle(TitleDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertTitle(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateTitle(TitleDTO objTitle)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateTitle(objTitle);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyTitle(TitleDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyTitle(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveTitle(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveTitle(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteTitle(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteTitle(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProfileDAL.TitleDTO> GetTitleByID(decimal sID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTitleByID(sID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<BHLDDTO> GetBHLD(BHLDDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBHLD(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertBHLD(BHLDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertBHLD(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateBHLD(BHLDDTO objTitle)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateBHLD(objTitle);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyBHLD(BHLDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyBHLD(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveBHLD(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveBHLD(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteBHLD(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteBHLD(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<BHLDDTO> GetBHLDByID(decimal sID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBHLDByID(sID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<SizeDTO> GetSize(SizeDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSize(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertSize(SizeDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertSize(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateSize(SizeDTO objTitle)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateSize(objTitle);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifySize(SizeDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifySize(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveSize(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveSize(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteSize(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteSize(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<SizeDTO> GetSizeByID(decimal sID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSizeByID(sID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<SizeGiayDTO> GetSizeGiay(SizeGiayDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSizeGiay(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertSizeGiay(SizeGiayDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertSizeGiay(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateSizeGiay(SizeGiayDTO objTitle)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateSizeGiay(objTitle);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifySizeGiay(SizeGiayDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifySizeGiay(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveSizeGiay(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveSizeGiay(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteSizeGiay(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteSizeGiay(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<SizeGiayDTO> GetSizeGiayByID(decimal sID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetSizeGiayByID(sID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }





        public List<SizeGiaySettingDTO> GetAllSizeGiaySetting(SizeGiaySettingDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetAllSizeGiaySetting(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertSizeGiaySetting(SizeGiaySettingDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertSizeGiaySetting(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool ModifySizeGiaySetting(SizeGiaySettingDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifySizeGiaySetting(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool DeleteSizeGiaySetting(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteSizeGiaySetting(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }




        public List<SizeBHLDDTO> GetAllSizeBHLD(SizeBHLDDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "GENDER_NAME desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetAllSizeBHLD(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertSizeBHLD(SizeBHLDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertSizeBHLD(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifySizeBHLD(SizeBHLDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifySizeBHLD(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool DeleteSizeBHLD(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteSizeBHLD(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }









        public List<TitleConcurrentDTO> GetTitleConcurrent(TitleConcurrentDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetTitleConcurrent(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertTitleConcurrent(TitleConcurrentDTO objTitleConcurrent, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertTitleConcurrent(objTitleConcurrent, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyTitleConcurrent(TitleConcurrentDTO objTitleConcurrent, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyTitleConcurrent(objTitleConcurrent, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool DeleteTitleConcurrent(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteTitleConcurrent(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<ContractTypeDTO> GetContractType(ContractTypeDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetContractType(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool InsertContractType(ContractTypeDTO objContractType, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertContractType(objContractType, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateContractType(ContractTypeDTO objContractType)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateContractType(objContractType);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyContractType(ContractTypeDTO objContractType, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyContractType(objContractType, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveContractType(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveContractType(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteContractType(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteContractType(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<WelfareListDTO> GetWelfareList(WelfareListDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWelfareList(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertWelfareList(WelfareListDTO objWelfareList, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertWelfareList(objWelfareList, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateWelfareList(WelfareListDTO objWelfareList)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateWelfareList(objWelfareList);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWelfareList(WelfareListDTO objWelfareList, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWelfareList(objWelfareList, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveWelfareList(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveWelfareList(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteWelfareList(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteWelfareList(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<AllowanceListDTO> GetAllowanceList(AllowanceListDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetAllowanceList(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertAllowanceList(AllowanceListDTO objAllowanceList, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertAllowanceList(objAllowanceList, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateAllowanceList(AllowanceListDTO objAllowanceList)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateAllowanceList(objAllowanceList);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyAllowanceList(AllowanceListDTO objAllowanceList, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyAllowanceList(objAllowanceList, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveAllowanceList(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveAllowanceList(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteAllowanceList(AllowanceListDTO[] objAllowanceList, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteAllowanceList(objAllowanceList, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<OrganizationDTO> GetOrganization(string sACT)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOrganization(sACT);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public OrganizationDTO GetOrganizationByID(decimal ID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOrganizationByID(ID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertOrganization(OrganizationDTO objOrganization, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertOrganization(objOrganization, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateOrganization(OrganizationDTO objOrganization)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateOrganization(objOrganization);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateCostCenterCode(OrganizationDTO objOrganization)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateCostCenterCode(objOrganization);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckEmployeeInOrganization(List<decimal> lstID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckEmployeeInOrganization(lstID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyOrganization(OrganizationDTO objOrganization, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyOrganization(objOrganization, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool ModifyOrganizationPath(List<OrganizationPathDTO> lstPath)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyOrganizationPath(lstPath);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveOrganization(OrganizationDTO[] objOrganization, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveOrganization(objOrganization, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<OrgTitleDTO> GetOrgTitle(OrgTitleDTO filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetOrgTitle(filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertOrgTitle(List<OrgTitleDTO> objOrgTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertOrgTitle(objOrgTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool CheckTitleInEmployee(List<decimal> lstID, decimal orgID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.CheckTitleInEmployee(lstID, orgID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteOrgTitle(List<decimal> objOrgTitle, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteOrgTitle(objOrgTitle, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveOrgTitle(List<decimal> objOrgTitle, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveOrgTitle(objOrgTitle, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<TitleBHLDDTO> GetBHLDTitle(TitleBHLDDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBHLDTitle(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public TitleBHLDDTO GetBHLDTitleByID(TitleBHLDDTO _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetBHLDTitleByID(_filter);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertBHLDTitle(TitleBHLDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertBHLDTitle(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool ModifyBHLDTitle(TitleBHLDDTO objTitle, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyBHLDTitle(objTitle, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteBHLDTitle(TitleBHLDDTO objWorking, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteBHLDTitle(objWorking, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }




        public List<NationDTO> GetNation(NationDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetNation(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertNation(NationDTO objNation, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertNation(objNation, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyNation(NationDTO objNation, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyNation(objNation, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateNation(NationDTO objNation)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateNation(objNation);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveNation(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveNation(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteNation(List<decimal> lstDecimals, UserLog log, ref string strError)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteNation(lstDecimals, log, strError);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<ProvinceDTO> GetProvinceByNationID(decimal sNationID, string sACTFLG)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetProvinceByNationID(sNationID, sACTFLG);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public List<ProvinceDTO> GetProvinceByNationCode(string sNationCode, string sACTFLG)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetProvinceByNationCode(sNationCode, sACTFLG);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ProvinceDTO> GetProvince(ProvinceDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetProvince(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertProvince(ProvinceDTO objProvince, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertProvince(objProvince, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyProvince(ProvinceDTO objProvince, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyProvince(objProvince, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateProvince(ProvinceDTO objProvince)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateProvince(objProvince);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveProvince(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveProvince(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteProvince(List<decimal> lstDecimals, UserLog log, ref string strError)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteProvince(lstDecimals, log, strError);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<DistrictDTO> GetDistrictByProvinceID(decimal sProvinceID, string sACTFLG)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetDistrictByProvinceID(sProvinceID, sACTFLG);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<DistrictDTO> GetDistrict(DistrictDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetDistrict(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertDistrict(DistrictDTO objDistrict, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertDistrict(objDistrict, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyDistrict(DistrictDTO objDistrict, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyDistrict(objDistrict, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateDistrict(DistrictDTO objData)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateDistrict(objData);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveDistrict(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveDistrict(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteDistrict(List<decimal> lstDecimals, UserLog log, ref string strError)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteDistrict(lstDecimals, log, strError);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Ward_DTO> GetWardByDistrictID(decimal sDistrictID, string sACTFLG)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWardByDistrictID(sDistrictID, sACTFLG);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<Ward_DTO> GetWard(Ward_DTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWard(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateWard(Ward_DTO objData)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateWard(objData);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertWard(Ward_DTO objDistrict, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertWard(objDistrict, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWard(Ward_DTO objDistrict, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWard(objDistrict, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveWard(List<decimal> lstID, UserLog log, string bActive)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveWard(lstID, log, bActive);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteWard(List<decimal> lstID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteWard(lstID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<BankDTO> GetBank(BankDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBank(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertBank(BankDTO objBank, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertBank(objBank, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyBank(BankDTO objBank, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyBank(objBank, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateBank(BankDTO objBank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateBank(objBank);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveBank(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveBank(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteBank(List<decimal> lstDecimals, UserLog log, ref string strError)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteBank(lstDecimals, log, strError);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public List<BankBranchDTO> GetBankBranchByBankID(decimal sBank_ID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBankBranchByBankID(sBank_ID);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<BankBranchDTO> GetBankBranch(BankBranchDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetBankBranch(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertBankBranch(BankBranchDTO objBankBranch, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertBankBranch(objBankBranch, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyBankBranch(BankBranchDTO objBankBranch, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyBankBranch(objBankBranch, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateBankBranch(BankBranchDTO objBankBranch)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateBankBranch(objBankBranch);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveBankBranch(List<decimal> lstID, string sActive, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveBankBranch(lstID, sActive, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool DeleteBankBranch(List<decimal> lstDecimals, UserLog log, ref string strError)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteBankBranch(lstDecimals, log, strError);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<StaffRankDTO> GetStaffRank(StaffRankDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetStaffRank(_filter, PageIndex, PageSize, Total, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertStaffRank(StaffRankDTO objStaffRank, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertStaffRank(objStaffRank, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ValidateStaffRank(StaffRankDTO objStaffRank)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ValidateStaffRank(objStaffRank);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyStaffRank(StaffRankDTO objStaffRank, UserLog log, ref decimal gID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyStaffRank(objStaffRank, log, gID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveStaffRank(List<decimal> lstID, UserLog log, string sActive)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ActiveStaffRank(lstID, log, sActive);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        public bool DeleteStaffRank(StaffRankDTO[] lstStaffRank, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteStaffRank(lstStaffRank, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }



        public List<ATPeriodDTO> GetPeriodbyYear(decimal year)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetPeriodbyYear(year);
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
