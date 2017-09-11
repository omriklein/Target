using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ballPrefub; // the object we are shooting
    public float speed; // Change to private
    private const float DISTANCE_FROM_CANON = 1.4f;

    //TODO move to the game manager? -- from xml
    // need to be const - sould not be changed
    public int MAX_BALLS = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider
    private void OnMouseDown()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length < MAX_BALLS)
        {
            GameObject ball = Instantiate<GameObject>(ballPrefub,
                new Vector3(this.transform.position.x, this.transform.position.y + DISTANCE_FROM_CANON, this.transform.position.z),
                    new Quaternion(0f, 0f, 0f, 0f));
            ball.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);
        }
    }
}
