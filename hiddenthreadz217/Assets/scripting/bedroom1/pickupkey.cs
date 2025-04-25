using UnityEngine;
using UnityEngine.InputSystem;

public class pickupkey : MonoBehaviour
{
    public string targetTag = "Player";
    private bool inTriggerArea = false;
    public GameObject KEY;

    public GameObject doortext1;

    public GameObject LEVELTRIGGERSCENELOAD;
    public GameObject keytext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inTriggerArea && Input.GetKey(KeyCode.P))
        {
            KEY.SetActive(false);
            keytext.SetActive(false);
            LEVELTRIGGERSCENELOAD.SetActive(true);
            doortext1.SetActive(false);

        }

        // if (inTriggerArea && Input.GetKey(KeyCode.X))
        // {
        //     keytext.SetActive(false);
        // }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inTriggerArea = true;
            Debug.Log("enter area");

            keytext.SetActive(true);



        }
    }

    void OnTriggerExit(Collider other)
    {
        inTriggerArea = false;
        Debug.Log("exit area");

        keytext.SetActive(false);




    }
}
