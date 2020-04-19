using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene : MonoBehaviour
{
    public string piso;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("PIso");
        UnityEngine.SceneManagement.SceneManager.LoadScene(piso);
    }

}
