using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100;


    private void OnEnable()
    {
        GameEvents.DamageEvent += DealDamage;
    }

    private void OnDisable()
    {
        GameEvents.DamageEvent -= DealDamage;
    }

    public void DealDamage (float amount, Transform playerHit)
    {

        Debug.Log("hello");

        if (playerHit == transform)
        {
            
            health += amount;
            if (health <= 0)
            {
                // We are dead
                Destroy(gameObject);
                Debug.Log("You died");
            }
        }

    }
}
