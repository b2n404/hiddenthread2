using UnityEngine;
using UnityEngine.SceneManagement;

public class deskclimb : MonoBehaviour
{
    public string targetTag = "Player";


    public GameObject climbdesktext;

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
            SceneManager.LoadScene("Main1-bedroom-desk");
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


        }
    }

    void OnTriggerExit(Collider other)
        {
            inTriggerArea = false;
            Debug.Log("player exited");
            climbdesktext.SetActive(false);
        }





    }
    
