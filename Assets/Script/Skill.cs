using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{

    protected Skill(Character owner)
    {
        //this.data = SKillModel.skillDict[data];
        this.owner = owner;
    }

    public SkillData Data
    {
        get => data;
        set
        {
            data = value;
        }
    }
    SkillData data;


    public Character Owner 
    {
        get 
        {
            return owner;
        }
        set
        {
            owner = value;
        }
    }

    Character owner;
    public abstract void UseSKill(Character target);
    public abstract void UseSkill(List<Character> targets);

}
