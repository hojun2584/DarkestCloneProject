using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArcherCharacter : Player
{

    public new void Awake()
    {
        base.Awake();
        //�ּ� 4���� ���� ���� �� 

        skills.Add(new SwordSkill(this));

        


    }

    public new void Update()
    {
        base.Update();
        if(stateMachine != null)
            stateMachine.UpdateState();


        
    }



    public override void UseSkill(Character target)
    {
        selectSkill.UseSKill(target);
    }

}
