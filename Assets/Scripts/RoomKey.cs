using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomKey : MonoBehaviour
{
    public Inventory inv;
    public GameObject notice;
    public GameObject image;
    //public GameObject timer;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider collision)
    {
        if(collision.GetComponent<Player>())
        {
            notice.SetActive(true);
            if(Input.GetKey(KeyCode.Mouse0))
            {
                inv.Get1();
                Destroy(gameObject);
                notice.SetActive(false);
                image.SetActive(true);
                //timer.SetActive(true);
                anim.SetBool("item1", true);
                
            }
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.GetComponent<Player>())
        {      
            notice.SetActive(false);
        }  
    }
}
