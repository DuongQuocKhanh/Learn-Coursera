using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDamage : MonoBehaviour , IDebuffZone , IDamageZone ,ISlowZone
{
    [SerializeField] protected float _damage = 2;
    public float Damage => _damage;

    [SerializeField] protected float _slowSpeed = 1;
    public float SlowSpeed => _slowSpeed; 

    [SerializeField] protected float _slowTime = 5;
    public float SlowTime => _slowTime;

    public string DebuffMessage => "Taking Damage amd slowing. Ice ";


    protected void OnTriggerEnter(Collider other)
    {

        ApplyDamage(other.gameObject);
        ApplySlowMoment(other.gameObject);
        
    }
    public void ApplyDamage(GameObject g)
    {
        if (g.TryGetComponent(out Damageable damageable))
        {
            damageable.Damage(_damage);
        }
    }

    public void ApplySlowMoment(GameObject g)
    {
        if (g.TryGetComponent(out Movement movement))
        {
            movement.SetSpeed(_slowSpeed, _slowTime);
        }
    }


}
