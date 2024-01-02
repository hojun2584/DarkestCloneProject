using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class JustDie : DieStrategy
{
    Animator aniCompo;
    float dieTime = 2.0f;


    public JustDie(Character owner) : base(owner)
    {

        aniCompo = owner.GetComponent<Animator>();
        

    }
    public override void Die()
    {

        Owner.skills = null;
        Owner.hitStrategy = null;
        Owner.stateMachine = null;
        aniCompo.SetBool("Die", true);
        CorutineRunner.Start(DieCorutin());
        Owner.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator DieCorutin()
    {

        Debug.Log("dieco on");
        yield return new WaitForSeconds(dieTime);
        GameObject.DestroyImmediate(Owner.CharData);
        BattleManager.instance.DieCharacter(Owner);
        GameObject.Destroy(Owner.gameObject);
    }

}
