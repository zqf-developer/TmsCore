using System;
using TmsCore.Core;

public partial class TUser : BaseEntity
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
    /// 手机号码
    /// </summary>
    /// <value></value>
    public string Moblie { get; set; }

    /// <summary>
    /// 电子邮箱
    /// </summary>
    /// <value></value>
    public string Email { get; set; }


    /// <summary>
    /// 用户是否被删除
    /// </summary>
    public bool Deleted { get; set; }

    /// <summary>
    /// 是否是系统账户
    /// </summary>
    public bool IsSystemAccount { get; set; }

    /// <summary>
    /// 系统名称
    /// </summary>
    public string SystemName { get; set; }

    /// <summary>
    /// 上次登录的IP地址
    /// </summary>
    public string LastIpAddress { get; set; }


    /// <summary>
    /// 上次登录时间
    /// </summary>
    public DateTime? LastLoginDateUtc { get; set; }

    /// <summary>
    /// 上次
    /// </summary>
    public DateTime LastActivityDateUtc { get; set; }

    /// <summary>
    /// 是否有效
    /// </summary>
    /// <value></value>
    public bool IsActive { get; set; }

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