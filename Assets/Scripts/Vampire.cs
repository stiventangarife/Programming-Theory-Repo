using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE (secondary class)
public class Vampire : Enemys
{
    //ENCAPSULATION
    int damageSecondSkill;

    public Vampire(string id, int secondSkill) : base(id)
    {
        this.damageSecondSkill = secondSkill;
    }

    public override string ToString()
    {
        return base.ToString() + ", Type: Vampire, " + base.ToStringSkill() + " - Second Skill: " + damageSecondSkill;
    }
}
