using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabdersi : MonoBehaviour
{

    public GameObject bullet;
    [SerializeField] Transform spawnPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetMouseButtonDown(0))
       //if(Input.GetKeyDown(KeyCode.F))
       if(Input.GetButtonDown("Test"))
        {
           GameObject gameObject = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
            // gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward*500f*Time.deltaTime);
        }
    }
}
