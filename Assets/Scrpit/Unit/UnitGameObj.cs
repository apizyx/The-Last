using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// 单位游戏对象
/// </summary>
public class UnitGameObj : DynamicSceneObj
{
    
    /// <summary>
    /// 移动属性实例
    /// </summary>
    protected MoveAttr moveIns;

    /// <summary>
    /// 技能发射点
    /// </summary>
    public Vector3 SkillFirePosition;

    public GameObject prefab;


    public Vector3 biuDirection;
    // Use this for initialization
    void Start () {
        //direction = new Vector3();
        moveIns = this.GetComponent<MoveAttr>();
    }
	
	// Update is called once per frame
	void Update () {
        // 临时
        float speed = 0.05f;
        moveIns.Reset( GetMoveDirection(), speed);
        SkillFirePosition = this.transform.position + this.transform.forward * 4;
        if(Input.GetKey(KeyCode.Q))
        {
            GameObject biu = Instantiate(prefab);

            biu.transform.forward = this.transform.forward;
            biu.transform.position = SkillFirePosition;
        }

    }

    // 获得移动方向
    public Vector3 GetMoveDirection()
    {
        Vector3 directionVec = Vector3.right * Input.GetAxis("Horizontal") + Vector3.forward * Input.GetAxis("Vertical");
        if (directionVec.sqrMagnitude > 0.5)
            directionVec = directionVec.normalized;
        else
            directionVec = Vector3.zero;
        return directionVec;
    }

    /// <summary>
    /// 碰撞函数
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
