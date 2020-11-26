using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int damage = 1;
    public float resetTime = 0.25f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        GetComponent<Collider2D>().enabled = false;
        Invoke("ResetTrigger", resetTime);
        
    }

    private void ResetTrigger()
    {
        GetComponent<Collider2D>().enabled = true;
    }


}
