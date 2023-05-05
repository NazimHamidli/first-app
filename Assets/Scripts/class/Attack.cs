using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public delegate void ApplyDamage(int damage, HealthController contr
        );
    public static event ApplyDamage applyDamage;
    //{
    //    add
    //    {
    //        Debug.Log("added");
    //    }
    //    remove
    //    {
    //        Debug.Log("removed");

    //    }
    //}
   // public HealthController healthController;
    //void Start()
    //{
    //    applyDamage(50, healthController);
    //}

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            applyDamage?.Invoke(20, other.gameObject.GetComponent<HealthController>());
        }
    }

}
