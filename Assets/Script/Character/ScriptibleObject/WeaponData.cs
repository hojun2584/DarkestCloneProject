using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObject/WeaponData")]
public class WeaponData : ScriptableObject
{
    public int AttackPoint { get; set; } [SerializeField]int attackPoint;
    public int Speed { get; set; } [SerializeField]int speed;
    public int Critical { get; set; } [SerializeField] int critical;

}
