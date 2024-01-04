using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPotion : Item, IConsumeAbleItem , ICommentAble 
{

    int healPotion = 10;
    string comment;

    public HpPotion(ItemData data) : base(data)
    {
        comment = "HP " + healPotion + "�� ȸ���մϴ�.";
    }
    public string Comment 
    {
        get 
        {
            return comment;
        }
    }
    public void Cunsume(ICharacter cunsumeTarget)
    {

        if (cunsumeTarget.CharData.Hp == cunsumeTarget.CharData.MaxHp)
        {
            MessageBox.ViewMessageBox("HP �� �̹� �� �� �ֽ��ϴ�.");
            return;
        }

        Data.Amount -= 1;
        ((Player)cunsumeTarget).Hp += healPotion;

    }
    public override void Use(ICharacter user = null, ICharacter target = null)
    {
        Cunsume(BattleManager.instance.CurCharacter);
    }

}
