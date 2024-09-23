using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    // ----------------- Stats -----------------

    private string dogName;
    public string DogName
    {
        get { return dogName; }
        set { dogName = "Dog"; }
    }

    private string breed;
    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    private int health = 10;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public readonly float speed = 3f;

    private float hunger = 0f;

    protected string[] foods;

    public float GetHunger()
    {
        return hunger;
    }

    public void SetHunger(float newHunger)
    {
        hunger = newHunger;
    }

    // ----------------- Methods -----------------

    public void Eat(string food)
    {
        Debug.Log($"{dogName} is eating...");
    }

    public void Move()
    {
        Debug.Log($"{dogName} is moving...");
    }

    public void Sleep()
    {
        Debug.Log($"{dogName} is sleeping...");
    }

    public void Fetch()
    {
        Debug.Log($"{dogName} is fetching...");
    }
}
