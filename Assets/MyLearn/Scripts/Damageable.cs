using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public float health = 100;


    public void Damage(float damage)
    {
        health -= Mathf.Abs(damage);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IDebuffZone dz) )
        {
            Debug.Log(dz.DebuffMessage);
        }

       
    }
}

