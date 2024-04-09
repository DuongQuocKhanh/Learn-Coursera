using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyHeal : MonoBehaviour
{
    public float healPerSecond = 5;

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent (out Healable healable))
        {
            healable.Heal(healPerSecond * Time.deltaTime);
        }
    }

}
