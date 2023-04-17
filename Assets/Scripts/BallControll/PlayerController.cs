using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rigidbody;
    float xInput;
    float zInput;
    Vector3 moveVector;
    public int count;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        moveVector = new Vector3(xInput, 0, zInput);
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(moveVector * speed);
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(0, speed, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin")
        {
            Destroy(other.transform.parent.gameObject);
            count++;
        }
    }
}
