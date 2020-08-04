using System;
using TmsCore.Core;

public partial class TUserRole : BaseEntity
{

    /// <summary>
    /// 用户ID
    /// </summary>
    /// <value></value>
    public string userID { get; set; }

    /// <summary>
    /// 角色ID
    /// </summary>
    /// <value></value>
    public string roleID { get; set; }

    /// <summary>
    /// 创建日期
    /// </summary>
    /// <value></value>
    public DateTime CreateDTime { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    /// <value></value>
    public string Creator { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    /// <value></value>
    public DateTime ModifyDTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    /// <value></value>
    public string Modifier { get; set; }
}