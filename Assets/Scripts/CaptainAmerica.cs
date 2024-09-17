using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newHeroName, int newHealth, string newSuitColor)
    : base(newHeroName, newHealth, newSuitColor)
    {

    }

    public void LeapAndJump()
    {
        Debug.Log($"{heroName} is Leaping and jumping...");
    }

    public void ThrowShield()
    {
        Debug.Log($"{heroName} is Throwing shield...");
    }
}
