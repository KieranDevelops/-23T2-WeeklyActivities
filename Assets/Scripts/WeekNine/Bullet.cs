using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.transform.GetComponent<Health>())
        //{
        //    collision.transform.GetComponent<Health>().DealDamage(-25);
        //}
        GameEvents.DamageEvent?.Invoke(-25, collision.transform);

        transform.position = collision.transform.position + new Vector3(0, 15, 0);
    }


}
