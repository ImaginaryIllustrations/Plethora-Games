using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMove : MonoBehaviour
{
    // Start is called before the first frame update
    



    public float maxYPosition = 4.41f;
    public float minYPosition = -4.19f;
    public float maxXPosition = 8.31f;
    public float minXPosition = -8.68f;

    void Update()
    {


        Vector3 position = transform.position;




        if (position.y > maxYPosition)
        {

            position.y = maxYPosition;
            transform.position = position;
        }

        if (position.y < minYPosition)
        {

            position.y = minYPosition;
            transform.position = position;
        }

        if (position.x > maxXPosition)
        {

            position.x = maxXPosition;
            transform.position = position;
        }

        if (position.x < minXPosition)
        {

            position.x = minXPosition;
            transform.position = position;
        }
    }
}
