using UnityEngine;
using System.Collections;

/// <summary>
/// T 基础
/// </summary>
public class Test_Base : MonoBehaviour
{
	// Use this for initialization
	void Start () {

        Debug.Log("W 添加 E 减少 ");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.W))
        {
            ;
        }

	}

    // 
    void OnGUI()
    {
       // GUI.Label(new Rect(10, 10, 200, 20), ele.ToString());

    }

}
