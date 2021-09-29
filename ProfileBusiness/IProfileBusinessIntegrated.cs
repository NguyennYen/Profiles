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
    public interface IProfileBusinessIntegrated
    {
        [OperationContract()]
        DataTable GetEmpAll(DateTime lastDate);

        [OperationContract()]
        DataTable GetOrgAll(DateTime lastDate);

        [OperationContract()]
        DataTable GetTitleAll(DateTime lastDate);

        [OperationContract()]
        DataTable GetTitleGroupAll(DateTime lastDate);

        [OperationContract()]
        DataTable GetStaffRankAll(DateTime lastDate);
    }
}
