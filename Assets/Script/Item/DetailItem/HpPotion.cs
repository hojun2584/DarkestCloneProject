using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPotion : Item, IConsumeAbleItem
{

    int healPotion = 10;

    public HpPotion(ItemData data) : base(data)
    {

    }

    public void Cunsume(ICharacter cunsumeTarget)
    {

    //    if(cunsumeTarget is Player)
   //     {
            if (cunsumeTarget.CharData.Hp == cunsumeTarget.CharData.MaxHp)
            {
                MessageBox.ViewMessageBox("HP 가 이미 꽉 차 있습니다.");


                return;
            }
            Data.Amount -= 1;
            cunsumeTarget.CharData.Hp += healPotion;
     //   }


    }

    public override void Use(ICharacter user = null, ICharacter target = null)
    {
        base.Use(user, target);
        Cunsume(BattleManager.CurCharacter);
    }

}
