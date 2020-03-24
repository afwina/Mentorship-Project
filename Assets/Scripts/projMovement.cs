using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveUp();
    }

    private void moveUp()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed);
    }

    private void OnBecameInvisible()
    {
        Debug.Log("offscreen");
        Destroy(gameObject);
    }
}
