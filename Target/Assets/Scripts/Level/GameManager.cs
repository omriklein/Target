using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// this may be changed ***
    /// </summary>

    public GameObject Tile;

    // Use this for initialization
    void Start()
    {
        creadBoard(Tile, new Vector3(-4f, -4f, -1f) /*new Vector3(-4.5f, -4.5f, -1f)*/);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Creates a Board of tiles in the game
    /// </summary>
    /// <param name="tile">The tile prefub</param>
    /// <param name="pos">The initial position (Botton Left)</param>
    /// <param name="height"></param>
    /// <param name="width"></param>
    private void creadBoard(GameObject tile, Vector3 pos, int height = 10, int width = 10)
    {

        for (int i = 0; i < height; i += 2 /*i++*/)
        {
            for (int j = 0; j < width; j += 2 /*j++*/)
            {
                /*GameObject t = */
                Instantiate<GameObject>(tile, new Vector3(pos.x + j, pos.y + i, 0f), new Quaternion());
            }
        }
    }
}
