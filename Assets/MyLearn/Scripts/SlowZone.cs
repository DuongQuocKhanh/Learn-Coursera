using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowZone : MonoBehaviour
{
    public float slowSpeed = 1;
    public float slowTime = 5;


    protected virtual void OnTriggerEnter(Collider other)
    {

        ApplySlowMoment(other.gameObject);
    }

    public void ApplySlowMoment(GameObject g)
    {
        if (g.TryGetComponent(out Movement movement))
        {
            movement.SetSpeed(slowSpeed, slowTime);
        }
    }

}
