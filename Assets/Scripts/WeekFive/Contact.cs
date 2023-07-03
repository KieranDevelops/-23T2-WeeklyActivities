using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
    public string firstName;
    public string emailAddress;
    public string number;
    public string preferredName;



    // Start is called before the first frame update
    void Start()
    {
       // Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Setup()
    {
        int randomNum = Random.Range(0, 3);

        if(randomNum == 0)
        {
            firstName = "Kieran";
            number = "04321";
            emailAddress = "ME@Me.cool";
            preferredName = "Kez";
        }
        else if(randomNum == 1)
        {
            firstName = "George";
            number = "18009287";
            emailAddress = "Georgiscool.com";
            preferredName = "Jungle boy";
        }
        else if (randomNum == 2)
        {
            firstName = "Mr. Nobody";
            number = "000";
            emailAddress = "NoOneWasHere@ghost.com";
            preferredName = "Ghost";
        }

    }

}
