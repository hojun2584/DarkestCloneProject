using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ViewSkills : MonoBehaviour
{


    [SerializeField]
    List<SkillSlot> skills;

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        // 스킬에 대한 아이콘이 아니라 스킬에 대한 데이터를 뿌려야 할 듯
        // 그리고  그 것에 대한 값이 설정 될 때 set == use 스킬이 발동 되게 끔
        // 레이캐스트를 설정하고 그 것에 대한 값을 각각의 이미지가 컴포넌트가 가지는게 맞는 듯

        if (BattleManager.instance.CurCharacter is Player) 
        { 
        
            foreach (ISkillStrategy skill in BattleManager.instance.CurCharacter.skills)
            {
                skills[i].Skill = skill;
                i++;
            }

        }



    }
}
