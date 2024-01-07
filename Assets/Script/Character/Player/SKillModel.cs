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



public enum SKILLENUM
{

    ARROWATTACK,
    CLOATTACK,
    GUARD,
    MOVE,
    PARRYING,
    BLEEDING,
    STUN,
    SHILDATTACK,
    EXPLOSIONARROW
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


    public static Dictionary<SKILLENUM, SkillData> skillDict = new Dictionary<SKILLENUM, SkillData>();


    public void Awake()
    {
        skillDict.Clear();
        
        skillDict.Add(SKILLENUM.ARROWATTACK, new SkillData(arrowAttack, "ArrowAttack" , "약한 데미지를 입히는 기본공격 입니다.") );
        skillDict.Add(SKILLENUM.EXPLOSIONARROW , new SkillData(arrowAttack, "Explosion", "전체 공격을 하는 스킬입니다. 2턴을 소비 합니다."));
        skillDict.Add(SKILLENUM.CLOATTACK, new SkillData(cloAttack , "CloAttack" , "monsterCloAttack") );
        skillDict.Add(SKILLENUM.GUARD, new SkillData(gurad, "Guard" , "다음 턴 까지 방어도를 올립니다. "));
        skillDict.Add(SKILLENUM.MOVE, new SkillData(move , "Move", "이동 합니다."));
        skillDict.Add(SKILLENUM.PARRYING, new SkillData(parrying,"Parrying" , "회피상태에 돌입 합니다. 적의 공격을 회피시 반격합니다."));
        skillDict.Add(SKILLENUM.BLEEDING, new SkillData(eat,"Bleeding" , "bleeding"));
        skillDict.Add(SKILLENUM.STUN, new SkillData(stun, "Stun" , "stun"));
        skillDict.Add(SKILLENUM.SHILDATTACK, new SkillData(gurad , "ShildAttack" , "방패로 공격 합니다. 낮은 확률로 적을 기절시켜서 한턴을 쉬게 합니다."));
    }


}
