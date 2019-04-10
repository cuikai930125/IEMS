using IEMS.JHWMS.VoDto;
using MSTL.DbAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IEMS.JHWMS.DbCI
{
   public interface IBinDataService : IDbCIService
    {
        StoreBinData GetStoreBinData(int x);
        DataTable GetProductStatistics();
        DataTable GetErrBinNo(); PageResult GetBinData(PageResult pageResult);
    }
}
