using System;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorleveltrigger : MonoBehaviour
{
    //public GameObject closedoortext;
    public GameObject opendoortext;

    private bool inTriggerArea = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inTriggerArea && Input.GetKey(KeyCode.X))
        {
            opendoortext.SetActive(false);
            SceneManager.LoadScene("Hallway");
        }


    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        if (other.gameObject.CompareTag("Player"))
        {
            opendoortext.SetActive(true);
        }
        Debug.Log("Player here");
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        opendoortext.SetActive(false);
        Debug.Log("player gone");
    }
}
