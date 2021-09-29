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
        // 


        public List<RptDynamicColumnDTO> GetConditionColumn(decimal _ConditionID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetConditionColumn(_ConditionID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public List<HuDynamicConditionDTO> GetListReportName(decimal _ViewId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetListReportName(_ViewId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool DeleteDynamicReport(decimal ID, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteDynamicReport(ID, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool SaveDynamicReport(HuDynamicConditionDTO _report, List<HuConditionColDTO> _col, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.SaveDynamicReport(_report, _col, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public Dictionary<decimal, string> GetDynamicReportList()
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetDynamicReportList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        ///         ''' Lấy danh sách các cột của DynamicReport
        ///         ''' </summary>
        ///         ''' <param name="_reportID"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public List<RptDynamicColumnDTO> GetDynamicReportColumn(decimal _reportID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetDynamicReportColumn(_reportID);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        ///         ''' Lấy dữ liệu báo cáo động
        ///         ''' </summary>
        ///         ''' <param name="column">Danh sách các cột cần lấy</param>
        ///         ''' <param name="condition">Expression điều kiện</param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public DataTable GetDynamicReport(decimal _reportID, decimal orgID, List<string> column, string condition, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetDynamicReport(_reportID, orgID, column, condition, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
