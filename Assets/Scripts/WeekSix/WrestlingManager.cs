using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrestlingManager : MonoBehaviour
{
    /*
     * Create a wrestling manager
    Have a list for first names
    Have a list for last names
    Have a list for wrestling name
    Add 5 names for each of these lists.
    Create a wrestler class, with variables to hold these values for.
    A first name
    A last name
    Wrestling name
    Attach this script to a cube, now create a prefab of your wrestler.
    Spawn in 5 new wrestlers instances in your scene, store references to these in a list in the wrestling manager.
    Using the names in your lists, assign names to each of your new wrestlers.
    Debug out wrestlers names.
    Extra challenge: each name can only be assigned once.

     * 
     */

    public List<string> firstName = new List<string>();
    public List<string> lastName = new List<string>();
    public List<string> wrestlingName = new List<string>();

    public GameObject wrestlerPrefab;

    public List<Wrestlers> allWrestlersList = new List<Wrestlers>();


    // Start is called before the first frame update
    void Start()
    {
        lastName.Add("Show");
        lastName.Add("Lee");
        lastName.Add("Stow");
        lastName.Add("Smith");
        lastName.Add("Hardy");

        wrestlingName = new List<string>() { "BIG Bob", "Cyborg Franky", "Malfuntioner", "JOHN CENA", "To Hard" };

        for (int i = 0; i < 5; i++)
        {
            float x = Random.Range(-10, 10);
            float y = Random.Range(-10, 10);
            float z = Random.Range(-10, 10);
            Vector3 randomPosition = new Vector3(x, y, z);

            GameObject clone = Instantiate(wrestlerPrefab, randomPosition, Quaternion.identity);
            Wrestlers currentWrestler = clone.GetComponent<Wrestlers>();
            allWrestlersList.Add(currentWrestler);
        }

        for(int i=0; i< allWrestlersList.Count; i++)
        {
            allWrestlersList[i].firstName = firstName[Random.Range(0, firstName.Count)];
            allWrestlersList[i].lastName = lastName[Random.Range(0, lastName.Count)];
            allWrestlersList[i].WrestlingName = wrestlingName[Random.Range(0, wrestlingName.Count)];
            Debug.Log(allWrestlersList[i].firstName + " " + allWrestlersList[i].lastName + " " + allWrestlersList[i].WrestlingName);
        }

       // Wrestlers[] allWrestlers = FindObjectsOfType<Wrestlers>();
       // allWrestlersList.AddRange(allWrestlers);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
}
