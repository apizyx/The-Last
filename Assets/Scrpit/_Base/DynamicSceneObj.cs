using UnityEngine;
using System.Collections;

/// <summary>
/// 动态场景物体
/// </summary>
public abstract class DynamicSceneObj : MonoBehaviour {

    /// <summary>
    /// 对应刚体实例
    /// </summary>
    protected Rigidbody rigidbodyIns;

    protected virtual void Awake()
    {
        rigidbodyIns = this.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="e"></param>
    protected abstract void OnTriggerEnter(Collider e);



}
