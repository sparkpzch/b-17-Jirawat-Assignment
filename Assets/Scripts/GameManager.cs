using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Cat cat;
    Dog dog;
    Rabbit rabbit;

    void Start()
    {
        cat = FindAnyObjectByType<Cat>();
        dog = FindAnyObjectByType<Dog>();
        rabbit = FindAnyObjectByType<Rabbit>();

        Debug.Log($"{cat.CatName} has health : {cat.Health} , Speed : {cat.speed} , Hunger : {cat.GetHunger()}");
        cat.Eat("Meat");
        cat.Climb();
        cat.Move();
        cat.Sleep();
        Debug.Log("-------------------------------------------------");
        Debug.Log($"{dog.DogName} has health : {dog.Health} , Speed : {dog.speed} , Hunger : {dog.GetHunger()}");
        dog.Eat("Meat");
        dog.Move();
        dog.Sleep();
        dog.Fetch();
        Debug.Log("-------------------------------------------------");
        Debug.Log($"{rabbit.RabbitName} has health : {rabbit.Health} , Speed : {rabbit.speed} , Hunger : {rabbit.GetHunger()}");
        rabbit.Eat("Plants");
        rabbit.Move();
        rabbit.Sleep();
    }
}
