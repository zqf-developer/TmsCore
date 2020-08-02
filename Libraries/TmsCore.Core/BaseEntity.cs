using System;

namespace TmsCore.Core
{
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// 获取或设置实体标识符
        /// </summary>
        public int Id { get; set; }
    }
}
