using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudTwoMovement : MonoBehaviour
{
    Vector2 temp;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        temp = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //These functions will make the cloud move
        //different directions without any keys being pressed.
        //Going to add a timer to the functions so that the
        //cloud will switch directions 
        moveRight();
        moveLeft();
    }
    private void moveRight()
    {
        //Cloud will move to the right
        temp.x += 1f;
    }
    private void moveLeft()
    {
        //Cloud will move to the left
        temp.x -= 1f;
    }
}
