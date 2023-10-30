using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeShot : BuffStrategy
{


    
    
    public ChargeShot(Character owner,SKILL data) : base(owner, data)
    {
        
    }

    public override void UseSkill(ICharacter target)
    {
        animator.SetBool("Casting", true);
        Buff(target);
    }

    public override void ActiveBuff()
    {
        BuffStrategy buff = IsAlready();
        buff.count -= 1;
        
        if (buff.count <= 0)
        {
            Owner.buffs.Remove(Owner.buffs.Find(x => IsSame(this)));
            animator.SetBool("Casting" , false);
            
            foreach (Character target in BattleManager.enemyArray)
                target.Hit(Owner.CharData.AttackPoint * 2 , Owner);
            
            BattleManager.NextCharacter();
            return;
        }

        

        Debug.Log("casting call");
        BattleManager.NextCharacter();
    }

}
