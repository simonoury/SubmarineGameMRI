using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ : MonoBehaviour{
    [Header("Horizontal Movement")]
    public float moveSpeed = 50f;
    public Vector2 direction;
    public Vector2 gazePoint;
    private bool facingRight = true;


    [Header("Components")]
    public Rigidbody2D rb;
    //public Animator animator;

    [Header("Physics")]
    public float maxSpeed = 15f;
    public float linearDrag = 4f;


    void Update(){
        Vector2 gazePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 gazePoint = Input.mousePosition; //TobiiAPI.GetGazePoint().Screen;
        //this modifies the control from Tobii to mouse postion
        if (gazePoint.y > rb.transform.position.y)
        {
          moveCharacter(1);
        }
        else
        {
          moveCharacter(-1);
        }
        moveCharacter(direction.y);
        modifyPhysics();
    }
    void moveCharacter(float horizontal){
        rb.AddForce(Vector2.up * horizontal * moveSpeed);

        if(Mathf.Abs(rb.velocity.x) > maxSpeed){
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        }
        //animator.SetFloat("horizontal", Mathf.Abs(rb.velocity.x));
    }

    void moveCharactervertical(float vertical){
        rb.AddForce(Vector2.up * vertical * moveSpeed * 10);
    }

    void modifyPhysics(){
        bool changingDirections = (gazePoint.y > 0 && rb.velocity.y < 0) ||  (gazePoint.y < 0 && rb.velocity.y > 0);

        if(Mathf.Abs(direction.y) < 0.4f || changingDirections){
            rb.drag = linearDrag;
        }else{
            rb.drag = 0f;
        }
    }

}
