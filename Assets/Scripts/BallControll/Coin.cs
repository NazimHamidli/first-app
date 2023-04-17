using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(transform.up *Time.deltaTime);
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, speed,0);

    }
}
