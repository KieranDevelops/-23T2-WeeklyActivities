using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDirectory : MonoBehaviour
{
    public Contact contactOne;
    public Contact contactTwo;
    public Contact contactThree;


    // Start is called before the first frame update
    void Start()
    {
        //call the set up function
        contactOne.Setup();
        contactTwo.Setup();
        contactThree.Setup();
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
