﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//esse funciona em qualquer lugar
public class rotacao2 : MonoBehaviour
{
    [SerializeField] float velocidaderot = 100f;
    bool dragging = false;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragging = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }
    private void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * velocidaderot * Time.fixedDeltaTime;
            //float y = Input.GetAxis("Mouse Y") * velocidaderot * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            //rb.AddTorque(Vector3.right * y);
        }
    }
}

