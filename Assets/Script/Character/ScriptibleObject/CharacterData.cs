using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObject/CharacterData")]
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
    public float SpAttack { get; set; }[SerializeField] float spAttack;
    public float Speed { get; set; }[SerializeField] float speed;
    public float Hp { get; set; }[SerializeField] float hp;
    public int Armor { get; set; }[SerializeField] int armor;

    public CharacterData CloneObj
    {
        get{ return Instantiate(this); }
    }

    public List<string> GetInitList
    {


        get
        {
            List<string> list = new List<string>();

            list.Add(power.ToString() );
            list.Add(spAttack.ToString());
            list.Add(speed.ToString());
            list.Add(hp.ToString());
            list.Add(armor.ToString());

            return list;
        }
    }


}
