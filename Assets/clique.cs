using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clique : MonoBehaviour
{
    public Rigidbody rb;
    private void OnMouseDown()
    {
        Quaternion temp = new Quaternion(0, 0, 0,0);
        rb.transform.rotation = temp;
        Vector3 temp1 = new Vector3(0, 0, 0);
        rb.transform.position = temp1;
        Camera.main.fieldOfView = 60f;

    }
}
