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
        skillDict.Add(SKILL.ARROWATTACK, new SkillData(arrowAttack, "ArrowAttack" , "���� �������� ������ �⺻���� �Դϴ�.") );
        skillDict.Add(SKILL.CLOATTACK, new SkillData(cloAttack , "CloAttack" , "monsterCloAttack") );
        skillDict.Add(SKILL.GUARD, new SkillData(gurad, "Guard" , "���� �� ���� ���� �ø��ϴ�. "));
        skillDict.Add(SKILL.MOVE, new SkillData(move , "Move", "�̵� �մϴ�."));
        skillDict.Add(SKILL.PARRYING, new SkillData(parrying,"Parrying" , "ȸ�ǻ��¿� ���� �մϴ�. ���� ������ ȸ�ǽ� �ݰ��մϴ�."));
        skillDict.Add(SKILL.BLEEDING, new SkillData(eat,"Bleeding" , "bleeding"));
        skillDict.Add(SKILL.STUN, new SkillData(stun, "Stun" , "stun"));
        skillDict.Add(SKILL.SHILDATTACK, new SkillData(gurad , "ShildAttack" , "���з� ���� �մϴ�. ���� Ȯ���� ���� �������Ѽ� ������ ���� �մϴ�."));

    }


}
