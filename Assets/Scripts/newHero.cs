using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newHero : Superhero
{

    public override void Attack()
    {
        Debug.Log($"{HeroName} is attacking.");
    }

    public override void Move()
    {
        Debug.Log($"{HeroName} is running.");
    }

    public void specialAbility()
    {
        Debug.Log($"{HeroName} is using special ability.");
    }

    void Start()
    {
        specialAbility();
    }
}
