using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class derstransform : MonoBehaviour
{
   public GameObject gameObject;
    public GameObject[] gameObjects;

    void Start()
    {
        //gameObject = GameObject.Find("Sphere/Capsule/Cylinder");
        // GameObject.Find("GameObject").SendMessage("CallMe",20);
        // gameObject = GameObject.Find("GameObject");
        // gameObject.GetComponent<FirstScript>().CallMe(15);
        //gameObject = GameObject.FindWithTag("firstTag");

        // gameObjects = GameObject.FindGameObjectsWithTag("firstTag");

        //foreach (GameObject gameObjwect in gameObjects)
        //{
        //    gameObjwect.SetActive(false);
        //}

       // GetComponentInParent<FirstScript>().CallMe(45);
       GetComponentInChildren<FirstScript>().CallMe(45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
