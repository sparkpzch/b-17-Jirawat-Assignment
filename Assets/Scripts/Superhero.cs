using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Superhero : MonoBehaviour
{
    private string heroName;
    public string HeroName
    {
        get { return heroName; }
        set { heroName = value; }
    }

    public int Health;

    public string suitColor;

    private float armorStrength;
    public float ArmorStrength
    {
        get { return armorStrength; }
        set { armorStrength = value; }
    }

    void UpdateStrength(float newStrength)
    {
        armorStrength = newStrength;
    }

    void TakeDamage(int damage)
    {
        Health -= damage;
    }

    void IsDead()
    {
        if (Health <= 0)
        {
            Debug.Log(name + " is dead.");
        }
    }

    public abstract void Move();

    public abstract void Attack();

    void Start()
    {
        Move();
        Attack();
    }
}
