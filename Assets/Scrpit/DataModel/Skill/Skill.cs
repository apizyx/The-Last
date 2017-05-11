using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public abstract class Skill
{
    /// <summary>
    /// 技能效果执行
    /// </summary>
    /// <param name="sourceUnit">源单位</param>
    /// <param name="targetUnitArray">目标单位数值</param>
    /// <param name="environment">技能对应环境</param>
    public abstract void Deal(Unit sourceUnit, Unit[] targetUnitArray, Environment environment = null);

}
