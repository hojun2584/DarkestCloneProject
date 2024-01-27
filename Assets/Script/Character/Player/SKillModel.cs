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



public enum SkillViewData
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


    public static Dictionary<SkillViewData, SkillData> skillDict = new Dictionary<SkillViewData, SkillData>();


    public void Awake()
    {
        skillDict.Clear();
        
        skillDict.Add(SkillViewData.ARROWATTACK, new SkillData(arrowAttack, "ArrowAttack" , "���� �������� ������ �⺻���� �Դϴ�.") );
        skillDict.Add(SkillViewData.EXPLOSIONARROW , new SkillData(arrowAttack, "Explosion", "��ü ������ �ϴ� ��ų�Դϴ�. 2���� �Һ� �մϴ�."));
        skillDict.Add(SkillViewData.CLOATTACK, new SkillData(cloAttack , "CloAttack" , "monsterCloAttack") );
        skillDict.Add(SkillViewData.GUARD, new SkillData(gurad, "Guard" , "���� �� ���� ���� �ø��ϴ�. "));
        skillDict.Add(SkillViewData.MOVE, new SkillData(move , "Move", "�̵� �մϴ�."));
        skillDict.Add(SkillViewData.PARRYING, new SkillData(parrying,"Parrying" , "ȸ�ǻ��¿� ���� �մϴ�. ���� ������ ȸ�ǽ� �ݰ��մϴ�."));
        skillDict.Add(SkillViewData.BLEEDING, new SkillData(eat,"Bleeding" , "bleeding"));
        skillDict.Add(SkillViewData.STUN, new SkillData(stun, "Stun" , "stun"));
        skillDict.Add(SkillViewData.SHILDATTACK, new SkillData(gurad , "ShildAttack" , "���з� ���� �մϴ�. ���� Ȯ���� ���� �������Ѽ� ������ ���� �մϴ�."));
    }


}
