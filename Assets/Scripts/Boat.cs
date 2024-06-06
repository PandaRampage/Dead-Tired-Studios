using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boat : MonoBehaviour
{
    public Inventory inv;
    public GameObject noticeEs;
    public GameObject partiBoat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inv.item2 == true)
        {
            partiBoat.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider collision)
    {
        if(collision.GetComponent<Player>() && inv.item2 == true)
        {
            noticeEs.SetActive(true);
            if(Input.GetKey(KeyCode.Mouse0))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Ending");
            }
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.GetComponent<Player>())
        {      
            noticeEs.SetActive(false);
        }  
    }
}
