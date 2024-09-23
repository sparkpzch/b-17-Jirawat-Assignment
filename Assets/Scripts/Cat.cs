using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // ----------------- Stats -----------------

    private string catName;
    public string CatName
    {
        get { return catName; }
        set { catName = "Cat"; }
    }

    private int health = 10;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public readonly float speed = 3f;

    private float hunger = 0f;

    public float GetHunger()
    {
        return hunger;
    }
    public void SetHunger(float newHunger)
    {
        hunger = newHunger;
    }

    protected string[] foods = { "Meat", "Plants" };

    // ----------------- Methods -----------------

    public string Eat(string food)
    {
        Debug.Log($"{catName} is eating...{food}");
        return $"{catName} is eating...{food}";
    }

    public void Move()
    {
        Debug.Log($"{catName} is moving...");
    }

    public void Sleep()
    {
        Debug.Log($"{catName} is sleeping...");
    }

    public void Climb()
    {
        Debug.Log($"{catName} is climbing...");
    }
}
