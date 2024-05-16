using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController cc;
    public float moveSpeed;
    public float jumpSpeed;
    private float horizontalMove,verticalMove;
    private Vector3 dir;
    public float gravity;
    private Vector3 velocity;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;
    public bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    public void Movement()
    {
        isGround = Physics.CheckSphere(groundCheck.position, checkRadius, groundLayer);
        if (isGround && velocity.y < 0)
        {
            velocity.y = -3f;
        }
        horizontalMove = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis("Vertical") * moveSpeed;
        dir = transform.forward * verticalMove + transform.right * horizontalMove;
        cc.Move(dir * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            velocity.y = jumpSpeed;
        }
        velocity.y -= gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);
    }
}
