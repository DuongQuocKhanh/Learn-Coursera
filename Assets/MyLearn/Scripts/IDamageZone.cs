using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageZone 
{
    float Damage { get; }

    void ApplyDamage(GameObject g);



}
