using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    /// <summary>
    /// This script is for the ball movement
    /// Here we detect the collisions with the walls and the target
    /// </summary>

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Respawn")
            Destroy(this.gameObject);
        if (other.gameObject.tag == "Finish")
        {
            print("nice");
            Destroy(this.gameObject);
        }
    }
}
