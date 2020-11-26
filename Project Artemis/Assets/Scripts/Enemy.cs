using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health = 10;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int DamagePoints)
    {

        health -= DamagePoints;
        Debug.Log("EnemyLostHealth");
        if (health == 0 )
        {
            Destroy(gameObject);
        }
    }

}
