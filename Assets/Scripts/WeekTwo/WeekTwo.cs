using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwo : MonoBehaviour
{

    public string myFaveGame = "Apex Legends";
    public int totalTimePlayed = 152;
    public int costOfGame = 50;

    public int statpool = 20;
    public int strength = 0;
    public int agility = 0;
    public int intelligence = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Add all variables together to make a message
        string myDebugMessage = ("My Favourite game is " + myFaveGame + "I have played it for " + totalTimePlayed + " Hrs " + "it has costed me $" + costOfGame);
        // Debug out myDebugMessage to console

        Debug.Log(myDebugMessage);

        float costPerHour = (float) costOfGame / (float) totalTimePlayed;
        Debug.Log("My cost per hour of playing is $" + costPerHour);



        float myRandoNumber = Random.Range(0f, 10f);
        
        if(myRandoNumber == 1)
        {
            Debug.Log("My number is exactly 1");
        }
        if(myRandoNumber < 3)
        {
            Debug.Log("My Number is less than 3");
        }
        if(myRandoNumber > 3 && myRandoNumber < 5)
        {
            Debug.Log("My Number is 4");
        }
        if(myRandoNumber > 5)
        {
            Debug.Log("My Number is greater than 5");
        }

        Debug.Log("The percent chance of getting these numbers is: " + (myRandoNumber / 10f)  * 100 + "%");

        // activity 3
        int statpool = 20;
        

    }

    // Update is called once per frame
    void Update()
    {

        // highlight control K C to comment whole text
        // hgihlight control K U to uncomment whole text

        // Allocating a key to agility
        if(Input.GetKeyDown(KeyCode.A))
        {
            agility = Random.Range(0, statpool);
            statpool -= agility;
        }
        // Allocating a key to intelligence
        if (Input.GetKeyDown(KeyCode.I)) 
        {
            intelligence = Random.Range(0, statpool);
            statpool -= intelligence;
        }

        // Allocating a key to strength
        if (Input.GetKeyDown(KeyCode.S))
        {
            strength = Random.Range(0, statpool + 1);
            statpool -= strength;
        }
        

        Debug.Log("S = " + strength + "A = " + agility + "I = " + intelligence);
    }
}
