using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISlowZone 
{
   float SlowSpeed { get; }

   float SlowTime { get; }

   void ApplySlowMoment(GameObject g);
}
