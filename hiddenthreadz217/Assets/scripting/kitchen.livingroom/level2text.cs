using UnityEngine;

public class level2text : MonoBehaviour
{
    public string targetTag = "Player";
    public GameObject Player;


    private bool hitextrigger = false;

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
        hitextrigger = true;
        text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
        hitextrigger = false;
        text.SetActive(false);
        }
        
    }
}
