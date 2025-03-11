using UnityEngine;

public class walltext : MonoBehaviour
{

    public GameObject PressXwall;
    public GameObject Walltext;
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
        if(other.gameObject.CompareTag("player"))
        {
            PressXwall.SetActive(true);
            

        }
    }

    void LateUpdate()
    {
       if(Input.GetKeyUp(KeyCode.X))
            {
            PressXwall.SetActive(false);
            Walltext.SetActive(true);
            }
         if(Input.GetKeyUp(KeyCode.C))
         {
             Walltext.SetActive(false);
         }
        
    }
}
