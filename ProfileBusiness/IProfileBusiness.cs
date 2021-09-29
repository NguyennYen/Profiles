// NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
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
using ProfileDAL;
using Framework.Data;

namespace ProfileBusiness.ServiceContracts
{
    [ServiceContract()]
    public interface IProfileBusiness
    {
        [OperationContract()]
        List<OrganizationDTO> GetOrgsTree();



        [OperationContract()]
        DataTable GetOtherList(string sType, string sLang, bool isBlank);

        [OperationContract()]
        DataTable GetBankList(bool isBlank);

        [OperationContract()]
        DataTable GetBankBranchList(decimal bankID, bool isBlank);

        [OperationContract()]
        DataTable GetTitleByOrgID(decimal orgID, string sLang, bool isBlank);

        [OperationContract()]
        DataTable GetTitleList(string sLang, bool isBlank);

        [OperationContract()]
        DataTable GetWardList(decimal districtID, bool isBlank);

        [OperationContract()]
        DataTable GetSizeBHLDTheoGioiTinh(decimal GenderID, bool isBlank);
        [OperationContract()]
        DataTable GetSizeGiayTheoGioiTinh(decimal GenderID, bool isBlank);

        [OperationContract()]
        DataTable GetDistrictList(decimal provinceID, bool isBlank);

        [OperationContract()]
        DataTable GetProvinceList(bool isBlank);

        [OperationContract()]
        DataTable GetNationList(bool isBlank);

        [OperationContract()]
        DataTable GetStaffRankList(bool isBlank);

        [OperationContract()]
        DataTable GetSalaryGroupList(DateTime dateValue, bool isBlank);

        [OperationContract()]
        DataTable GetSalaryLevelList(decimal salGroupID, bool isBlank);

        [OperationContract()]
        DataTable GetSalaryRankList(decimal salLevelID, bool isBlank);

        [OperationContract()]
        DataTable GetHU_AllowanceList(bool isBlank);

        [OperationContract()]
        DataTable GetPA_ObjectSalary(bool isBlank);

        [OperationContract()]
        DataTable GetOT_WageTypeList(bool isBlank);

        [OperationContract()]
        DataTable GetOT_MissionTypeList(bool isBlank);

        [OperationContract()]
        DataTable GetOT_TripartiteTypeList(bool isBlank);

        [OperationContract()]
        DataTable GetHU_TemplateType(bool isBlank);

        [OperationContract()]
        DataTable GetHU_MergeFieldList(bool isBlank, decimal isTemplateType);

        [OperationContract()]
        DataTable GetHU_TemplateList(bool isBlank, decimal isTemplateType);

        [OperationContract()]
        DataTable GetHU_DataDynamic(decimal dID, decimal tempID, ref string folderName);

        [OperationContract()]
        DataTable GetInsRegionList(bool isBlank);


        [OperationContract()]
        bool OpenBusinessByID(string sAction, List<decimal> lstID, UserLog log);



        [OperationContract()]
        bool CheckExistInDatabase(List<decimal> lstID, ProfileCommon.TABLE_NAME table);

        [OperationContract()]
        string AutoGenCode(string firstChar, string tableName, string colName);

        [OperationContract()]
        bool UpdateMergeField(List<MergeFieldDTO> lstData, UserLog log);

        [OperationContract()]
        DataSet GetDataPrintBBBR(decimal id);

        [OperationContract()]
        DataSet GetDataPrintBBBR3B(decimal id);




