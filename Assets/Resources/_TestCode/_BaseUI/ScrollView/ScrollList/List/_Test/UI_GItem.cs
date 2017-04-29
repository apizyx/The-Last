
/*

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using MGame.GameItem;
using MGame;
using System;

/// <summary>
/// 表项
/// </summary>
public class UI_GItem : _UI_DynLItem
{
    Image I_Select;
    Text T_Name;
    Text T_Count;

    GItem itemData;
    public int type { get { return itemData.type; } }
    public override bool f_IsValid { get { return itemData.f_IsValid; } }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    public override void InitData(object data)
    {
        // Debug.Log("Item Init");
        // 获取子控件 
        if (T_Name == null || T_Count == null || I_Select == null)
        {
            T_Name = this.transform.FindChild("T_Name").GetComponent<Text>();
            T_Count = this.transform.FindChild("T_Count").GetComponent<Text>();
            I_Select = this.transform.GetComponent<Image>();
        }
        // 数据初始化
        itemData = (GItem)data;
        T_Name.text = itemData.type.ToString();
        _UpdateDisplay(itemData);

        // 设为非选中
        Select(false);
    }
    protected void _UpdateDisplay(GItem data) 
    {
        T_Count.text = itemData.count.ToString();
    }
    /// <summary>
    /// 更新数据
    /// </summary>
    /// <returns></returns>
    public override bool UpdateData()
    {
        if (itemData != null)
        {
            if (itemData.f_IsValid)
            {
                _UpdateDisplay(itemData);
                return true;
            }
            else
            {
                Destroy(this.gameObject);
                return false;
            }
        }
        return false;
    }

    //-----------------------------------
    /// <summary>
    /// 设置选中显示
    /// </summary>
    /// <param name="falg"></param>
    public void Select(bool falg) { I_Select.enabled = falg; }


}
             
*/                 