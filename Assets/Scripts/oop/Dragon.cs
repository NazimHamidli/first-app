using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon :EnemyCapsule, IDamageble, IHealth
{
    public int health { get; set; } = 200;

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

    void Start()
    {
     
        //Damage = 60;
        //base.Attack();
        //EnemyCapsule enemy = new EnemyCapsule();
        //enemy.Damage = 45;
        //enemy.GetDamage();
        //Zombie zombie = new RedZombie();
        //zombie.Attack();
        //Zombie zombie1 = new BlueZombie();
        //zombie1.Attack();
        //Zombie zombie2 = new Zombie();
        //zombie2.Attack();
    }

    void Update()
    {
        
    }
    //void Attack()
    //{
    //    Debug.Log("Dragon Attack");
    //}
}
