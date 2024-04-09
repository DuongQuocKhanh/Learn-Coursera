using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour , IDebuffZone , IDamageZone
{
    [SerializeField] protected float _damage =5;
    public float Damage => _damage;
    public string DebuffMessage => "Catching Fire ! Ouch! ";


    protected virtual void OnTriggerEnter(Collider other)
    {
        ApplyDamage(other.gameObject);
    }

    public void ApplyDamage(GameObject g)
    {
        if (g.TryGetComponent(out Damageable damageable))
        {
            damageable.Damage(_damage);
        }
    }




}
