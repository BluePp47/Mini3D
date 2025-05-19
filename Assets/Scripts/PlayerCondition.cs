using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uicondition;

    Condition health { get { return uicondition.health; } }
    Condition hunger { get { return uicondition.hunger; } }
    Condition stamina { get { return uicondition.stamina; } }

    public float noHungerhealthDecay;
    void Update()
    {
        hunger.Subtract(hunger.passiveValue * Time.deltaTime);
        stamina.Add(stamina.passiveValue * Time.deltaTime);
        if(hunger.curValue == 0f)
        {
            health.Subtract(noHungerhealthDecay *Time.deltaTime);
        }
        if(health.curValue == 0f)
        {
            Die();
        }
    }

    public void Die()
    {

    }
}
