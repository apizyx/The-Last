using UnityEngine;
using System.Collections;

/// <summary>
/// 表项
/// </summary>
public abstract class _UI_DynLItem : _UI_LItem
{
    /// <summary>
    /// 更新 
    /// </summary>
    /// <returns>有效标记</returns>
    public abstract bool UpdateData();

    /// <summary>
    /// 有效标记
    /// </summary>
    public abstract bool f_IsValid { get; }
    
}
