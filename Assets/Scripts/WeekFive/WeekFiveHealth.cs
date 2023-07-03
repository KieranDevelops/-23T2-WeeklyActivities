using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;
using UnityEngine;

public class WeekFiveHealth : MonoBehaviour
{

    private float health = 100;
    private bool isDead = false;


    public float MyHealth
    {
        get
        {
            Debug.Log(health);
            return health;
        }
        set
        {
            if (value > 0)
            {
                // play heal effect
            }
            else
            {
                //make noise
                //blood splater
            }
            Debug.Log(health);
            health = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        MyHealth += 20;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
