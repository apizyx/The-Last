using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// 
/// </summary>
public class SkillFire : DynamicSceneObj
{
    /// <summary>
    /// 移动属性实例
    /// </summary>
    protected MoveAttr moveIns;

    /// <summary>
    /// 技能模型
    /// </summary> 
    public GameObject modelObj;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="e"></param>
    protected override void OnTriggerEnter(Collider e)
    {
        if (e.gameObject.tag.CompareTo("DynamicSenceObj") == 0)
        {
            UnitObj obj = e.GetComponent<UnitObj>();
            if (obj != null)
                new TestSkill().Deal(null, new Unit[] { obj.unit });

            Destroy(this.gameObject);
        }

        //float time = 0.1f;  
        //if (e.gameObject.tag.CompareTo("DynamicSenceObj") == 0)
        //{
        //    modelObj.SetActive(false);
        //    Destroy(this.gameObject, time);
        //}
    }

    // Use this for initialization
    void Start () {
        moveIns = this.GetComponent<MoveAttr>();
	}
	
	// Update is called once per frame
	void Update () {

        moveIns.Reset(modelObj.transform.forward, 0.1f);
        Destroy(this.gameObject, 2);
	}
}
