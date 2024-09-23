using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    // ----------------- Stats -----------------

    private string rabbitName;
    public string RabbitName
    {
        get { return rabbitName; }
        set { rabbitName = "Rabbit"; }
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

    protected string[] foods;

    // ----------------- Methods -----------------

    public void Eat(string food)
    {
        Debug.Log($"{rabbitName} is eating...");
    }

    public void Move()
    {
        Debug.Log($"{rabbitName} is moving...");
    }

    public void Sleep()
    {
        Debug.Log($"{rabbitName} is sleeping...");
    }
}
