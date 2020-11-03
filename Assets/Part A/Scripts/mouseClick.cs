using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour
{
    public Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = gameObject.GetComponent<Renderer>();
        r.enabled = true;
    }

    // Update is called once per frame
    void Update(){

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (r.enabled)
            {
                r.enabled = false;
            }
            else
            {
                r.enabled = true;
            }
            
        }
    }   
}
