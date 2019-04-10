using System;
using System.Collections.Generic;
using System.Text;

namespace IEMS.JHWMS.DbRI
{
    using MSTL.DbAccess;
    using IEMS.JHWMS.Entity;

    /// <summary>
    /// PSB_PALLET_TYPE - 基础表操作接口
    /// </summary>
    public interface IPsbPalletTypeService : ITableViewService<PsbPalletType>
    {
    }

    /// <summary>
    /// PSB_PALLET_TYPE - 基础表操作类
    /// </summary>
    internal class PsbPalletTypeService : TableViewService<PsbPalletType>, IPsbPalletTypeService
    {
        #region 构造方法
        public PsbPalletTypeService() : base() { }
        public PsbPalletTypeService(string dbName) : base(dbName) { }
        #endregion
    }
}