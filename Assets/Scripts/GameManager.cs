using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public IronMan ironMan;
    public CaptainAmerica captainAmerica;

    void Start()
    {
        ironMan.Name = "LungTony";

        Debug.Log($"{ironMan.Name} has {ironMan.GetHealth} health and wears a {ironMan.GetSuitColor} suit.");
        Debug.Log($"{captainAmerica.Name} has {captainAmerica.GetHealth} health and wears a {captainAmerica.GetSuitColor} suit.");

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
