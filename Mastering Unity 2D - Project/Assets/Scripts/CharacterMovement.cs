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

    //Initialize any component references 
    void Awake() {
        characterRigidBody2D = (Rigidbody2D) GetComponent(typeof(Rigidbody2D));
    }

    // Update is called once per frame 
    void Update() {
        moveCharacterHorizontal = Input.GetAxis("Horizontal");
        moveCharacterVertical = Input.GetAxis("Vertical");
        movement = new Vector2(moveCharacterHorizontal, moveCharacterVertical);

        characterRigidBody2D.velocity = movement * speed;
    }
}
