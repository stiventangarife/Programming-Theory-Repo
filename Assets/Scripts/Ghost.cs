using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE (secondary class)
public class Ghost : Enemys
{
    //ENCAPSULATION
    int damageSecondSkill;

    public Ghost(string id, int secondSkill) : base (id)
    {
        this.damageSecondSkill = secondSkill;
    }

    public override string ToString()
    {
        return base.ToString() + ", Type: Ghost, " + base.ToStringSkill() + " - Second Skill: " + damageSecondSkill;
    }
}
