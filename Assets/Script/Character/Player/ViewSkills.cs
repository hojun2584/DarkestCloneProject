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
        // ��ų�� ���� �������� �ƴ϶� ��ų�� ���� �����͸� �ѷ��� �� ��
        // �׸���  �� �Ϳ� ���� ���� ���� �� �� set == use ��ų�� �ߵ� �ǰ� ��
        // ����ĳ��Ʈ�� �����ϰ� �� �Ϳ� ���� ���� ������ �̹����� ������Ʈ�� �����°� �´� ��

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
