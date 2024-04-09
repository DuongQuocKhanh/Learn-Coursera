using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour, IDebuffZone, ISlowZone
{

    [SerializeField] protected float slowSpeed = 1;
    public float SlowSpeed => slowSpeed;

    [SerializeField] protected float slowTime = 5;
    public float SlowTime => slowTime;

    public string DebuffMessage => "Slow dow form the mud ";
   
    


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
