using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : ScriptableObject
{


    public string Name 
    { 
        get 
        {
            return charName;
        }
        set 
        {
            charName = value;
        }
    }
    [SerializeField] string charName;
    public float Power { get; set; }[SerializeField] float power;
    public float Speed { get; set; }[SerializeField] float speed;
    public float Hp { get; set; }[SerializeField] float hp;
    public int Armor { get; set; }[SerializeField] int armor;

    public CharacterData CloneObj
    {
        get{ return Instantiate(this); }
    }



}
