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
        float xMovement = Input.GetAxis("Horizontal");
        float yMovement = Input.GetAxis("Vertical");
       
        Vector2 Move = new Vector2(xMovement, yMovement) * speed;
       GetComponent<Rigidbody2D>().velocity = Move;


    }
}
