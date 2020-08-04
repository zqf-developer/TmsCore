using System;
using TmsCore.Core;

public partial class TMenu : BaseEntity
{
    /// <summary>
    /// 菜单ID
    /// </summary>
    /// <value></value>
    public string menuID { get; set; }

    /// <summary>
    /// 菜单名称
    /// </summary>
    /// <value></value>
    public string menuName { get; set; }

    /// <summary>
    /// 菜单中文描述
    /// </summary>
    /// <value></value>
    public string menuChineseDesc { get; set; }

    /// <summary>
    /// 菜单英文描述
    /// </summary>
    /// <value></value>
    public string menuEnglishDesc { get; set; }

    /// <summary>
    /// 菜单类型
    /// </summary>
    /// <value></value>
    public string menuType { get; set; }

    /// <summary>
    /// 菜单是否有效
    /// </summary>
    /// <value></value>
    public Nullable<bool> menuActive { get; set; }

    /// <summary>
    /// 菜单参数
    /// </summary>
    /// <value></value>
    public string menuParamLS { get; set; }

    /// <summary>
    /// 单个表名称
    /// </summary>
    /// <value></value>
    public string singleTableName { get; set; }

    /// <summary>
    /// 是否有父节点
    /// </summary>
    /// <value></value>
    public Nullable<bool> isParentNode { get; set; }

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