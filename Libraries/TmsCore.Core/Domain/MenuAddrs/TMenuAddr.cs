using System;
using TmsCore.Core;

public partial class TMenuAddr : BaseEntity
{
    /// <summary>
    /// 菜单ID
    /// </summary>
    /// <value></value>
    public string menuID { get; set; }

    /// <summary>
    /// 语言
    /// </summary>
    /// <value></value>
    public string Language { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    /// <value></value>
    public string Url { get; set; }

    /// <summary>
    /// 语言描述
    /// </summary>
    /// <value></value>
    public string LanguageDesc { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    /// <value></value>
    public string userID { get; set; }

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