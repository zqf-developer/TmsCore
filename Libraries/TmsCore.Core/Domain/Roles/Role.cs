using System;
using TmsCore.Core;

public partial class Role : BaseEntity
{

    /// <summary>
    /// 角色ID 
    /// </summary>
    /// <value></value>
    public string roleID { get; set; }

    /// <summary>
    /// 角色名称
    /// </summary>
    /// <value></value>
    public string roleName { get; set; }

    /// <summary>
    /// 角色描述
    /// </summary>
    /// <value></value>
    public string roleDesc { get; set; }

    /// <summary>
    /// 创建日期
    /// </summary>
    /// <value></value>
    public Nullable<System.DateTime> CreateDTime { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    /// <value></value>
    public string userID { get; set; }

}