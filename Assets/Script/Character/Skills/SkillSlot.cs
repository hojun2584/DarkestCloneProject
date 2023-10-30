using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlot : MonoBehaviour, IClickUseAble
{


    Image icon;

    public ISkillStrategy Skill
    {
        get => skill;
        set
        {
            skill = value;
            icon.sprite = skill.Data.icon;
        }

    }
    ISkillStrategy skill = null;

    // Start is called before the first frame update
    void Start()
    {
        icon = GetComponent<Image>();
    }



    public void OnClickUse()
    {
        if (BattleManager.isBattleOn == false)
            return;

        if (!(BattleManager.CurCharacter is Player))
            return;

        if (skill == null)
        {
            Debug.Log("click Skill");
            return;
        }
        else
        {
            Debug.Log("go!");
        }
        BattleManager.skill = skill;

    }
}