using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{
    [SerializeField] float velocidaderot = 100f;
    bool dragging = false;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnMouseDrag()
    {
        dragging = true;
    }
    private void Update()
    {
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
            float y = Input.GetAxis("Mouse Y") * velocidaderot * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y); 
        }
    }
}

/*public GameObject target;
float minzoom = 35f;
float maxzoom = 100f;
public float sensibilidade = 17f;
public float velocidade = 15;
void Update()
{
    if (Input.GetMouseButton(1))
    {
        transform.RotateAround(target.transform.position, transform.up, Input.GetAxis("Mouse X") * velocidade);
        transform.RotateAround(target.transform.position, transform.right, Input.GetAxis("Mouse Y") * -velocidade);
    }
    //zoom

    float zoom = Camera.main.fieldOfView;
    zoom += Input.GetAxis("Mouse ScrollWheel") * -sensibilidade;
    zoom = Mathf.Clamp(zoom, minzoom, maxzoom);
    Camera.main.fieldOfView = zoom;
}*/