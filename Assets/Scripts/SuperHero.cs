using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    // Attributes
    protected string heroName;
    public string Name
    {
        get { return heroName; }
        set
        {
            if (value == "" || value.Length < 3 || value.Length > 20 || value == null)
            {
                heroName = "Invalid Name";
                Debug.LogError("Invalid hero name. Please enter a name between 3 and 20 characters.");
            }
            else
            {
                heroName = value;
            }
        }
    }
    protected int heroHealth;

    public int GetHealth
    {
        get { return heroHealth; }
    }

    protected string heroSuitColor;
    public string GetSuitColor
    {
        get { return heroSuitColor; }
    }

    protected float heroArmorStrength = 10f;
    public float GetArmorStrength
    {
        get { return heroArmorStrength; }
    }

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
        // Take damage by calculated the damage after armor reduction
        heroHealth -= (int)(damage / heroArmorStrength);

        if (heroHealth < 0)
        {
            heroHealth = 0;
        }
        Debug.Log($"{heroName} took {damage} damage. Remaining health: {heroHealth}");
    }
}
