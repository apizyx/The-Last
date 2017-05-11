
using System;
using System.Collections;

public class TestSkill : Skill
{
    // Use this for initialization
    public override void Deal(Unit sourceUnit, Unit[] targetUnitArray, Environment environment = null)
    {
        targetUnitArray[0].HP -= 40;
    }

}
