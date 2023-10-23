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
    public float AttackPoint { get; set; }[SerializeField] float power;
    public float SpAttack { get; set; }[SerializeField] float spAttack;
    public float Speed { get; set; }[SerializeField] float speed;
    public float Hp { get; set; }[SerializeField] float hp;
    public float MaxHp { get; set; }[SerializeField] float maxHp;
    public int Armor { get; set; }[SerializeField] int armor;
    public int Dodge { get; set; }[SerializeField] int dodge;
    public List<IEquipeAbleItem> EquipItems { get;}
    [SerializeField] List<IEquipeAbleItem> equipeItems = new List<IEquipeAbleItem>();

    public List<ISkillStrategy> skill = new List<ISkillStrategy>();

    public CharacterData CloneObj
    {
        get { return Instantiate(this); }
    }


    public void AddArmor(IEquipeAbleItem armor)
    {
        AttackPoint += armor.ArmorInfo.AttackPoint;
        Speed += armor.ArmorInfo.Spped;
        SpAttack += armor.ArmorInfo.SpAttack;
        MaxHp += armor.ArmorInfo.MaxHp;
        Armor += armor.ArmorInfo.Armor;
        Dodge += armor.ArmorInfo.Dodge;
        equipeItems.Add(armor);
    }

    public void PopArmor(IEquipeAbleItem armor)
    {
        int index = equipeItems.IndexOf(armor);
        AttackPoint -= armor.ArmorInfo.AttackPoint;
        Speed -= armor.ArmorInfo.Spped;
        SpAttack -= armor.ArmorInfo.SpAttack;
        MaxHp -= armor.ArmorInfo.MaxHp;
        Armor -= armor.ArmorInfo.Armor;
        Dodge -= armor.ArmorInfo.Dodge;
        equipeItems.RemoveAt(index);



    }

    public List<string> GetInitList
    {


        get
        {
            List<string> list = new List<string>();

            list.Add(charName);
            list.Add(power.ToString() );
            list.Add(spAttack.ToString());
            list.Add(speed.ToString());
            list.Add(hp.ToString());
            list.Add(armor.ToString());

            return list;
        }
    }


}
