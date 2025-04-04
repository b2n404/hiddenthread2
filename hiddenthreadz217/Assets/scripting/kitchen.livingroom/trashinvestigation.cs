using System;
using UnityEngine;

public class trashinvestigation : MonoBehaviour
{

    private bool bytrashcan = false;

    public GameObject trashtext;

    public string targetTag = "Player";

    //Renderer m_Renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (m_Renderer.isVisible)
        // {
        //     Debug.Log("I SEE YOU");
        // }
        // else Debug.Log("you left great");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        
        {
            bytrashcan = true;
            Debug.Log("playerbyTRASH");

            trashtext.SetActive(true);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        bytrashcan = false;
        Debug.Log("playerlefttrash");

        trashtext.SetActive(false);
    }
}
