using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// 
/// </summary>
public class Enimy : DynamicSceneObj
{
    protected override void OnTriggerEnter(Collider e)
    {
        if (e.gameObject.tag.CompareTo("Skill") == 0)
        {
            Destroy(this.gameObject, 0.1f);
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
