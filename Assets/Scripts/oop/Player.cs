using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                IDamageble damagable = hit.transform.GetComponent<IDamageble>();
                //if (damagable != null)
                //{
                    damagable?.Damage(50);
               // }
                Debug.Log(hit.collider.name);
            }
        }
    }
}
