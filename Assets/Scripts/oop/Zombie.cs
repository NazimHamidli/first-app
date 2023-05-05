using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour ,IDamageble,IHealth
{
    public int health { get; set; } = 100;

    public void Damage(int damage)
    {
        health -= damage;
        Debug.Log(health);
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        // Damage = 15;
        // base.Attack();
 
    }

    public void Attack()
    {
        Debug.Log("Zombie Attack");
    }

}

//public class RedZombie: Zombie
//{
//    public override void Attack()
//    {
//        Debug.Log("RedZombie Attack");
//    }
//}

//public class BlueZombie : Zombie
//{
//    public override void Attack()
//    {
//        Debug.Log("BlueZombie Attack");
//    }
//}