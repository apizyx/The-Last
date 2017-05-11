using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// 单位U3d对象
/// </summary>
public class UnitObj : DynamicSceneObj
{
    /// <summary>
    /// 移动属性实例
    /// </summary>
    protected MoveAttr moveIns;

    /// <summary>
    /// UI血条
    /// </summary>
    public Attribute_MUI hp_UI;

    /// <summary>
    /// 单位数据
    /// </summary>
    public Unit unit;

    // Use this for initialization
    protected virtual void Start () {
        //direction = new Vector3();
        moveIns = this.GetComponent<MoveAttr>();
        unit = new Unit();
        unit.HP = 100;
        unit.maxHp = 100;
    }

    // Update is called once per frame
    protected virtual void Update () {
        // 临时
        if(unit.HP <= 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            hp_UI.nowVal = unit.HP;
            hp_UI.maxVal = unit.maxHp;
        }
    }

    protected override void OnTriggerEnter(Collider e)
    {
        
    }


}
