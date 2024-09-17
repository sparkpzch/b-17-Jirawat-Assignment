using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{
    public IronMan(string newHeroName, int newHealth, string newSuitColor)
    : base(newHeroName, newHealth, newSuitColor)
    {

    }

    public void Fly()
    {
        Debug.Log($"{heroName} is Flying...");
    }

    public void ShootLaser()
    {
        Debug.Log($"{heroName} is Shooting laser...");
    }
}
