using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrestlers : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public string WrestlingName;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //WeekEight.scorePointsEvent?.Invoke(Random.Range (0, 4));

        WeekEight.scorePointsDelEvent?.Invoke(Random.Range (0, 4));
    } 


}
