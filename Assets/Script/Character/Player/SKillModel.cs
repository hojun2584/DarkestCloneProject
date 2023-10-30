using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct SkillData
{

    public SkillData(Sprite icon, string name, string comment)
    {
        this.icon = icon;
        this.name = name;
        this.comment = comment;
    }


    public Sprite icon;
    public string name;
    public string comment;
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
        skillDict.Add(SKILL.ARROWATTACK, new SkillData(arrowAttack, "ArrowAttack" , "약한 데미지를 입히는 기본공격 입니다.") );
        skillDict.Add(SKILL.CLOATTACK, new SkillData(cloAttack , "CloAttack" , "monsterCloAttack") );
        skillDict.Add(SKILL.GUARD, new SkillData(gurad, "Guard" , "다음 턴 까지 방어도를 올립니다. "));
        skillDict.Add(SKILL.MOVE, new SkillData(move , "Move", "이동 합니다."));
        skillDict.Add(SKILL.PARRYING, new SkillData(parrying,"Parrying" , "회피상태에 돌입 합니다. 적의 공격을 회피시 반격합니다."));
        skillDict.Add(SKILL.BLEEDING, new SkillData(eat,"Bleeding" , "bleeding"));
        skillDict.Add(SKILL.STUN, new SkillData(stun, "Stun" , "stun"));
        skillDict.Add(SKILL.SHILDATTACK, new SkillData(gurad , "ShildAttack" , "방패로 공격 합니다. 낮은 확률로 적을 기절시켜서 한턴을 쉬게 합니다."));

    }


}
