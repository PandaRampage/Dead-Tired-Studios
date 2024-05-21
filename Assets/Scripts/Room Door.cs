using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomDoor : MonoBehaviour
{
    public InvMan invMan;
    public Animator anim;
    public GameObject noticeUse;

   private void OnTriggerStay(Collider collision)
    {
        if(collision.GetComponent<Player>() )
        {
            invMan.GetSelItem();          
            if (invMan.item.ToString() == "Rust Key (Items)")
            {
                noticeUse.SetActive(true);
                if(Input.GetKey(KeyCode.Mouse0) )
                {
                    noticeUse.SetActive(false);
                    anim.SetBool("item1", true);
                    invMan.ItemUsed();
                }
            }else{
                noticeUse.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if(collision.GetComponent<Player>())
        {      
            noticeUse.SetActive(false);
        }  
    }
}
