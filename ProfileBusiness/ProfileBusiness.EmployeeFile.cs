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
        public bool InsertAttatch_Manager(EmployeeFileDTO fileInfo, byte[] fileBytes)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.InsertAttatch_Manager(fileInfo, fileBytes);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool UpdateAttatch_Manager(EmployeeFileDTO fileInfo, byte[] fileBytes)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.UpdateAttatch_Manager(fileInfo, fileBytes);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public bool DeleteAttatch_Manager(decimal fileID)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DeleteAttatch_Manager(fileID);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }


        public EmployeeFileDTO GetAttachFile_Manager(decimal fileId)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetAttachFile_Manager(fileId);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public List<EmployeeFileDTO> GetAttachFiles_Manager(decimal fileType, int page, int pageSize, ref int totalPage, decimal Employee_id)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.GetAttachFiles_Manager(fileType, page, pageSize, totalPage, Employee_id);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public byte[] DownloadAttachFile_Manager(decimal fileID, ref EmployeeFileDTO fileInfo)
        {
            using (ProfileRepository rep = new ProfileRepository())
            {
                try
                {
                    return rep.DownloadAttachFile_Manager(fileID, fileInfo);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
