using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health = 10;

    [SerializeField]
    private int xpValue;

    public Player player;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int DamagePoints)
    {

        health -= DamagePoints;
        if (health <= 0 )
        {
            player.GainXP(xpValue);
            Destroy(gameObject);
        }
    }

}
