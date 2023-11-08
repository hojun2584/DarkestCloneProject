using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class GuardSkill : ISkillStrategy
{
    public GuardSkill(Character owner, SKILL data) : base(owner, data)
    {
        owner.hitStrategy = new Guard(owner);
    }

    public Character Owner => throw new System.NotImplementedException();

    public SkillData Data => throw new System.NotImplementedException();

    public void UseSkill(ICharacter target)
    {
        throw new System.NotImplementedException();
    }
}
