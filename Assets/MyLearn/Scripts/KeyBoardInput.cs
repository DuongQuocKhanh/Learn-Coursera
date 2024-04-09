using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardInput : MonoBehaviour
{
    public Vector3 Movedirection { get; private set; }

    private Camera _camera;

    public static event Action <Vector3> OnMove;

    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
         Movedirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) Movedirection += _camera.transform.forward;
        if (Input.GetKey(KeyCode.S)) Movedirection -= _camera.transform.forward;
        if (Input.GetKey(KeyCode.A)) Movedirection -= _camera.transform.right;
        if (Input.GetKey(KeyCode.D)) Movedirection += _camera.transform.right;

        if (Movedirection != Vector3.zero) OnMove?.Invoke (Movedirection);
    }
}
