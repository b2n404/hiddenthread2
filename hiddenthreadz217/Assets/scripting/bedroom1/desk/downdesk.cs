using UnityEngine;
//using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class downdesk : MonoBehaviour
{
    public GameObject climbdowntext;

    public string targetTag = "Player";

    public GameObject Player;
    public Transform player, destinationfloor;

    private bool inTriggerArea = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inTriggerArea && Input.GetKey(KeyCode.O))
        {
            Player.SetActive(false);
            player.position = destinationfloor.position;
            Player.SetActive(true);

            climbdowntext.SetActive(false);
        }

        if (inTriggerArea && Input.GetKey(KeyCode.X))
        {
            climbdowntext.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;
        Debug.Log("player entered");


        if (other.gameObject.CompareTag("Player"))
        {
            climbdowntext.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        Debug.Log("player exited");
        climbdowntext.SetActive(false);
    }




}
