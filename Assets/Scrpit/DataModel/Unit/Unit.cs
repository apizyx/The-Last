
using System.Collections;


/// <summary>
/// 单位数据
/// </summary>
public class Unit
{
    /// <summary>
    /// 最大生命值
    /// </summary>
    public int maxHp;
    /// <summary>
    /// 当前生命值
    /// </summary>
    protected int hp;
    /// <summary>
    /// 当前生命值
    /// </summary>
    public int HP
    {   get { return hp; }
        set { hp = value >= 0 ? value : 0; }
    }



}
