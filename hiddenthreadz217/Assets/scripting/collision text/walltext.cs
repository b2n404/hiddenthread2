using UnityEngine;

public class walltext : MonoBehaviour
{

    //public GameObject PressXwall;
    public GameObject Walltext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Walltext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            //PressXwall.SetActive(true);
            Walltext.SetActive(true);
            

        }
    }

    void LateUpdate()
    {
       if(Input.GetKeyUp(KeyCode.X))
            {
            //ressXwall.SetActive(false);
            Walltext.SetActive(false);
            }
        //  if(Input.GetKeyUp(KeyCode.C))
        //  {
        //      Walltext.SetActive(false);
        //  }
        
    }
}
