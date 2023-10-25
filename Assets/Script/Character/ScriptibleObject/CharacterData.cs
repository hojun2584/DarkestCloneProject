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
    public float AttackPoint { get => power; set { power = value; } }
    [SerializeField] float power;
    public float Critical { get => critical; set { critical = value; } }
    [SerializeField] float critical;
    public float SpAttack { get => SpAttack; set { spAttack = value; } }
    [SerializeField] float spAttack;
    public float Speed { get => speed; set { speed = value; } }
    [SerializeField] float speed;
    public float Fear { get => fear; set { fear = value; } }
    [SerializeField] float fear;
    public float Hp 
    {
        get
        {
            return hp;
        }
        set
        {
            if (value < maxHp)
                hp = value;
            else
                hp = maxHp;
        }
    }[SerializeField] float hp;
    public float MaxHp { get => maxHp; set { maxHp = value; } }
    [SerializeField] float maxHp;
    public int Armor { get => armor; set { armor = value; } }
    [SerializeField] int armor;
    public int Dodge { get => dodge; set { dodge = value; } }
    [SerializeField] int dodge;
    public int Accuracy { get => accuracy; set { accuracy = value; } }
    [SerializeField] int accuracy;
    public List<IEquipeAbleItem> EquipItems { get => equipeItems; }
    [SerializeField] List<IEquipeAbleItem> equipeItems = new List<IEquipeAbleItem>();

    public List<IHitStrategy> skill = new List<IHitStrategy>();

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

            list.Add(Hp.ToString() + " / " +maxHp.ToString());
            list.Add(Fear.ToString());
            list.Add(critical.ToString());
            list.Add(Accuracy.ToString());
            list.Add(AttackPoint.ToString());
            list.Add(dodge.ToString());
            list.Add(armor.ToString());
            list.Add(Speed.ToString());
            return list;
        }
    }


}
