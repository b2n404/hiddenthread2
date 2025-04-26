using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class descendcounter : MonoBehaviour
{

    public string targetTag = "Player";

    public GameObject Player;
    public GameObject descendcountertext;
    public Transform player, livingroomfloor;
    public GameObject countertoptarget;


    private bool inTriggerArea = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inTriggerArea && Input.GetKey(KeyCode.V))
        {
            Player.SetActive(false);
            player.position = livingroomfloor.position;
            Player.SetActive(true);

            descendcountertext.SetActive(false);
            countertoptarget.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        Debug.Log("player entered");

        if (other.gameObject.CompareTag("Player"))
        {
            descendcountertext.SetActive(true); 
            countertoptarget.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        Debug.Log("player exited");

        descendcountertext.SetActive(false);
    }
}
