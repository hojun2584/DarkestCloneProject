using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun : Buff
{
    float delayTime =2.0f;

    public Stun(Character owner) : base(owner)
    {
        animator.SetBool("Stun" , true);
        count = 2;
    }



    public override void ActiveBuff()
    {

        Buff buff = Owner.IsAlreadyBuff(this);
        buff.count -= 1;
        if (buff.count <= 0)
        {
            Owner.RemoveBuff(this);
            CorutineRunner.Start(DelayAnimation());
        }
        
        BattleManager.instance.NextCharacter();
    }


    IEnumerator DelayAnimation()
    {
        yield return new WaitForSeconds(delayTime);
        animator.SetBool("Stun" , false);
    }








}
