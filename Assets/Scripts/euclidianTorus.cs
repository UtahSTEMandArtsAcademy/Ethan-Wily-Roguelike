using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class euclidianTorus : MonoBehaviour
{
    public bool active;
    public float min, max;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            // Teleport the game object
            if (transform.position.x > max)
            {

                transform.position = new Vector3(min, transform.position.y, 0);

            }
            else if (transform.position.x < min)
            {
                transform.position = new Vector3(max, transform.position.y, 0);
            }

            else if (transform.position.y > max)
            {
                transform.position = new Vector3(transform.position.x, min, 0);
            }

            else if (transform.position.y < min)
            {
                transform.position = new Vector3(transform.position.x, max, 0);
            }
        }
    }
}