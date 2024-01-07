using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObject/WeaponData")]
public class WeaponData : ItemData
{
    public float AttackPoint
    {
        get { return attackPoint; }
        set { attackPoint = value; }
    }
    [SerializeField] float attackPoint;
    public float SpAttack
    {
        get { return SpAttack; }
        set { spAttack = value; }
    }
    [SerializeField] float spAttack;
    public float Spped { get => speed; set { speed = value; } }
    [SerializeField] float speed;
    public float Critical { get => critical; set { critical = value; } }
    [SerializeField] float critical;
    public float MaxHp { get => maxHp; set { maxHp = value; } }
    [SerializeField] float maxHp;
    public int Armor { get => armor; set { armor = value; } }
    [SerializeField] int armor;
    public int Dodge { get => dodge; set { dodge = value; } }
    [SerializeField] int dodge;
    public string Comment 
    {
        get 
        {
            return comment;
        }
    }
    [SerializeField] string comment;

}