        [OperationContract()]
        List<TitleDTO> GetTitle(TitleDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertTitle(TitleDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateTitle(TitleDTO objTitle);

        [OperationContract()]
        bool ModifyTitle(TitleDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveTitle(List<decimal> lstID, string sActive, UserLog log);

        [OperationContract()]
        bool DeleteTitle(List<decimal> lstID, UserLog log);

        /// <summary>
        ///         ''' Lay danh sach TitleByID
        ///         ''' </summary>
        ///         ''' <returns>danh sach Title</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<TitleDTO> GetTitleByID(decimal sID);



        [OperationContract()]
        List<TitleConcurrentDTO> GetTitleConcurrent(TitleConcurrentDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertTitleConcurrent(TitleConcurrentDTO objTitleConcurrent, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyTitleConcurrent(TitleConcurrentDTO objTitleConcurrent, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteTitleConcurrent(List<decimal> lstID, UserLog log);



        [OperationContract()]
        List<ContractTypeDTO> GetContractType(ContractTypeDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertContractType(ContractTypeDTO objContractType, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateContractType(ContractTypeDTO objContractType);

        [OperationContract()]
        bool ModifyContractType(ContractTypeDTO objContractType, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveContractType(List<decimal> lstID, string sActive, UserLog log);

        [OperationContract()]
        bool DeleteContractType(List<decimal> lstID, UserLog log);



        [OperationContract()]
        List<BHLDDTO> GetBHLD(BHLDDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertBHLD(BHLDDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateBHLD(BHLDDTO _validate);

        [OperationContract()]
        bool ModifyBHLD(BHLDDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveBHLD(List<decimal> lstID, string sActive, UserLog log);

        [OperationContract()]
        bool DeleteBHLD(List<decimal> lstID, UserLog log);

        [OperationContract()]
        List<BHLDDTO> GetBHLDByID(decimal sID);



        [OperationContract()]
        List<SizeDTO> GetSize(SizeDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertSize(SizeDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateSize(SizeDTO _validate);

        [OperationContract()]
        bool ModifySize(SizeDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveSize(List<decimal> lstID, string sActive, UserLog log);

        [OperationContract()]
        bool DeleteSize(List<decimal> lstID, UserLog log);

        [OperationContract()]
        List<SizeDTO> GetSizeByID(decimal sID);




        [OperationContract()]
        List<SizeGiayDTO> GetSizeGiay(SizeGiayDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertSizeGiay(SizeGiayDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateSizeGiay(SizeGiayDTO _validate);

        [OperationContract()]
        bool ModifySizeGiay(SizeGiayDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveSizeGiay(List<decimal> lstID, string sActive, UserLog log);

        [OperationContract()]
        bool DeleteSizeGiay(List<decimal> lstID, UserLog log);

        [OperationContract()]
        List<SizeGiayDTO> GetSizeGiayByID(decimal sID);






        [OperationContract()]
        List<SizeGiaySettingDTO> GetAllSizeGiaySetting(SizeGiaySettingDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertSizeGiaySetting(SizeGiaySettingDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifySizeGiaySetting(SizeGiaySettingDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteSizeGiaySetting(List<decimal> lstID, UserLog log);




        [OperationContract()]
        List<SizeBHLDDTO> GetAllSizeBHLD(SizeBHLDDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "GENDER_NAME desc");

        [OperationContract()]
        bool InsertSizeBHLD(SizeBHLDDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifySizeBHLD(SizeBHLDDTO objTitle, UserLog log, ref decimal gID);
        [OperationContract()]
        bool DeleteSizeBHLD(List<decimal> lstID, UserLog log);





        [OperationContract()]
        List<HU_WELFARE_AUTODTO> GetHU_WELFARE_AUTODTO(HU_WELFARE_AUTODTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);

        [OperationContract()]
        List<ATPeriodDTO> LOAD_PERIODBylinq(ATPeriodDTO obj, UserLog log);

        [OperationContract()]
        bool ModifyHU_WELFARE_AUTO(List<HU_WELFARE_AUTODTO> lstWelfare, UserLog log);

        [OperationContract()]
        List<WelfareListDTO> GetWelfareList(WelfareListDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertWelfareList(WelfareListDTO objWelfareList, UserLog log, ref decimal gID);
        [OperationContract()]
        bool ValidateWelfareList(WelfareListDTO objWelfareList);

        [OperationContract()]
        bool ModifyWelfareList(WelfareListDTO objWelfareList, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveWelfareList(List<decimal> lstID, string sActive, UserLog log);

        [OperationContract()]
        bool DeleteWelfareList(List<decimal> lstID, UserLog log);

        [OperationContract()]
        bool Calculate_WelfareAuto(WelfareMngDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log);


        [OperationContract()]
        List<AllowanceListDTO> GetAllowanceList(AllowanceListDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertAllowanceList(AllowanceListDTO objAllowanceList, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateAllowanceList(AllowanceListDTO objAllowanceList);

        [OperationContract()]
        bool ModifyAllowanceList(AllowanceListDTO objAllowanceList, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveAllowanceList(List<decimal> lstID, string sActive, UserLog log);

        [OperationContract()]
        bool DeleteAllowanceList(AllowanceListDTO[] lstAllowanceList, UserLog log);



        [OperationContract()]
        List<OrganizationDTO> GetOrganization(string sACT);

        [OperationContract()]
        OrganizationDTO GetOrganizationByID(decimal ID);

        [OperationContract()]
        bool InsertOrganization(OrganizationDTO objOrganization, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateOrganization(OrganizationDTO objOrganization);

        [OperationContract()]
        bool ValidateCostCenterCode(OrganizationDTO objOrganization);

        [OperationContract()]
        bool CheckEmployeeInOrganization(List<decimal> lstID);

        [OperationContract()]
        bool ModifyOrganization(OrganizationDTO objOrganization, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyOrganizationPath(List<OrganizationPathDTO> lstPath);

        [OperationContract()]
        bool ActiveOrganization(OrganizationDTO[] objOrganization, string sActive, UserLog log);


        [OperationContract()]
        List<OrgTitleDTO> GetOrgTitle(OrgTitleDTO filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertOrgTitle(List<OrgTitleDTO> objOrgTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool CheckTitleInEmployee(List<decimal> lstID, decimal orgID);

        [OperationContract()]
        bool DeleteOrgTitle(List<decimal> objOrgTitle, UserLog log);

        [OperationContract()]
        bool ActiveOrgTitle(List<decimal> objOrgTitle, string sActive, UserLog log);



        [OperationContract()]
        List<TitleBHLDDTO> GetBHLDTitle(TitleBHLDDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        TitleBHLDDTO GetBHLDTitleByID(TitleBHLDDTO _filter);

        [OperationContract()]
        bool InsertBHLDTitle(TitleBHLDDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyBHLDTitle(TitleBHLDDTO objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteBHLDTitle(TitleBHLDDTO objWorking, UserLog log);



        /// <summary>
        ///         ''' Lay danh sach Quoc gia
        ///         ''' </summary>
        ///         ''' <returns>danh sach Quoc gia</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<NationDTO> GetNation(NationDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        // ------------------------------------------------------------------------

        /// <summary>
        ///         ''' Them moi Quoc gia
        ///         ''' </summary>
        ///         ''' <param name="objNation"> Doi tuong quoc gia can Insert</param>
        ///         ''' <param name="log"> Doi tuong chua thong tin log</param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertNation(NationDTO objNation, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Sua thong tin Quoc gia
        ///         ''' </summary>
        ///         ''' <param name="objNation">doi tuong chua cac thong tin can sua</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyNation(NationDTO objNation, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateNation(NationDTO objNation);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Áp dụng/ ngưng áp dụng Quoc gia
        ///         ''' </summary>
        ///         ''' <param name="objNation">doi tuong chua thong tin can xoa</param>
        ///         ''' <param name="sActive">trang thai</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ActiveNation(List<decimal> lstID, string sActive, UserLog log);

        /// <summary>
        ///         ''' Xóa danh mục quốc gia
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="strError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteNation(List<decimal> lstDecimals, UserLog log, ref string strError);

        /// <summary>
        ///         ''' Lay danh sach tinh thanh theo quoc gia
        ///         ''' </summary>
        ///         ''' <param name="sNationID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<ProvinceDTO> GetProvinceByNationID(decimal sNationID, string sACTFLG);


        [OperationContract()]
        List<ProvinceDTO> GetProvinceByNationCode(string sNationCode, string sACTFLG);


        /// <summary>
        ///         ''' Lay danh sach Tinh thanh
        ///         ''' </summary>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<ProvinceDTO> GetProvince(ProvinceDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        // ------------------------------------------------------------------------

        /// <summary>
        ///         ''' Them moi Tinh thanh
        ///         ''' </summary>
        ///         ''' <param name="objProvince"> Doi tuong Tinh thanh can Insert</param>
        ///         ''' <param name="log"> Doi tuong chua thong tin log</param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertProvince(ProvinceDTO objProvince, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Sua thong tin Tinh thanh
        ///         ''' </summary>
        ///         ''' <param name="objProvince">doi tuong chua cac thong tin can sua</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyProvince(ProvinceDTO objProvince, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateProvince(ProvinceDTO objProvince);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Áp dụng/ ngưng áp dụng Tinh thanh
        ///         ''' </summary>
        ///         ''' <param name="objProvince">doi tuong chua thong tin can xoa</param>
        ///         ''' <param name="sActive">trang thai</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ActiveProvince(List<decimal> lstID, string sActive, UserLog log);

        /// <summary>
        ///         ''' Xóa danh mục tỉnh thành
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="strError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteProvince(List<decimal> lstDecimals, UserLog log, ref string strError);

        /// <summary>
        ///         ''' Lay danh sach Quan Huyen
        ///         ''' </summary>
        ///         ''' <returns>danh sach Quan Huyen</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<DistrictDTO> GetDistrict(DistrictDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        // ------------------------------------------------------------------------

        /// <summary>
        ///         ''' Lay danh sach quan huyen theo ProvinceID
        ///         ''' </summary>
        ///         ''' <param name="sProvinceID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<DistrictDTO> GetDistrictByProvinceID(decimal sProvinceID, string sACTFLG);

        // ------------------------------------------------------------------------

        /// <summary>
        ///         ''' Them moi Quan Huyen
        ///         ''' </summary>
        ///         ''' <param name="objDistrict"> Doi tuong Quan Huyen can Insert</param>
        ///         ''' <param name="log"> Doi tuong chua thong tin log</param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertDistrict(DistrictDTO objDistrict, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Sua thong tin Quan Huyen
        ///         ''' </summary>
        ///         ''' <param name="objDistrict">doi tuong chua cac thong tin can sua</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyDistrict(DistrictDTO objDistrict, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        [OperationContract()]
        bool ValidateDistrict(DistrictDTO _validate);

        /// <summary>
        ///         ''' Áp dụng/ ngưng áp dụng Quan Huyen
        ///         ''' </summary>
        ///         ''' <param name="objDistrict">doi tuong chua thong tin can xoa</param>
        ///         ''' <param name="sActive">trang thai</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ActiveDistrict(List<decimal> lstID, string sActive, UserLog log);

        /// <summary>
        ///         ''' Xóa danh mục quận huyện
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="strError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteDistrict(List<decimal> lstDecimals, UserLog log, ref string strError);


        /// <summary>
        ///         ''' Lay danh sach Quan Huyen
        ///         ''' </summary>
        ///         ''' <returns>danh sach Quan Huyen</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<Ward_DTO> GetWard(Ward_DTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        // ------------------------------------------------------------------------

        /// <summary>
        ///         ''' Lay danh sach xã phường theo districtID
        ///         ''' </summary>
        ///         ''' <param name="sProvinceID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<Ward_DTO> GetWardByDistrictID(decimal sDistrictID, string sACTFLG);

        // ------------------------------------------------------------------------

        /// <summary>
        ///         ''' Them moi xã phường
        ///         ''' </summary>
        ///         ''' <param name="objDistrict"> Doi tuong Quan Huyen can Insert</param>
        ///         ''' <param name="log"> Doi tuong chua thong tin log</param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertWard(Ward_DTO objWard, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Sua thong tin xã phường
        ///         ''' </summary>
        ///         ''' <param name="objDistrict">doi tuong chua cac thong tin can sua</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyWard(Ward_DTO objWard, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        [OperationContract()]
        bool ValidateWard(Ward_DTO _validate);
        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Áp dụng/ ngưng áp dụng xã phường
        ///         ''' </summary>
        ///         ''' <param name="objDistrict">doi tuong chua thong tin can xoa</param>
        ///         ''' <param name="sActive">trang thai</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ActiveWard(List<decimal> lstID, UserLog log, string bActive);
        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Xóa danh mục xã phường
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="strError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteWard(List<decimal> lstID, UserLog log);

        /// <summary>
        ///         ''' Lay danh sach Ngan hang
        ///         ''' </summary>
        ///         ''' <returns>danh sach Ngan hang</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<BankDTO> GetBank(BankDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        // ------------------------------------------------------------------------
        /// <summary>
        ///         ''' Them moi Ngan hang
        ///         ''' </summary>
        ///         ''' <param name="objBank"> Doi tuong Ngan hang can Insert</param>
        ///         ''' <param name="log"> Doi tuong chua thong tin log</param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertBank(BankDTO objBank, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Sua thong tin Ngan hang
        ///         ''' </summary>
        ///         ''' <param name="objBank">doi tuong chua cac thong tin can sua</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyBank(BankDTO objBank, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateBank(BankDTO objBank);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Áp dụng/ ngưng áp dụng Ngan hang
        ///         ''' </summary>
        ///         ''' <param name="objBank">doi tuong chua thong tin can xoa</param>
        ///         ''' <param name="sActive">trang thai</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ActiveBank(List<decimal> lstID, string sActive, UserLog log);

        /// <summary>
        ///         ''' Xóa danh mục ngân hàng
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="strError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteBank(List<decimal> lstDecimals, UserLog log, ref string strError);

        /// <summary>
        ///         ''' Lay danh sach Chi nhanh Ngan hang
        ///         ''' </summary>
        ///         ''' <returns>danh sach Chi nhanh Ngan hang</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<BankBranchDTO> GetBankBranch(BankBranchDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        /// <summary>
        ///         ''' Lay danh sach Chi nhanh Ngan hang theo Bank_ID
        ///         ''' </summary>
        ///         ''' <returns>danh sach Chi nhanh Ngan hang</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<BankBranchDTO> GetBankBranchByBankID(decimal sBank_Id);


        // ------------------------------------------------------------------------
        /// <summary>
        ///         ''' Them moi Chi nhanh Ngan hang
        ///         ''' </summary>
        ///         ''' <param name="objBankBranch"> Doi tuong Chi nhanh Ngan hang can Insert</param>
        ///         ''' <param name="log"> Doi tuong chua thong tin log</param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertBankBranch(BankBranchDTO objBankBranch, UserLog log, ref decimal gID);

        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Sua thong tin Chi nhanh Ngan hang
        ///         ''' </summary>
        ///         ''' <param name="objBankBranch">doi tuong chua cac thong tin can sua</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyBankBranch(BankBranchDTO objBankBranch, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateBankBranch(BankBranchDTO objBankBranch);
        // -----------------------------------------------------------------------

        /// <summary>
        ///         ''' Áp dụng/ ngưng áp dụng Chi nhanh Ngan hang
        ///         ''' </summary>
        ///         ''' <param name="objBankBranch">doi tuong chua thong tin can xoa</param>
        ///         ''' <param name="sActive">trang thai</param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns>true?false</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ActiveBankBranch(List<decimal> lstID, string sActive, UserLog log);

        /// <summary>
        ///         ''' Xóa danh mcuj chi nhánh ngân hàng
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="strError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteBankBranch(List<decimal> lstDecimals, UserLog log, ref string strError);


        [OperationContract()]
        List<StaffRankDTO> GetStaffRank(StaffRankDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        bool InsertStaffRank(StaffRankDTO objStaffRank, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateStaffRank(StaffRankDTO objStaffRank);

        [OperationContract()]
        bool ModifyStaffRank(StaffRankDTO objStaffRank, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ActiveStaffRank(List<decimal> lstID, UserLog log, string sActive);

        [OperationContract()]
        bool DeleteStaffRank(StaffRankDTO[] lstStaffRank, UserLog log);







        /// <summary>
        ///         ''' Lay thong tin nhan vien tu EmployeeCode
        ///         ''' </summary>
        ///         ''' <param name="sEmployeeCode"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        EmployeeDTO GetEmployeeByEmployeeID(decimal empID);


        /// <summary>
        ///         ''' Trả về binary của ảnh hồ sơ nhân viên
        ///         ''' </summary>
        ///         ''' <param name="gEmpID"></param>
        ///         ''' <param name="sError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        byte[] GetEmployeeImage(decimal gEmpID, ref string sError);

        /// <summary>
        ///         ''' Thêm mới nhân viên
        ///         ''' </summary>
        ///         ''' <param name="objEmp"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="gID"></param>
        ///         ''' <param name="objEmpCV"></param>
        ///         ''' <param name="objEmpEdu"></param>
        ///         ''' <param name="objEmpOther"></param>
        ///         ''' <param name="objBankAccLog"></param>
        ///         ''' <param name="objEmpHealth"></param>
        ///         ''' <param name="objEmpSalary"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertEmployee(EmployeeDTO objEmp, UserLog log, ref decimal gID, ref string _strEmpCode, byte[] _imageBinary, EmployeeCVDTO objEmpCV = null/* TODO Change to default(_) if this is not a reference type */, EmployeeEduDTO objEmpEdu = null/* TODO Change to default(_) if this is not a reference type */, EmployeeHealthDTO objEmpHealth = null/* TODO Change to default(_) if this is not a reference type */);

        /// <summary>
        ///         ''' Sửa thông tin nhân viên
        ///         ''' </summary>
        ///         ''' <param name="objEmp"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="gID"></param>
        ///         ''' <param name="objEmpCV"></param>
        ///         ''' <param name="objEmpEdu"></param>
        ///         ''' <param name="objEmpOther"></param>
        ///         ''' <param name="objBankAccLog"></param>
        ///         ''' <param name="objEmpHealth"></param>
        ///         ''' <param name="objEmpSalary"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyEmployee(EmployeeDTO objEmp, UserLog log, ref decimal gID, byte[] _imageBinary, EmployeeCVDTO objEmpCV = null/* TODO Change to default(_) if this is not a reference type */, EmployeeEduDTO objEmpEdu = null/* TODO Change to default(_) if this is not a reference type */, EmployeeHealthDTO objEmpHealth = null/* TODO Change to default(_) if this is not a reference type */);

        /// <summary>
        ///         ''' Lấy danh sách nhân viên theo điều kiện
        ///         ''' </summary>
        ///         ''' <param name="_orgIds"></param>s
        ///         ''' <param name="_filter"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<OrgChartDTO> GetEmployeeOrgChart(List<decimal> lstOrg, UserLog log = null/* TODO Change to default(_) if this is not a reference type */);

        /// <summary>
        ///         ''' Lấy danh sách nhân viên bao gồm ảnh để hiển thị trên org chart
        ///         ''' </summary>
        ///         ''' <param name="_orgIds"></param>
        ///         ''' <param name="_filter"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<EmployeeDTO> GetListEmployee(List<decimal> _orgIds, EmployeeDTO _filter);


        /// <summary>
        ///         ''' Lấy danh sách nhân viên có phân trang
        ///         ''' </summary>
        ///         ''' <param name="PageIndex"></param>
        ///         ''' <param name="PageSize"></param>
        ///         ''' <param name="Total"></param>
        ///         ''' <param name="_orgIds"></param>
        ///         ''' <param name="_filter"></param>
        ///         ''' <param name="Sorts"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<EmployeeDTO> GetListEmployeePaging(EmployeeDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);
        [OperationContract()]
        List<EmployeeDTO> GetListEmployeePortal(EmployeeDTO _filter);

        /// <summary>
        ///         ''' Lấy thông tin EmployeeCV 
        ///         ''' </summary>
        ///         ''' <param name="sEmployeeID">ID(Decimal) của nhân viên</param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool GetEmployeeAllByID(decimal sEmployeeID, ref EmployeeCVDTO empCV, ref EmployeeEduDTO empEdu, ref EmployeeHealthDTO empHealth);

        /// <summary>
        ///         ''' Xóa nhân viên
        ///         ''' </summary>
        ///         ''' <param name="lstEmpID"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="sError"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteEmployee(List<decimal> lstEmpID, UserLog log, ref string sError);

        [OperationContract()]
        bool ValidateEmployee(string sEmpCode, string value, string sType);

        /// <summary>
        ///         ''' Hàm kiểm tra nhân viên đã có hợp đồng chưa
        ///         ''' </summary>
        ///         ''' <param name="strEmpCode"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool CheckEmpHasContract(string strEmpCode);

        [OperationContract()]
        bool UnactiveEmployee(List<decimal> lstID, string sActive, UserLog log);


        [OperationContract()]
        bool InsertEmployeeEdit(EmployeeEditDTO objEmployeeEdit, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyEmployeeEdit(EmployeeEditDTO objEmployeeEdit, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteEmployeeEdit(List<decimal> lstDecimals, UserLog log);

        [OperationContract()]
        EmployeeEditDTO GetEmployeeEditByID(EmployeeEditDTO _filter);

        [OperationContract()]
        bool SendEmployeeEdit(List<decimal> lstID, UserLog log);

        [OperationContract()]
        bool UpdateStatusEmployeeEdit(List<decimal> lstID, string status, UserLog log);

        [OperationContract()]
        List<EmployeeEditDTO> GetApproveEmployeeEdit(EmployeeEditDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);


        /// <summary>
        ///         ''' Lay danh sach than nhan
        ///         ''' </summary>
        ///         ''' <param name="_filter"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<FamilyDTO> GetEmployeeFamily(FamilyDTO _filter);

        /// <summary>
        ///         ''' Them moi nhan than
        ///         ''' </summary>
        ///         ''' <param name="objFamily"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="gID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertEmployeeFamily(FamilyDTO objFamily, UserLog log, ref decimal gID);

        /// <summary>
        ///         ''' Chinh sua thong tin nhan than
        ///         ''' </summary>
        ///         ''' <param name="objFamily"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="gID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyEmployeeFamily(FamilyDTO objFamily, UserLog log, ref decimal gID);

        /// <summary>
        ///         ''' Xóa nhân thân
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteEmployeeFamily(List<decimal> lstDecimals, UserLog log);


        /// <summary>
        ///         ''' Check trùng CMND của nhân thân.
        ///         ''' </summary>
        ///         ''' <param name="_validate"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ValidateFamily(FamilyDTO _validate);

        /// <summary>
        ///         ''' Lay danh sach than nhan
        ///         ''' </summary>
        ///         ''' <param name="_filter"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<FamilyEditDTO> GetEmployeeFamilyEdit(FamilyEditDTO _filter);

        /// <summary>
        ///         ''' Them moi nhan than
        ///         ''' </summary>
        ///         ''' <param name="objFamilyEdit"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="gID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool InsertEmployeeFamilyEdit(FamilyEditDTO objFamilyEdit, UserLog log, ref decimal gID);

        /// <summary>
        ///         ''' Chinh sua thong tin nhan than
        ///         ''' </summary>
        ///         ''' <param name="objFamilyEdit"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <param name="gID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool ModifyEmployeeFamilyEdit(FamilyEditDTO objFamilyEdit, UserLog log, ref decimal gID);

        /// <summary>
        ///         ''' Xóa nhân thân
        ///         ''' </summary>
        ///         ''' <param name="lstDecimals"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool DeleteEmployeeFamilyEdit(List<decimal> lstDecimals, UserLog log);

        [OperationContract()]
        FamilyEditDTO CheckExistFamilyEdit(decimal pk_key);

        [OperationContract()]
        bool SendEmployeeFamilyEdit(List<decimal> lstID, UserLog log);

        [OperationContract()]
        bool UpdateStatusEmployeeFamilyEdit(List<decimal> lstID, string status, UserLog log);

        [OperationContract()]
        List<FamilyEditDTO> GetApproveFamilyEdit(FamilyEditDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);




        [OperationContract()]
        List<WorkingBeforeDTO> GetEmpWorkingBefore(WorkingBeforeDTO _filter);

        [OperationContract()]
        bool InsertWorkingBefore(WorkingBeforeDTO objWorkingBefore, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyWorkingBefore(WorkingBeforeDTO objWorkingBefore, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteWorkingBefore(List<decimal> lstDecimals, UserLog log);


        [OperationContract()]
        List<ContractDTO> GetContract(ContractDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);

        [OperationContract()]
        ContractDTO GetContractByID(ContractDTO _filter);

        [OperationContract()]
        bool ValidateContract(string sType, ContractDTO obj);

        [OperationContract()]
        bool InsertContract(ContractDTO objContract, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyContract(ContractDTO objContract, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteContract(ContractDTO objAssetMng);

        [OperationContract()]
        string CreateContractNo(ContractDTO objAssetMng);

        [OperationContract()]
        bool CheckContractNo(ContractDTO objAssetMng);

        [OperationContract()]
        EmployeeDTO GetContractEmployeeByID(decimal gEmployeeID);

        [OperationContract()]
        bool UnApproveContract(ContractDTO objContract, UserLog log, ref decimal gID);


        [OperationContract()]
        DataTable GetWelfareListAuto(WelfareMngDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log);
        [OperationContract()]
        List<WelfareMngDTO> GetWelfareMng(WelfareMngDTO _filter, int IsDissolve, int PageIndex, int PageSize, ref int Total, UserLog UserLog, string Sorts = "CREATED_DATE desc");
        [OperationContract()]
        WelfareMngDTO GetWelfareMngById(int Id);

        [OperationContract()]
        bool CheckWelfareMngEffect(List<WelfareMngDTO> _filter);

        [OperationContract()]
        bool InsertWelfareMng(List<WelfareMngDTO> lstWelfareMng, UserLog log);

        [OperationContract()]
        bool ModifyWelfareMng(List<WelfareMngDTO> lstWelfareMng, UserLog log);

        [OperationContract()]
        bool DeleteWelfareMng(WelfareMngDTO[] lstWelfareMng, UserLog log);


        [OperationContract()]
        List<WorkingDTO> GetWorking(WorkingDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);


        [OperationContract()]
        List<WorkingAllowanceDTO> GetWorkingAllowance(WorkingAllowanceDTO _filter, int PageIndex, int PageSize, ref int Total, string Sorts = "EMPLOYEE_CODE");


        [OperationContract()]
        bool ModifyWorkingAllowance(WorkingAllowanceDTO objWorking, UserLog log, ref decimal gID);

        [OperationContract()]
        WorkingDTO GetWorkingByID(WorkingDTO _filter);

        [OperationContract()]
        WorkingDTO GetEmployeCurrentByID(WorkingDTO _filter);

        [OperationContract()]
        bool InsertWorking(WorkingDTO objWorking, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyWorking(WorkingDTO objWorking, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteWorking(WorkingDTO objAssetMng, UserLog log);

        [OperationContract()]
        bool ValidateWorking(string sType, WorkingDTO obj);

        [OperationContract()]
        WorkingDTO GetLastWorkingSalary(WorkingDTO _filter);

        [OperationContract()]
        List<WorkingAllowanceDTO> GetAllowanceByDate(WorkingAllowanceDTO _filter);

        [OperationContract()]
        List<WorkingAllowanceDTO> GetAllowanceByWorkingID(WorkingAllowanceDTO _filter);

        [OperationContract()]
        bool CheckWorking3B(WorkingDTO _filter);

        [OperationContract()]
        List<WorkingDTO> GetWorking3B(WorkingDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);


        [OperationContract()]
        bool InsertWorking3B(WorkingDTO objWorking, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyWorking3B(WorkingDTO objWorking, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteWorking3B(WorkingDTO objWorking);

        [OperationContract()]
        DataSet GetChangeInfoImport(ParamDTO param, UserLog log);

        [OperationContract()]
        bool ImportChangeInfo(List<WorkingDTO> lstData, ref DataTable dtError, UserLog log);
        [OperationContract()]
        bool ReviewWorking(WorkingDTO objWorking, UserLog log);



        [OperationContract()]
        List<DisciplineEmpDTO> GetEmployeeDesciplineID(decimal DesId);

        [OperationContract()]
        List<DisciplineDTO> GetDiscipline(DisciplineDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log = null/* TODO Change to default(_) if this is not a reference type */, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        DisciplineDTO GetDisciplineByID(DisciplineDTO _filter);

        [OperationContract()]
        bool InsertDiscipline(DisciplineDTO objDiscipline, UserLog log, ref decimal gID, decimal ischeck);

        [OperationContract()]
        bool ModifyDiscipline(DisciplineDTO objDiscipline, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyStatusDiscipline(DisciplineDTO objDiscipline, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateDiscipline(string sType, DisciplineDTO obj);

        [OperationContract()]
        bool DeleteDiscipline(DisciplineDTO objAssetMng);

        [OperationContract()]
        bool ApproveDiscipline(DisciplineDTO objDiscipline);




        [OperationContract()]
        List<DisciplineSalaryDTO> GetDisciplineSalary(DisciplineSalaryDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log = null/* TODO Change to default(_) if this is not a reference type */, string Sorts = "YEAR,MONTH,EMPLOYEE_CODE");

        [OperationContract()]
        DisciplineSalaryDTO GetDisciplineSalaryByID(DisciplineSalaryDTO _filter);

        [OperationContract()]
        bool EditDisciplineSalary(DisciplineSalaryDTO obj);

        [OperationContract()]
        bool ValidateDisciplineSalary(DisciplineSalaryDTO obj, ref string sError);

        [OperationContract()]
        bool ApproveDisciplineSalary(List<decimal> lstID);
        [OperationContract()]
        bool OpenApproveDisciplineSalary(List<decimal> lstID);
        [OperationContract()]
        bool StopDisciplineSalary(List<decimal> lstID);
        [OperationContract()]
        bool StartDisciplineSalary(List<decimal> lstID);
        [OperationContract()]
        bool ApprovePaid(List<DisciplineSalaryDTO> lstEmployee);


        [OperationContract()]
        List<CommendDTO> GetCommend(CommendDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log, string Sorts = "CREATED_DATE desc");
        [OperationContract()]
        List<CommendEmpDTO> GetEmployeeCommendByID(decimal ComId);

        [OperationContract()]
        CommendDTO GetCommendByID(CommendDTO _filter);

        [OperationContract()]
        bool InsertCommend(CommendDTO objCommend, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyCommend(CommendDTO objCommend, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ValidateCommend(string sType, CommendDTO obj);
        [OperationContract()]
        bool DeleteCommend(CommendDTO objAssetMng);

        [OperationContract()]
        bool ApproveCommend(CommendDTO objCommend);


        [OperationContract()]
        DataTable CalculateTerminate(decimal EmployeeId, DateTime TerLateDate, decimal orgId, UserLog log);

        [OperationContract()]
        List<LabourProtectionMngDTO> GetLabourProtectByTerminate(decimal gID);

        [OperationContract()]
        List<AssetMngDTO> GetAssetByTerminate(decimal gID);

        [OperationContract()]
        List<TerminateDTO> GetTerminate(TerminateDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);
        [OperationContract()]
        TerminateDTO GetTerminateByID(TerminateDTO _filter);

        [OperationContract()]
        EmployeeDTO GetEmployeeByID(decimal gEmployeeID);

        [OperationContract()]
        bool InsertTerminate(TerminateDTO objTerminate, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyTerminate(TerminateDTO objTerminate, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteTerminate(decimal objID, UserLog log);
        [OperationContract()]
        bool DeleteBlackList(decimal objID, UserLog log);
        [OperationContract()]
        bool ApproveTerminate(TerminateDTO objTerminate);

        [OperationContract()]
        bool CheckTerminateNo(TerminateDTO objTerminate);

        [OperationContract()]
        bool CheckTerminateEmp(TerminateDTO objTerminate);

        [OperationContract()]
        DataTable GetTyleNV();

        [OperationContract()]
        DataTable GetSalaryNew(ref int P_EMPLOYEEID);

        [OperationContract()]
        List<Terminate3BDTO> GetTerminate3b(Terminate3BDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);
        [OperationContract()]
        Terminate3BDTO GetTerminate3bByID(Terminate3BDTO _filter);

        [OperationContract()]
        EmployeeDTO GetTerminate3bEmployeeByID(decimal gEmployeeID);

        [OperationContract()]
        bool InsertTerminate3b(Terminate3BDTO objTerminate3b, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyTerminate3b(Terminate3BDTO objTerminate3b, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteTerminate3b(decimal objID);

        [OperationContract()]
        bool CheckExistApproveTerminate3b(decimal gID);


        [OperationContract()]
        bool InsertAttatch_Manager(EmployeeFileDTO fileInfo, byte[] fileBytes);
        [OperationContract()]
        bool UpdateAttatch_Manager(EmployeeFileDTO fileInfo, byte[] fileBytes);
        [OperationContract()]
        bool DeleteAttatch_Manager(decimal fileID);
        [OperationContract()]
        EmployeeFileDTO GetAttachFile_Manager(decimal fileId);
        [OperationContract()]
        List<EmployeeFileDTO> GetAttachFiles_Manager(decimal fileType, int page, int pageSize, ref int totalPage, decimal Employee_id);
        [OperationContract()]
        byte[] DownloadAttachFile_Manager(decimal fileID, ref EmployeeFileDTO fileInfo);

        [OperationContract()]
        List<HU_PRO_TRAIN_OUT_COMPANYDTOEDIT> GetProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT _filter);

        [OperationContract()]
        bool InsertProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT objTitle, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteProcessTrainingEdit(List<decimal> lstDecimals, UserLog log);

        [OperationContract()]
        HU_PRO_TRAIN_OUT_COMPANYDTOEDIT CheckExistProcessTrainingEdit(decimal pk_key);

        [OperationContract()]
        bool SendProcessTrainingEdit(List<decimal> lstID, UserLog log);

        [OperationContract()]
        bool UpdateStatusProcessTrainingEdit(List<decimal> lstID, string status, UserLog log);

        [OperationContract()]
        List<HU_PRO_TRAIN_OUT_COMPANYDTOEDIT> GetApproveProcessTrainingEdit(HU_PRO_TRAIN_OUT_COMPANYDTOEDIT _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_ID desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);


        [OperationContract()]
        List<WorkingBeforeDTOEdit> GetWorkingBeforeEdit(WorkingBeforeDTOEdit _filter);

        [OperationContract()]
        bool InsertWorkingBeforeEdit(WorkingBeforeDTOEdit objWorkingBefore, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyWorkingBeforeEdit(WorkingBeforeDTOEdit objWorkingBefore, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteWorkingBeforeEdit(List<decimal> lstDecimals, UserLog log);

        [OperationContract()]
        WorkingBeforeDTOEdit CheckExistWorkingBeforeEdit(decimal pk_key);

        [OperationContract()]
        bool SendWorkingBeforeEdit(List<decimal> lstID, UserLog log);

        [OperationContract()]
        bool UpdateStatusWorkingBeforeEdit(List<decimal> lstID, string status, UserLog log);

        [OperationContract()]
        List<WorkingBeforeDTOEdit> GetApproveWorkingBeforeEdit(WorkingBeforeDTOEdit _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_ID desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);



        /// <summary>
        ///         ''' Lấy dữ liệu cho combobox
        ///         ''' </summary>
        ///         ''' <param name="_combolistDTO">Trả về dữ liệu combobox</param>
        ///         ''' <returns>TRUE: Success</returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        bool GetComboList(ref ComboBoxDataDTO _combolistDTO);

        /// <summary>
        ///         ''' Lấy danh sách nhắc nhở
        ///         ''' </summary>
        ///         ''' <param name="_dayRemind"></param>
        ///         ''' <param name="log"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<ReminderLogDTO> GetRemind(string _dayRemind, UserLog log);


        /// <summary>
        ///         ''' Lấy danh sách nhân thân
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<FamilyDTO> GetFamily(decimal _empId);

        /// <summary>
        ///         ''' Lấy quá trình công tác trước khi vào công ty
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<WorkingBeforeDTO> GetWorkingBefore(decimal _empId);

        /// <summary>
        ///         ''' Lấy quá trình công tác trong công ty
        ///         ''' </summary>
        ///         ''' <param name="_empCode"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<WorkingDTO> GetWorkingProccess(decimal _empId, UserLog log = null/* TODO Change to default(_) if this is not a reference type */);

        /// <summary>
        ///         ''' Lấy quá trình lương
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<WorkingDTO> GetSalaryProccess(decimal _empId, UserLog log = null/* TODO Change to default(_) if this is not a reference type */);

        /// <summary>
        ///         ''' Lấy quá trình phúc lợi
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<WelfareMngDTO> GetWelfareProccess(decimal _empId);

        /// <summary>
        ///         ''' Lấy quá trình hợp đồng
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<ContractDTO> GetContractProccess(decimal _empId);

        /// <summary>
        ///         ''' Lấy quá trình khen thưởng
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        ///         '''
        [OperationContract()]
        List<CommendDTO> GetCommendProccess(decimal _empId);
        /// <summary>
        ///         ''' Lấy quá trình kỷ luật
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<DisciplineDTO> GetDisciplineProccess(decimal _empId);
        /// <summary>
        ///         ''' Lấy quá trình bảo hiểm
        ///         ''' </summary>
        ///         ''' <param name="_empId"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        DataTable GetInsuranceProccess(decimal _empId);

        [OperationContract()]
        DataTable GetEmployeeHistory(decimal _empId);


        [OperationContract()]
        List<HU_PRO_TRAIN_OUT_COMPANYDTO> GetProcessTraining(HU_PRO_TRAIN_OUT_COMPANYDTO _filter, ref int PageIndex = 0, int PageSize = int.MaxValue, int Total = 0, string Sorts = "CREATED_DATE desc");
        [OperationContract()]
        bool InsertProcessTraining(HU_PRO_TRAIN_OUT_COMPANYDTO objHuPro, UserLog log, ref decimal gID);

        [OperationContract()]
        bool ModifyProcessTraining(HU_PRO_TRAIN_OUT_COMPANYDTO objHuPro, UserLog log, ref decimal gID);

        [OperationContract()]
        bool DeleteProcessTraining(List<decimal> lstID);

        [OperationContract()]
        bool CheckAndUpdateEmployeeInformation();

        [OperationContract()]
        bool CheckAndSendMailReminder();



        [OperationContract()]
        List<HU_EMPLOYEE_BHDDTO> GetEmployeeBHLD(HU_EMPLOYEE_BHDDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, UserLog log, string Sorts = "CREATED_DATE desc");

        [OperationContract()]
        HU_EMPLOYEE_BHDDTO GetEmployeeBHLDByID(HU_EMPLOYEE_BHDDTO _filter);
        [OperationContract()]
        bool InsertEmployeeBHLD(HU_EMPLOYEE_BHDDTO objTitle, UserLog log, ref decimal gID);
        [OperationContract()]
        bool ModifyEmployeeBHLD(HU_EMPLOYEE_BHDDTO objTitle, UserLog log, ref decimal gID);
        [OperationContract()]
        bool DeleteEmployeeBHLD(HU_EMPLOYEE_BHDDTO objWorking, UserLog log);



        [OperationContract()]
        List<CalculateTongHopDTO> GetListCALCULATE(CalculateTongHopDTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "EMPLOYEE_CODE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */);
        [OperationContract()]
        bool Calculate_data(int OrgId, int pv_year, int IsDissolve, int IsLoad, UserLog log);




        [OperationContract()]
        List<RptDynamicColumnDTO> GetConditionColumn(decimal _ConditionID);
        [OperationContract()]
        List<HuDynamicConditionDTO> GetListReportName(decimal _ViewId);
        [OperationContract()]
        bool DeleteDynamicReport(decimal ID, UserLog log);
        [OperationContract()]
        bool SaveDynamicReport(HuDynamicConditionDTO _report, List<HuConditionColDTO> _col, UserLog log);
        [OperationContract()]
        Dictionary<decimal, string> GetDynamicReportList();
        /// <summary>
        ///         ''' Lấy danh sách các cột của DynamicReport
        ///         ''' </summary>
        ///         ''' <param name="_reportID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<RptDynamicColumnDTO> GetDynamicReportColumn(decimal _reportID);

        /// <summary>
        ///         ''' Lấy dữ liệu báo cáo động
        ///         ''' </summary>
        ///         ''' <param name="column">Danh sách các cột cần lấy</param>
        ///         ''' <param name="condition">Expression điều kiện</param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        DataTable GetDynamicReport(decimal _reportID, decimal orgID, List<string> column, string condition, UserLog log);



        /// <summary>
        ///         ''' Lấy danh sách loại thống kê nhân viên
        ///         ''' </summary>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<OtherListDTO> GetListEmployeeStatistic();

        /// <summary>
        ///         ''' Lấy danh sách loại thống kê biến động
        ///         ''' </summary>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<OtherListDTO> GetListChangeStatistic();

        /// <summary>
        ///         ''' Lấy nội dung thống kê nhân viên
        ///         ''' </summary>
        ///         ''' <param name="_type"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<StatisticDTO> GetEmployeeStatistic(string _type, UserLog log);

        /// <summary>
        ///         ''' Lấy nội dung thống kê biến động
        ///         ''' </summary>
        ///         ''' <param name="_type"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        [OperationContract()]
        List<StatisticDTO> GetChangeStatistic(string _type, UserLog log);
        [OperationContract()]
        List<StatisticDTO> GetCompanyNewInfo(UserLog log);

        [OperationContract()]
        decimal? GetOrgFromUsername(string username);

        [OperationContract()]
        List<EmployeeDTO> GetLineManager(string username);


        [OperationContract()]
        List<ATPeriodDTO> GetPeriodbyYear(decimal year);


        [OperationContract()]
        List<Se_ReportDTO> GetReportById(Se_ReportDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log, string Sorts = "CODE ASC");

        [OperationContract()]
        DataTable ProfileReport(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, int sOrg, string sUserName, string sLang);

        [OperationContract()]
        DataSet ExportReport(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang);

        [OperationContract()]
        DataSet ExportReport_0107(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang);

        [OperationContract()]
        DataSet ExportReport_0108(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang);

        [OperationContract()]
        DataSet ExportReport_0115(string sPkgName, DateTime? sStartDate, DateTime? sEndDate, string sOrg, int IsDissolve, string sUserName, string sLang);

        [OperationContract()]
        DataSet GetEmployeeCVByID(string sPkgName, string sEmployee_id);

        [OperationContract()]
        DataSet ExportRPT_CHITIET(string sPkgName, decimal sYear, string sOrgId, decimal IsDissolve, UserLog log);

        [OperationContract()]
        DataSet ExportRPT_TH(string sPkgName, decimal sYear, string sOrgId, decimal IsDissolve, UserLog log);
    }
}
