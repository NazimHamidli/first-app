using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    [SerializeField] int _health;
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
}
