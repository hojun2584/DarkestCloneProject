using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : PlayerAttack
{
    public Charge(Character owner, SKILLENUM data) : base(owner, data)
    {
    }

    public override float Damage => throw new System.NotImplementedException();

    public override void Attack(IHitAble target)
    {
        throw new System.NotImplementedException();
    }

    public override void UseSkill(ICharacter target)
    {

        List<Character> enemy = new List<Character>();

        foreach (Character myCaracter in BattleManager.instance.enemyArray) 
            enemy.Add(myCaracter);

        

    }

}
