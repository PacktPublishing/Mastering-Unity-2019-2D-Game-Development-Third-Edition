using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour{
    // RigidBody component instance for the character 
    private Rigidbody2D characterRigidBody2D;

    //Variable to track how much movement is needed from input 
    private float moveCharacterHorizontal;
    private float moveCharacterVertical;
    private Vector2 movement;

    // Speed modifier for character movement 
    public float speed = 4.0f;

    // Animator component for the player 
    private Animator characterAnim;

    //Sprite renderer for the player 
    private SpriteRenderer characterSpriteRenderer;

    //Initialize any component references 
    void Awake() {
        characterRigidBody2D = (Rigidbody2D) GetComponent(typeof(Rigidbody2D));
        characterAnim = (Animator)GetComponent(typeof(Animator));
        characterSpriteRenderer = (SpriteRenderer)GetComponent(typeof(SpriteRenderer));
    }

    // Update is called once per frame 
    void Update() {
        moveCharacterHorizontal = Input.GetAxis("Horizontal");
        moveCharacterVertical = Input.GetAxis("Vertical");
        movement = new Vector2(moveCharacterHorizontal, moveCharacterVertical);

        characterRigidBody2D.velocity = movement * speed;


        characterAnim.SetFloat("yMove", moveCharacterVertical);

        if (moveCharacterVertical != 0) {
            characterAnim.SetBool("xMove", false);
            characterSpriteRenderer.flipX = false;
            
        } else {
            if (moveCharacterHorizontal > 0) {
                characterAnim.SetBool("xMove", true);
                characterSpriteRenderer.flipX = false;

            } else if (moveCharacterHorizontal < 0) {
                characterAnim.SetBool("xMove", true);
                characterSpriteRenderer.flipX = true;

            } else {
                characterAnim.SetBool("xMove", false);
            }
        }

        if (moveCharacterVertical == 0 && moveCharacterHorizontal == 0) {
            characterAnim.SetBool("moving", false);

        } else {
            characterAnim.SetBool("moving", true);
        }
    }
}
