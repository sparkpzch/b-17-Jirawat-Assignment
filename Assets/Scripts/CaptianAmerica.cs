using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptianAmerica : Superhero
{
    public override void Attack()
    {
        Debug.Log($"{HeroName} is throwing shield.");
    }

    public override void Move()
    {
        Debug.Log($"{HeroName} is leaping and jumping.");
    }
}
