using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2Example : MonoBehaviour
{
	public GameObject aGameObject;
    Rigidbody2D aRigidbody;
    Collider2D aCollider;

	void Awake() {
        aRigidbody = aGameObject.GetComponent<Rigidbody2D>();
        aCollider = GetComponent<Collider2D>();

        aRigidbody = (Rigidbody2D) aGameObject.GetComponent(typeof(Rigidbody2D));
        aCollider = (Collider2D) GetComponent(typeof(Collider2D));
    } 
}