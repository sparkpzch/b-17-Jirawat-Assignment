using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        IronMan ironMan = new IronMan();
        ironMan.Attack();
        ironMan.Move();

        CaptianAmerica captianAmerica = new CaptianAmerica();
        captianAmerica.Attack();
        captianAmerica.Move();

        newHero newHero = new newHero();
        newHero.Attack();
        newHero.Move();
        newHero.specialAbility();
    }
}
