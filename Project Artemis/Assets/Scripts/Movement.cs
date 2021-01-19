using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private float speed = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float xMovement = Input.GetAxis("Horizontal") / 2;
        float yMovement = Input.GetAxis("Vertical") / 2;
       
        Vector2 Move = new Vector2(xMovement, yMovement) * speed;
       GetComponent<Rigidbody2D>().velocity = Move;


    }

    public void increaseSpeed(float s)
    {
        speed += (s / 2);
    }
}
