using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomKey : MonoBehaviour
{
    public Inventory inv;
    public GameObject notice;
    //public GameObject image;
    //public GameObject timer;
    //public Animator anim;
    public InvMan invMan;
    public Items i2p;
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
            if(Input.GetKey(KeyCode.Mouse0) )
            {

                notice.SetActive(false);
                //anim.SetBool("item1", true);
                Destroy(gameObject);
                
                if (inv.item1 == false)
                {
                    invMan.AddItems(i2p);
                    inv.Get1();
                }
                
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
