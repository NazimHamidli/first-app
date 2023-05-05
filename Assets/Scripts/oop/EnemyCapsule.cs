using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCapsule: MonoBehaviour
{
    private int damage = 25;
    public int Damagel
    {
       private get {return damage ; }
        set {
            if (value > 10)
            {
                damage = value;
            }
        }
    }


 public void Attack()
    {
        Debug.Log("Attack");
    }
}
