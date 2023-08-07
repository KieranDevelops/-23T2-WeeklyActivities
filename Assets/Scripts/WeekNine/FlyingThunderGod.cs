using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingThunderGod : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        // Print out the name of the thinf passing through.

        Debug.Log(other.transform.name);

        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);

        // other.transform.position = new Vector3(x, y, z);
        // transform.position = new Vector3(x, y, z); 
        if (other.transform.GetComponent<Rigidbody>() != null)
        {

            other.transform.GetComponent<Rigidbody>().useGravity = false;
            transform.GetComponent<BoxCollider>().isTrigger = false;

        }

    }
}
