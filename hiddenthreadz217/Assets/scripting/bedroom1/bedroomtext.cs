using UnityEngine;

public class bedroomtext : MonoBehaviour
{
    public string targetTag = "Player";
    public GameObject Player;


    private bool byboxArea = false;

    public GameObject text;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
        byboxArea = true;
        text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
        byboxArea = false;
        text.SetActive(false);
        }
        
    }
}
