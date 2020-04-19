using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    float minzoom = 35f;
    float maxzoom = 100f;
    public float sensibilidade = 17f;
    void Update()
    {
        float zoom = Camera.main.fieldOfView;
        zoom += Input.GetAxis("Mouse ScrollWheel") * -sensibilidade;
        zoom = Mathf.Clamp(zoom, minzoom, maxzoom);
        Camera.main.fieldOfView = zoom;
    }
}
