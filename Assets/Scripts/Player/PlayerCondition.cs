using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakePhysicalDamage(int damage);
}
public class PlayerCondition : MonoBehaviour, IDamageable
{
    public UICondition uicondition;

    Condition health { get { return uicondition.health; } }
    Condition hunger { get { return uicondition.hunger; } }
    Condition stamina { get { return uicondition.stamina; } }

    public float noHungerhealthDecay;

    public event Action onTakeDamage;

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

    public void Heal(float amount)
    {
        health.Add(amount);
    }
    public void Eat(float amount)
    {
        hunger.Add(amount);
    }



    public void Die()
    {

    }

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
        onTakeDamage.Invoke();
    }
}
