using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryingSkill : BuffStrategy
{

    public ParryingSkill(Character owner, SKILL data) : base(owner, data)
    {
        animator = owner.gameObject.GetComponent<Animator>();
    }

    public override void Buff(ICharacter target, int count = 1)
    {
        Owner.hitStrategy = new Parrying(Owner);
        //!!TODO_LIST dodge ���� ������ �� �ݵ�� �и��ؼ� ������ ��
        Owner.CharData.Dodge = 100;
    }

    public override void UseSkill(ICharacter target)
    {
        Buff(Owner);
        animator.SetBool("Parrying", true);
    }
}

