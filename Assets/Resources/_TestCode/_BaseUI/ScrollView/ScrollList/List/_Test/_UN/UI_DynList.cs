using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// UI 动态列表
/// </summary>
public class UI_DynList : MonoBehaviour {

    public _UI_DynLItem m_item_pre;
    public GameObject m_Panel;
    
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        UpdateData();
    }
    
    /// <summary>
    /// 初始化 表项
    /// </summary>
    /// <param name="dataList_">数据列表</param>
    public virtual void DataInit(ArrayList dataList_)
    {
        for (int i = 0; i < dataList_.Count; ++i)
        {
            _UI_DynLItem item = _CreateItem();
            
            // 初始化数据
            item.InitData(dataList_[i]); 
            //item.gameObject.transform.parent.SetParent(m_Panel.transform);  // 无法替换 .parent == null
            item.gameObject.transform.parent = m_Panel.transform;
            this.dataList.Add(item);
        }
    }  
    /// <summary>
    /// 构造 表项
    /// </summary>
    /// <returns></returns>
    protected _UI_DynLItem _CreateItem()
    {
        GameObject objPre = m_item_pre.gameObject;
        GameObject newObj = ((GameObject)Object.Instantiate((Object)objPre, objPre.transform.position, objPre.transform.rotation));
        return newObj.GetComponent<_UI_DynLItem>();
    }

    /// <summary>
    /// 表项脚本 列表
    /// </summary>
    protected List<_UI_DynLItem> dataList = new List<_UI_DynLItem>();
    /// <summary>
    /// 更新数据
    /// </summary>
    public void UpdateData()
    {
        for (int i = 0; i < dataList.Count;)
        {
            if (dataList[i].UpdateData())
                ++i;
            else
                dataList.RemoveAt(i);
        }
    }

}
