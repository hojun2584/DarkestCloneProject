using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun : BuffStrategy
{

    
    float delayTime =2.0f;


    public Stun(Character owner, SKILL data) : base(owner, data)
    {
        Debug.Log("??");
        animator.SetBool("Stun" , owner);
        count = 2;
    }


    bool GetStun()
    {

        int percent = Random.Range(0, 10);

        if (percent < 4)
            return false;


        return true;
    }

    public override void UseSkill(ICharacter target)
    {
        Buff(target);
    }



    public override void ActiveBuff()
    {

        BuffStrategy buff = IsAlready();
        buff.count -= 1;
        if (buff.count <= 0)
        {
            Owner.buffs.Remove(Owner.buffs.Find(x => IsSame(this)));
            CorutineRunner.Start(DelayAnimation());

        }
        Debug.Log("stunnig call");
        BattleManager.NextCharacter();


    }


    IEnumerator DelayAnimation()
    {

        yield return new WaitForSeconds(delayTime);
        animator.SetBool("Stun" , false);
    }








}
