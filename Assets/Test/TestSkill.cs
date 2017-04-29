using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class TestSkill : DynamicSceneObj
{
    public GameObject modelObj;

    protected override void OnTriggerEnter(Collider e)
    {
        if (e.gameObject.tag.CompareTo("DynamicSenceObj") == 0)
        {
            modelObj.SetActive(false);
        }
    }


}