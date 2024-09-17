using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    // Attributes
    public string heroName;
    public int heroHealth;
    public string heroSuitColor;
    public float heroArmorStrength = 10f;

    // Constructor
    public SuperHero(string newHeroName, int newHealth, string newSuitColor)
    {
        heroName = newHeroName;
        heroHealth = newHealth;
        heroSuitColor = newSuitColor;
    }

    public void UpdateArmorStrength(float newArmorStrength)
    {
        heroArmorStrength += newArmorStrength;
        Debug.Log($"{heroName}'s armor strength is now {heroArmorStrength}.");
    }

    public bool IsDead()
    {
        return heroHealth <= 0;
    }

    public void TakeDamage(int damage)
    {
        heroHealth -= damage;
        Debug.Log($"{heroName} took {damage} damage. Remaining health: {heroHealth}");
    }
}
