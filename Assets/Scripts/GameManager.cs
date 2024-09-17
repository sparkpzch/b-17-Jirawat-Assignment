using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    IronMan ironMan = new IronMan("Tony Stark", 100, "Red");
    CaptainAmerica captainAmerica = new CaptainAmerica("Steve Rogers", 100, "Blue");

    void Start()
    {
        Debug.Log($"{ironMan.heroName} has {ironMan.heroHealth} health and wears a {ironMan.heroSuitColor} suit.");
        Debug.Log($"{captainAmerica.heroName} has {captainAmerica.heroHealth} health and wears a {captainAmerica.heroSuitColor} suit.");

        ironMan.UpdateArmorStrength(5.25f);
        captainAmerica.UpdateArmorStrength(5.5f);
    }

    void Update()
    {
        if (ironMan.IsDead() || captainAmerica.IsDead())
        {
            return;
        }

        // Iron Man's turn
        int randomDamage = Random.Range(10, 21);
        ironMan.ShootLaser();
        captainAmerica.TakeDamage(randomDamage);


        // Captain America's turn
        randomDamage = Random.Range(10, 21);
        captainAmerica.ThrowShield();
        ironMan.TakeDamage(randomDamage);
    }
}
