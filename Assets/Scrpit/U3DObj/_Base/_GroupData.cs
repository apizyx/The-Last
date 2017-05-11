using UnityEngine;
using System.Collections;

/// <summary>
/// 全局数据
/// </summary>
public class _GroupData 
{
    /// <summary>
    /// 单例模式
    /// </summary>
    /// <returns></returns>
    public static _GroupData GetInstance() { return instance; }
    private static _GroupData instance;

    void Awake()
    {
        instance = this;
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    //=======================================================




}
