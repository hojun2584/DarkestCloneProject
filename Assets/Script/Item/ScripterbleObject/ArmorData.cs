using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArmorData", menuName = "ScriptableObject/ArmorData")]
public class ArmorData : ScriptableObject
{

    public float AttackPoint { get; set; }[SerializeField] float attackPoint;
    public float SpAttack { get; set; }[SerializeField] float spAttack;
    public float Spped { get; set; }[SerializeField] float speed;
    public float MaxHp { get; set; }[SerializeField] float maxHp;
    public int Armor { get; set; }[SerializeField] int armor;
    public int Dodge { get; set; }[SerializeField] int dodge;


    public ArmorData CloneObj
    {
        get
        {
            return Instantiate(this);
        }
    }


}
