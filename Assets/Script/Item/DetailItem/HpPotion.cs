using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPotion : Item, IConsumeAbleItem
{

    int healPotion = 10;

    public HpPotion(ItemData data) : base(data)
    {

    }

    public void Cunsume(Character cunsumeTarget)
    {

        if(cunsumeTarget is Player)
        {
            if (cunsumeTarget.CharData.Hp == cunsumeTarget.CharData.MaxHp)
            {
                MessageBox.ViewMessageBox("HP �� �̹� �� �� �ֽ��ϴ�.");
                return;
            }

            Data.Amount -= 1;
            cunsumeTarget.CharData.Hp += healPotion;
        }
    }

    public override void Use(Character user = null, Character target = null)
    {
        Cunsume(BattleManager.CurCharacter);
    }

}
