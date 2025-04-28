using UnityEngine;
//using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class deskclimb : MonoBehaviour
{
    public string targetTag = "Player";
    public GameObject Player;
    public Transform player, destination;

    public GameObject climbdesktext;

    private bool inTriggerArea = false;

    //public GameObject deskcollider;
    public GameObject topdesktrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inTriggerArea && Input.GetKey(KeyCode.C))
        {
            Player.SetActive(false);
            player.position = destination.position;
            Player.SetActive(true);

            climbdesktext.SetActive(false);

        }

        if (inTriggerArea && Input.GetKey(KeyCode.X))
        {
            climbdesktext.SetActive(false);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        inTriggerArea = true;

        Debug.Log("player entered area");


        if (other.gameObject.CompareTag("Player"))
        {
            climbdesktext.SetActive(true);

            // if (Input.GetKeyDown(KeyCode.C))
            // {
            //     Player.SetActive(false);
            //     player.position = destination.position;
            //     Player.SetActive(true);

            //     climbdesktext.SetActive(false);

            // }


        }
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        Debug.Log("player exited");
        climbdesktext.SetActive(false);
        //deskcollider.SetActive(false);
        topdesktrigger.SetActive(false);
        
    }





}