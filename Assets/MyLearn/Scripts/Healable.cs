using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healable : Damageable
{
    public void Heal(float heal)
    {
        health += Mathf.Abs(heal);
    }
}
