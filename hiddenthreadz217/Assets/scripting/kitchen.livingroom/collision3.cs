using UnityEngine;
using UnityEngine.SceneManagement;

public class collision3 : MonoBehaviour
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
        if(other.gameObject.CompareTag("tobathroom"))
        {
            SceneManager.LoadScene("Main3-bathroom");
        }
    }
}
