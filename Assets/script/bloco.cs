using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloco : MonoBehaviour
{
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject geral;
    public GameObject geral0;
    public GameObject blococ;
    public GameObject sumiu;
    public string ponto;
    // Update is called once per frame
    private void OnMouseDown()
    {
        Debug.Log("clique");
        Camera.main.fieldOfView = 60f;
        GameObject.FindGameObjectWithTag("MainCamera").transform.position = GameObject.FindGameObjectWithTag(ponto).transform.position;
        GameObject.FindGameObjectWithTag("MainCamera").transform.rotation = GameObject.FindGameObjectWithTag(ponto).transform.rotation;
        geral.transform.position = geral0.transform.position;
        geral.transform.rotation = geral0.transform.rotation;
        sumiu.SetActive(false);
        texto1.SetActive(true);
        texto2.SetActive(true);
        texto3.SetActive(true);
        blococ.GetComponent<Collider>().enabled = false;
    }    
}
