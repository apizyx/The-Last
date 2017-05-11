using UnityEngine;
using System.Collections;

/// <summary>
/// 属性条 UI(基于 Sprite)
/// </summary>
public class Attribute_MUI : MonoBehaviour {

    /// <summary>
    /// 完全值
    /// </summary>
    public int maxVal;

    /// <summary>
    /// 当前值
    /// </summary>
    public int nowVal;

    /// <summary>
    /// 显示值对应的Sptite
    /// </summary>
    public Transform valSprite;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float scale = (float)nowVal / (float)maxVal;
        valSprite.localScale = new Vector3(scale, valSprite.localScale.y, valSprite.localScale.z);
        valSprite.localPosition = new Vector3( (scale - 1) / 2 , valSprite.localPosition.y, valSprite.localPosition.z);
    }

    //protected Camera GetMainCamera()
    //{
    //    return Camera.main;
    //}

}
