using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{

    public float damage;


    protected virtual void OnTriggerEnter(Collider other)
    {
        ApplyDamage(other.gameObject);
    }

    public void ApplyDamage(GameObject g)
    {
        if (g.TryGetComponent(out Damageable damageable))
        {
            damageable.Damage(damage);
        }
    }
}
