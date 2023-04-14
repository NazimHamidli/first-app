using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    public Transform turret;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        int a = 0;
        a =a+ 10;
        //GetComponentInParent<Rigidbody>().mass = 100;
        //transform.position = new Vector3(0, 45, 85);
        //  transform.localPosition += new Vector3(4, 1, 3);
        //transform.position.x += 5f; ede bilmerik
        //transform.eulerAngles = new Vector3(45, 0, 0);
        //transform.rotation = Quaternion.identity;
        //transform.localScale = new Vector3(2, 7, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        print(relativePos);
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.forward);
        transform.rotation = rotation;
        //turret.LookAt(target);// script basqa objectin ustunde olduqda
        //transform.LookAt(target);//script eyni objectin ustunde olduqda
        //transform.Rotate(transform.forward*Time.deltaTime*10);
        //transform.Translate(transform.forward * Time.deltaTime * 10);
        //float moveX = Input.GetAxis("Horizontal")*Time.deltaTime*5;
        //float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * 5;
        //transform.Translate(moveX, 0, moveZ);
    }
}
