using UnityEngine;
using System.Collections;

public class C_MainCamera : MonoBehaviour {

    /// <summary>
    /// 玩家单位位置
    /// </summary>
    public Transform playerUnitObj;
    /// <summary>
    /// 相对位置
    /// </summary>
    public Vector3 relPosition;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = playerUnitObj.transform.position + relPosition;
        this.transform.LookAt(playerUnitObj);
	}

}
