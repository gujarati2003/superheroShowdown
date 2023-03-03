using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float jump;
    public bool isJumping;

    private Rigidbody2D rb;

    void Start(){
        // setting rb when the game starts
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        // player will move on the horizontal axis
        Move = Input.GetAxis("Horizontal");

        // setting the velocity
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        //when the jump button is pressed the player will jump 
        if(Input.GetButtonDown("Jump") && isJumping == false){
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("Jump");
        }
    }
    // when the ground tag is false the player will not be able to jump agian
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground")){
            isJumping = false;
        }
    }
// when the ground tag is true the player will be able to jump agian
    private void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground")){
            isJumping = true;
        }
    }
    // will destroy game objects with the tag coins when hit
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("coins")){
            Destroy(other.gameObject);
        }
    }
}
