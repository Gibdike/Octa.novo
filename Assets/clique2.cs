using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clique2 : MonoBehaviour
{
    public Rigidbody camera;
    public Vector3 temp1 = new Vector3(2, 17, -2);
    public Quaternion temp = new Quaternion(0, 0, 0,0);
    private void OnMouseDown()
    {
        camera.transform.rotation = temp;
        camera.transform.position = temp1;
        Camera.main.fieldOfView = 60f;
        camera.AddTorque(Vector3.down * 180f);

    }
}
