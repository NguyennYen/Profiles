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
        public DataTable GetWelfareListAuto(WelfareMngDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log)
        {
            try
            {
                using (ProfileRepository rep = new ProfileRepository())
                {
                    var dt = rep.GetWelfareListAuto(_filter, PageIndex, PageSize, Total, log);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Calculate_WelfareAuto(WelfareMngDTO _filter, int PageIndex, int PageSize, ref int Total, UserLog log)
        {
            try
            {
                using (ProfileRepository rep = new ProfileRepository())
                {
                    return rep.Calculate_WelfareAuto(_filter, PageIndex, PageSize, Total, log);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<WelfareMngDTO> GetWelfareMng(WelfareMngDTO _filter, int IsDissolve, int PageIndex, int PageSize, ref int Total, UserLog UserLog, string Sorts = "CREATED_DATE desc")
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWelfareMng(_filter, IsDissolve, PageIndex, PageSize, Total, UserLog, Sorts);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<HU_WELFARE_AUTODTO> GetHU_WELFARE_AUTODTO(HU_WELFARE_AUTODTO _filter, int PageIndex, int PageSize, ref int Total, ParamDTO _param, string Sorts = "CREATED_DATE desc", UserLog log = null/* TODO Change to default(_) if this is not a reference type */)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetHU_WELFARE_AUTODTO(_filter, PageIndex, PageSize, Total, _param, Sorts, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyHU_WELFARE_AUTO(List<HU_WELFARE_AUTODTO> lstWelfare, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.ModifyHU_WELFARE_AUTO(lstWelfare, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<ATPeriodDTO> LOAD_PERIODBylinq(ATPeriodDTO obj, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.LOAD_PERIODBylinq(obj, log);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public WelfareMngDTO GetWelfareMngById(int Id
)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.GetWelfareMngById(Id);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool CheckWelfareMngEffect(List<WelfareMngDTO> _filter)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    var lst = rep.CheckWelfareMngEffect(_filter);
                    return lst;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool InsertWelfareMng(List<WelfareMngDTO> lstWelfareMng, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertWelfareMng(lstWelfareMng, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ModifyWelfareMng(List<WelfareMngDTO> lstWelfareMng, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.ModifyWelfareMng(lstWelfareMng, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ActiveWelfareMng(WelfareMngDTO[] objWelfareMng, UserLog log)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteWelfareMng(objWelfareMng, log);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
