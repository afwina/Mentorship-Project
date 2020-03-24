using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;

    Vector2 startPos;
    Rigidbody2D rb;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = cam.ScreenToWorldPoint(Input.mousePosition);
            float newX = Vector2.MoveTowards(transform.position, touchPos, speed).x;
            transform.position = new Vector2(newX, transform.position.y);
        }
        //else if (Input.GetMouseButton(39))
        //{
        //    Vector2 touchPos = cam.ScreenToWorldPoint(Input.mousePosition);
        //    float newX = Vector2.MoveTowards(transform.position, touchPos, speed).x;
        //    transform.position = new Vector2(newX, transform.position.y);

        //}
    }
}
