using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class TestSkillObj : DynamicSceneObj
{
    public GameObject modelObj;



    protected override void OnTriggerEnter(Collider e)
    {
        if (e.gameObject.tag.CompareTo("DynamicSenceObj") == 0)
        {
            UnitObj obj = e.GetComponent<UnitObj>();
            if (obj != null)
                new TestSkill().Deal(null, new Unit[] { obj.unit });

            modelObj.SetActive(false);
        }
    }


}