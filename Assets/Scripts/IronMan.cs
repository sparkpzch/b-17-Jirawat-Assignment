using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{

    public void Fly()
    {
        Debug.Log($"{heroName} is Flying...");
    }

    public void ShootLaser()
    {
        Debug.Log($"{heroName} is Shooting laser...");
    }
}
