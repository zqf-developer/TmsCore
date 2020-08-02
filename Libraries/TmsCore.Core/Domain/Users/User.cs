using System;
using TmsCore.Core;

public partial class User : BaseEntity
{
    /// <summary>
    /// 用户ID
    /// </summary>
    /// <value></value>
    public string UserID { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    /// <value></value>
    public string UserName { get; set; }

    /// <summary>
    /// 用户简称
    /// </summary>
    /// <value></value>
    public string ShortName { get; set; }

    /// <summary>
    /// 工号
    /// </summary>
    /// <value></value>
    public string UserEmpID { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    /// <value></value>
    public string Password { get; set; }

    /// <summary>
    /// 创建日期
    /// </summary>
    /// <value></value>
    public System.DateTime CreateDTime { get; set; }

    /// <summary>
    /// 更新日期
    /// </summary>
    /// <value></value>
    public System.DateTime ModifyDTime { get; set; }

    /// <summary>
    /// 是否有效
    /// </summary>
    /// <value></value>
    public Nullable<bool> IsActive { get; set; }

    /// <summary>
    /// 有效日期截止
    /// </summary>
    /// <value></value>
    public string AvailableDTime { get; set; }

    /// <summary>
    /// 创建来源
    /// </summary>
    /// <value></value>
    public string Source { get; set; }

    /// <summary>
    /// 审批人
    /// </summary>
    /// <value></value>
    public string ApprovedBy { get; set; }

    /// <summary>
    /// 审批日期
    /// </summary>
    /// <value></value>
    public System.DateTime ApprovedDTime { get; set; }

}