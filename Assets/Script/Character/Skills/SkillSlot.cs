using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlot : MonoBehaviour, IClickUseAble , IExplainAble
{


    Image icon;

    public Skill Skill
    {
        get => skill;
        set
        {
            skill = value;
            icon.sprite = value.Data.icon;
        }

    }

    public string Comment 
    {
        get 
        {
            if(skill == null)
            {
                return null;
            }

            return skill.Data.comment;
        }
    }

    Skill skill = null;

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
            BattleManager.skill = skill;
            Debug.Log("go!");
        }
        
    }

}