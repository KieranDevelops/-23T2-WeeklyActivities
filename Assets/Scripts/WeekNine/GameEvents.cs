using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents 
{

    public delegate void floatTransformDelegate(float amount, Transform thingHit); // Event data type or rquirements.

    public static floatTransformDelegate DamageEvent; // instance of the event.
    public static floatTransformDelegate HealEvent; 



}
