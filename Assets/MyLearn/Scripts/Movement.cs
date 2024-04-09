using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public float originalSpeed = 5;



    private void OnEnable()
    {
        KeyBoardInput.OnMove += HadleMovement;
    }

     private void OnDisable()
    {
        KeyBoardInput.OnMove -= HadleMovement;
    }
    void HadleMovement(Vector3 MoveDirection)
    {

      
        Vector3 direction = MoveDirection;
        if (direction != Vector3.zero)
        {
            direction.y = 0;
            direction.Normalize();

            transform.position += direction * speed * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }

    public void SetSpeed(float newSpeed , float time)
    {
        if(speed != newSpeed)
        {
            speed = newSpeed;
            Invoke(nameof(ResetSpeed), time);
        }
        
    }

    private void ResetSpeed()
    {
        speed = originalSpeed;
    }

   
}
