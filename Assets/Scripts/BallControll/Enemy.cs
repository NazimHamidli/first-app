using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Enemy 
{
    public float speed;
    float _health;
    public float damage;

    public Enemy()
    {
        damage = 50;
        Debug.Log(damage);
    }
    public Enemy(float health, float damage,float speed)
    {
        _health = health;
        this.damage = damage;
        this.speed = speed;
        Debug.Log(_health);
        Debug.Log(this.damage);
        Debug.Log(this.speed);

    }

    public float Health
    {
        set { _health = value; }
        get { return _health; }
    }

    public void ShowHelath()
    {
        Debug.Log(Health);
    }
}
