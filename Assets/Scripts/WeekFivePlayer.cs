using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFivePlayer : MonoBehaviour
{
    public GameObject cubeObject;

    private WeekFiveHealth myHealth;
    public BoxCollider boxCollider;

    public enum CharacterTypes {Warrior,Mage,Paladin}

    public CharacterTypes myCharacterType;

    // Start is called before the first frame update
    void Start()
    {

        //myHealth = transform.GetComponent<WeekFiveHealth>();
        //myHealth = FindObjectOfType<WeekFiveHealth>();
        myHealth = cubeObject.GetComponent<WeekFiveHealth>();

        boxCollider = cubeObject.GetComponent<BoxCollider>();


        // deal 20 damage to myself
        /*if (myHealth != null)
        {
            if (myCharacterType == CharacterTypes.Mage)
                myHealth.health = myHealth.health - 20;
        }
        if (myCharacterType == CharacterTypes.Warrior)
        { 
            myHealth.health = myHealth.health + 20;
        }
        if (myCharacterType == CharacterTypes.Paladin)
        {
            myHealth.health += 10;
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
