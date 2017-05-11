using UnityEngine;
using System.Collections;

/// <summary>
/// 可移动属性(场景物体)
/// </summary>
public class MoveAttr : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        if (direction != Vector3.zero)
        {
            this.transform.position += direction * speed;
            if(modelObj != null)
                modelObj.transform.forward = direction;
        }
    }

    //=====================================================
    /// <summary>
    /// 模型物体
    /// </summary>
    public GameObject modelObj;

    /// <summary>
    /// 方向
    /// </summary>
    public Vector3 direction;

    /// <summary>
    /// 速度
    /// </summary>
    public float speed;
    
    /// <summary>
    /// 重置移动数据
    /// </summary>
    /// <param name="direction_"></param>
    /// <param name="speed_"></param>
    public void Reset(Vector3 direction_, float speed_)
    {
        direction = direction_;
        speed = speed_;
    }



}
