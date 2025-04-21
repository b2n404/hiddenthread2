using UnityEngine;
using UnityEngine.SceneManagement;

public class downdesk : MonoBehaviour
{
    public GameObject climbdowntext;

    public string targetTag = "Player";

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
            SceneManager.LoadScene("Main1-bedroom-down");
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
