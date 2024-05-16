using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float mSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement(){
        if(Input.GetKey("w")){
            transform.position = transform.position + transform.forward * mSpeed * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.LeftShift)){
                mSpeed = mSpeed * 2f;
            } 
	    else if(Input.GetKeyUp(KeyCode.LeftShift)){
                mSpeed = mSpeed / 2f;
            }
        } 
        if(Input.GetKey("a")){
            transform.position = transform.position - transform.right * mSpeed * Time.deltaTime;
	}
        if(Input.GetKey("d")){
            transform.position = transform.position + transform.right * mSpeed * Time.deltaTime;
	}
	if (Input.GetKey("s")) {
            transform.position = transform.position - transform.forward * mSpeed * Time.deltaTime;
        }
    }
}
