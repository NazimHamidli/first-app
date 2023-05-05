using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{

    private void OnEnable()
    {
        Debug.Log("Enabled");
        Attack.applyDamage += this.ApplyDamage;
    }

    void OnDisable()
    {
        Debug.Log("Disabled");
        Attack.applyDamage -= this.ApplyDamage;
    }

    void ApplyDamage(int damage, HealthController healthController)
    {
        healthController.Health -= damage;
        Debug.Log("Damaged");
    }
}
