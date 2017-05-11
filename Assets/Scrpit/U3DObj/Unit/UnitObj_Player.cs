using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// 单位U3d对象
/// </summary>
public class UnitObj_Player : UnitObj
{

    // Update is called once per frame
    protected override void Update () {
        // 临时
        float speed = 0.05f;
        moveIns.Reset( GetMoveDirection(), speed);
        hp_UI.nowVal = unit.HP;
        hp_UI.maxVal = unit.maxHp;
    }

    // 获得移动方向
    public Vector3 GetMoveDirection()
    {
        Vector3 directionVec = Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical");
        // 确保数值有效,忽略0向量
        return directionVec.sqrMagnitude > 0.01f ? directionVec.normalized : directionVec = Vector3.zero;
    }

    /// <summary>
    /// 受到技能(碰撞函数)
    /// </summary>
    /// <param name="e"></param>
    protected override void OnTriggerEnter(Collider e)
    {
        if (e.gameObject.tag.CompareTo("Skill") == 0)
        {
            Debug.Log(e.name);
        }

    }

}
