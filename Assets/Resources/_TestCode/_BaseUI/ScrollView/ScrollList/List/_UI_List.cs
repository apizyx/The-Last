using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// UI 列表
/// </summary>
public class _UI_List<T> : MonoBehaviour {

    /// <summary>
    /// 列表项 预制 
    /// </summary>
    public _UI_LItem m_item_pre;
    /// <summary>
    /// 列表 面板
    /// </summary>
    public Transform m_Panel;

    /// <summary>
    /// 表项脚本 列表
    /// </summary>
    protected List<_UI_LItem> itemObjList = new List<_UI_LItem>();

    // Use this for initialization
    void Start () {}
    
    /// <summary>
    /// 初始化 表项
    /// </summary>
    /// <param name="dataList_">数据列表</param>
    public virtual void DataInit(ArrayList dataList_)
    {
        for (int i = 0; i < dataList_.Count; ++i)
        {
            _UI_LItem item = _CreateItem();
            
            // 初始化数据
            item.InitData(dataList_[i]); 
            this.itemObjList.Add(item);
        }
    }
    /// <summary>
    /// 设置数据
    /// </summary>
    /// <param name="dataList_"></param>
    public virtual void SetData(List<T> dataList_)
    {
        //if(m_Panel == null)
        //    m_Panel = this.transform.F("ItemPanel");
        //Debug.Log("m_Panel " + (m_Panel == null));

        Clear();
        for (int i = 0; i < dataList_.Count; ++i)
        {
            _UI_LItem item = _CreateItem();

            // 初始化数据
            item.InitData(dataList_[i]);
            this.itemObjList.Add(item);
        }
    }

    /// <summary>
    /// 构造 表项
    /// </summary>
    /// <returns></returns>
    protected _UI_LItem _CreateItem()
    {
        GameObject objPre = m_item_pre.gameObject;
        GameObject newObj = Instantiate((Object)objPre, transform.position, transform.rotation) as GameObject;
      
        newObj.transform.SetParent(m_Panel);
        newObj.transform.localScale = Vector3.one;
        return newObj.GetComponent<_UI_LItem>();
    }

    /// <summary>
    /// 清除子对象
    /// </summary>
    protected void Clear()
    {
        while (itemObjList.Count > 0)
        {
            Destroy(itemObjList[0].gameObject);
            itemObjList.RemoveAt(0);
        }
    }

}
