using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     public float JumpSpeed;
     public Transform GroundCheck;
     public float CheckRadius;
     public LayerMask whatIsGround;
     
     private Rigidbody2D _rigidbody;

     public bool IsGrounded;

     public int maxJumpValue;
     int maxJump;

    
     private void Start(){
        maxJump = maxJumpValue;
      _rigidbody = GetComponent<Rigidbody2D>();
 }

     private void Update()
     {
         IsGrounded = Physics2D.OverlapCircle(GroundCheck.position,CheckRadius,whatIsGround);

        if(Input.GetMouseButtonDown(0) && maxJump > 0)
        {
            maxJump -- ;
            Jump();
        } 
        else if(Input.GetMouseButtonDown(0) && maxJump == 0 && IsGrounded){
            Jump();
        }
        if(IsGrounded){
            maxJump = maxJumpValue;
        }
    
    }

    public void Jump(){
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(new Vector2(0,JumpSpeed));
    }
}
