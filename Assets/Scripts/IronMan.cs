using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : Superhero
{
    public override void Attack()
    {
        Debug.Log($"{HeroName} is shooting laser.");
    }

    public override void Move()
    {
        Debug.Log($"{HeroName} is flying.");
    }
}