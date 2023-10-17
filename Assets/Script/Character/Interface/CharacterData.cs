using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CharcterData", menuName = "ScriptableObject/CharacterData")]
public class CharacterData : ScriptableObject
{

    public string CharacterName { get; set; }
    [SerializeField] string characterName;
    public int Hp { get; set; }
    [SerializeField] int hp;
    public int Mp { get; set; }
    [SerializeField] int mp;
    public int Attack { get; set; } 
    [SerializeField] int attack;
    public float Speed { get; set; }
    [SerializeField] float speed;
    public int SpecialAttack { get; set; } 
    [SerializeField] int specialAttack;

    public CharacterData CloneObj 
    {
        get
        {
            return Instantiate(this);
        }
    }

}
