using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction<int> HealthChanged;

    public void ApplyDamage(int damage)
    {
        if (_health > 0)
        {
            _health -= damage;
            HealthChanged?.Invoke(_health);
            if (_health <= 0 )
                Die();
        }
    }

    public void ApplyHeal(int heal)
    {       
        if (_health < 100)
        {
            _health += heal;
            HealthChanged?.Invoke(_health);
        }
    }

    private void Die()
    {
        //Смерть;
    }
}
