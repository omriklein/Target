using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            print("Duplicate GameObject - " + this.gameObject.name);
            Instantiate(this.gameObject);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            print("Delete GameObject - " + this.gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
