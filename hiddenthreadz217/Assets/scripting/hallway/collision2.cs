using UnityEngine;
using UnityEngine.SceneManagement;

public class collision2 : MonoBehaviour
{
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
        if(other.gameObject.CompareTag("tokitchen"))
        {
            SceneManager.LoadScene("Main2-kitchen-livingroom");
        }
    }
}
