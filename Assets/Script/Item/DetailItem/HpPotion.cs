using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPotion : Item, IConsumeAbleItem
{

    int healPotion = 10;

    protected HpPotion(ItemData data) : base(data)
    {

    }

    public void Cunsume(ICharacter cunsumeTarget)
    {
        Data.Amount -= 1;

        if(cunsumeTarget as Player != null)
            cunsumeTarget.CharData.Hp += healPotion;

    }

    public override void Use(ICharacter user = null, ICharacter target = null)
    {
        base.Use(user, target);

        if (CharacterRay.curCharacter != null)
            Cunsume(CharacterRay.curCharacter);


    }

}
