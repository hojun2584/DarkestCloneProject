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
        
        skillDict.Add(SKILLENUM.ARROWATTACK, new SkillData(arrowAttack, "ArrowAttack" , "���� �������� ������ �⺻���� �Դϴ�.") );
        skillDict.Add(SKILLENUM.EXPLOSIONARROW , new SkillData(arrowAttack, "Explosion", "��ü ������ �ϴ� ��ų�Դϴ�. 2���� �Һ� �մϴ�."));
        skillDict.Add(SKILLENUM.CLOATTACK, new SkillData(cloAttack , "CloAttack" , "monsterCloAttack") );
        skillDict.Add(SKILLENUM.GUARD, new SkillData(gurad, "Guard" , "���� �� ���� ���� �ø��ϴ�. "));
        skillDict.Add(SKILLENUM.MOVE, new SkillData(move , "Move", "�̵� �մϴ�."));
        skillDict.Add(SKILLENUM.PARRYING, new SkillData(parrying,"Parrying" , "ȸ�ǻ��¿� ���� �մϴ�. ���� ������ ȸ�ǽ� �ݰ��մϴ�."));
        skillDict.Add(SKILLENUM.BLEEDING, new SkillData(eat,"Bleeding" , "bleeding"));
        skillDict.Add(SKILLENUM.STUN, new SkillData(stun, "Stun" , "stun"));
        skillDict.Add(SKILLENUM.SHILDATTACK, new SkillData(gurad , "ShildAttack" , "���з� ���� �մϴ�. ���� Ȯ���� ���� �������Ѽ� ������ ���� �մϴ�."));
    }


}
