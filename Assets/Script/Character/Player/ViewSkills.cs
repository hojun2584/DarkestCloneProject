using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ViewSkills : MonoBehaviour
{


    [SerializeField]
    List<SkillSlot> skills;

    public void Awake()
    {
        BattleManager.AddChangeSingle(InitView);
    }

    public void InitView()
    {
        int i = 0;
        if (BattleManager.CurCharacter is Player)
        {
            foreach (Skill skill in BattleManager.CurCharacter.skills)
            {
                skills[i].Skill = skill;
                i++;
            }
        }

    }

}
