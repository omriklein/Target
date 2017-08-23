using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public float TILE_SIZE = 1; // Change to private const
    public Vector3 mousePosition; // Vector3 VS Vector2

    public float mouseX = 0, mouseY = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        // Reset the mouse position with the current triangle.
        // * mousePosition = this.transform.position;

        mouseX = 0;
        mouseY = 0;
    }

    private void OnMouseDrag()
    {
        // Make the position inside the squers...
        // Check about the number - 3. if this is good make it a const variable
        // this.transform.position += new Vector3(Input.GetAxis("Mouse X") / 3, Input.GetAxis("Mouse Y") / 3, 0f);

        mouseX += Input.GetAxis("Mouse X") / (3 * 6); // 3 >> (3 * 6)
        mouseY += Input.GetAxis("Mouse Y") / (3 * 6);

        // The distance from the center of the tile to the end of the "inside area"        = 1/4 Cube size = 0.25
        // The distance from the "inside area" to the outside of the tile                  = 1/4 Cube size = 0.25
        // The distance form the outside of the tile to the "inside area" of the next tile = 1/4 Cube size = 0.25

        if (Mathf.Abs(mouseX) >= 0.75f * TILE_SIZE)
        {
            this.transform.position += new Vector3(TILE_SIZE * (mouseX >= 0 ? 1 : -1), 0f, 0f);

            mouseX += 0.75f * TILE_SIZE * (mouseX >= 0 ? -1 : 1);
        }
        if (Mathf.Abs(mouseY) >= 0.75f * TILE_SIZE)
        {
            this.transform.position += new Vector3(0f, TILE_SIZE * (mouseY >= 0 ? 1 : -1), 0f);

            mouseY += 0.75f * TILE_SIZE * (mouseY >= 0 ? -1 : 1);
        }

        // Change the mousePosition with the mouse movement
        #region delete this part
        /*
        mousePosition += new Vector3(Input.GetAxis("Mouse X") / 3, Input.GetAxis("Mouse Y") / 3, 0f);

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Floor"))
        {
            if (mousePosition.x >= item.transform.position.x - (1 / 2) * CUBE_LENGTH && mousePosition.x <= item.transform.position.x + (1 / 2) * CUBE_LENGTH)
            {
                print(item.name);
            }
            else
            {
                print("mop");
            }
        }
        */
        //this.transform.position = mousePosition;

        // The X axis
        /*if (mousePosition.x == this.transform.position.x + (1 / 2) * CUBE_LENGTH)
        {
            print("move right");
        }
        else
        {
            print(mousePosition.x + " -- " + this.transform.position.x + " + " + (1 / 2) * CUBE_LENGTH);
        }*/
        #endregion
    }
}
