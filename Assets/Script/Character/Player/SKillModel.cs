using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct SkillData
{

    public SkillData(Sprite icon, string name)
    {
        this.icon = icon;
        this.name = name;
    }


    public Sprite icon;
    public string name;
}



public enum SKILL
{

    ARROWATTACK,
    CLOATTACK,
    GUARD,
    MOVE,
    PARRYING,
    BLEEDING,
    STUN,
    SHILDATTACK,

}

public class SKillModel : MonoBehaviour
{




    [SerializeField]
    Sprite arrowAttack;
    [SerializeField]
    Sprite cloAttack;
    [SerializeField]
    Sprite gurad;
    [SerializeField]
    Sprite move;
    [SerializeField]
    Sprite parrying;
    [SerializeField]
    Sprite eat;
    [SerializeField]
    Sprite stun;
    [SerializeField]
    Sprite shildAttack;


    public static Dictionary<SKILL, SkillData> skillDict = new Dictionary<SKILL, SkillData>();


    public void Awake()
    {
        skillDict.Add(SKILL.ARROWATTACK, new SkillData(arrowAttack, "ArrowAttack") );
        skillDict.Add(SKILL.CLOATTACK, new SkillData(cloAttack , "CloAttack") );
        skillDict.Add(SKILL.GUARD, new SkillData(gurad, "Guard"));
        skillDict.Add(SKILL.MOVE, new SkillData(move , "Move"));
        skillDict.Add(SKILL.PARRYING, new SkillData(parrying,"Parrying"));
        skillDict.Add(SKILL.BLEEDING, new SkillData(eat,"Bleeding"));
        skillDict.Add(SKILL.STUN, new SkillData(stun, "Stun"));
        skillDict.Add(SKILL.SHILDATTACK, new SkillData(gurad , "ShildAttack"));

    }


}