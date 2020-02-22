using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if there is a touch, move to it
        if (Input.touchCount > 0)
        {
            Vector2 newPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            transform.position = newPoint;
        }

    }
}
