using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOpacity : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PlayerCollider")
        {
            GetComponentInParent<SpriteRenderer>().color = new Color(1, 1, 1, 0.7f);
            //GetComponent<Transform>().position = new Vector3(0, 0, 0.01f);
            transform.parent.position = new Vector3(transform.position.x, transform.position.y, -0.01f);
        } 
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PlayerCollider")
        {
            GetComponentInParent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            transform.parent.position = new Vector3(transform.position.x, transform.position.y, 0.01f);
            //GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
    }
}
