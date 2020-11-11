using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private bool IsAttacking = false;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }
    public void Attack()
    {
        if (!IsAttacking)
        {
            IsAttacking = true;
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = false;
            Invoke("endAttack", 1f);
        }
    }

    private void endAttack()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        IsAttacking = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Did i hit something?");
        collision.transform.SendMessage("Hit", SendMessageOptions.DontRequireReceiver);
    }

}
