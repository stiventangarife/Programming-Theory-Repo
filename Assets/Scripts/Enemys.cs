using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE (primary class)
public class Enemys : Object
{
    //ENCAPSULATION
    string idCode;
    int damageBase = 10;

    public Enemys(string id)
    {
        idCode = id;
    }

    public virtual string ToString()
    {
        return "Id Code Enemy: " + idCode; 
    }

    public virtual string ToStringSkill()
    {
        return "Primary Skill: " + damageBase;
    }
}
