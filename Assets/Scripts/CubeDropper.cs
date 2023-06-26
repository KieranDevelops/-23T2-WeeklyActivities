using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeDropper : MonoBehaviour
{
    public Rigidbody myRigidBody;
    private Vector3 startingPosition;
    public Button buttonPress;

    // Start is called before the first frame update
    void Start()
    {

        // search the object this sript is attacked to for this rigidbody
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.mass = 50;
        startingPosition = transform.position;
        // buttonPress.onClick.AddListener(ResetCube);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ResetCube();
        }


    }

    public void ResetCube()
    {
        Debug.Log("Cube reset");
        transform.position = startingPosition;
        myRigidBody.velocity = new Vector3(0, 0, 0);
        myRigidBody.angularVelocity = Vector3.zero;
    }
}
