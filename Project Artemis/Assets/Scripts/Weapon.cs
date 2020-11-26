using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private bool IsAttacking = false;
    public int damage = 1;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) && !IsAttacking)
        {
            StartCoroutine(Attack());
        }
    }


    private IEnumerator Attack()
    {

        IsAttacking = true;
        GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(2f);
        GetComponent<BoxCollider2D>().enabled = false;
        IsAttacking = false;
    }
    private IEnumerator Talk()
    {
        bool isTalking = true;
        GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(2f);
        GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        collision.transform.SendMessage("Talk", SendMessageOptions.DontRequireReceiver);
        GetComponent<Collider2D>().enabled = false;


    }




}
