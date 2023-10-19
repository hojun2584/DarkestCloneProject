using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum STATE
{

    IDLE = 0,
    MOVE,
    ATTACK,
    CRITICAL,
    HIT,
    DIE,

}

public enum EQUIPWEAPON
{

    SWORD = 0,
    BOW,
    WAND

}

public class Character : MonoBehaviour, ICharacter, IFightAble
{


    public STATE curState;
    protected BaseState myState;
    public CharFsm behaviourFsm;
    protected IAttackStartegy attackStartegy;
    protected IDieStartegy dieStartegy;
    protected IHitStartegy hitStartegy;
    protected EQUIPWEAPON weaponType;
    public WeaponData weapon;

    protected Dictionary<STATE, BaseState> stateDict = new Dictionary<STATE, BaseState>();

    public CharacterData Data 
    {
        get { return data; }
    }
    [SerializeField]
    CharacterData data;

    private void Awake()
    {
        curState = STATE.IDLE;
        behaviourFsm = new CharFsm();

        stateDict.Add(STATE.ATTACK , new AttackState(this, behaviourFsm));
        stateDict.Add(STATE.IDLE , new IdleState(this, behaviourFsm));

        behaviourFsm.ChangeState(stateDict[curState]);

        BattleManager.AddCharacter(this);

    }

    public virtual void StateRun()
    {

        behaviourFsm.ChangeState(stateDict[curState]);
        behaviourFsm.UpdateState();

    }



    private void Update()
    {

        StateRun(); 
    }

    public virtual void Hit(float damage)
    {
        hitStartegy.HitStartegy(damage);
    }

    public virtual void Attack(iDieAble target)
    {
        attackStartegy.AttackStartegy(target);
    }

    public virtual void Die()
    {
        dieStartegy.DieStartegy();
    }
}