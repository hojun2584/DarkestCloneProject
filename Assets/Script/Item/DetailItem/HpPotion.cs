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

        if(cunsumeTarget is Player)
        {
            if (cunsumeTarget.CharData.Hp == cunsumeTarget.CharData.MaxHp)
            {
                Debug.Log("플로팅 바 띄워서 사용 못하게 하는거 보여주기");
                Debug.Log("안줄어드는게 정상임 체력이 맥스라서 포션 못쓰게 한 거임");
                return;
            }
            Data.Amount -= 1;
            cunsumeTarget.CharData.Hp += healPotion;
        }


    }

    public override void Use(ICharacter user = null, ICharacter target = null)
    {
        base.Use(user, target);
        Cunsume(BattleManager.CurCharacter);
    }

}
