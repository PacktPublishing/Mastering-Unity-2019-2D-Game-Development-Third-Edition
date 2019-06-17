using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorting : MonoBehaviour{
    Transform theObject;
	SpriteRenderer theObjectSpriteRenderer;

    Transform protagonist;
    SpriteRenderer protagSpriteRenderer;

    void Awake(){
        theObject = GetComponent<Transform>();
		theObjectSpriteRenderer = GetComponent<SpriteRenderer>();
		protagonist = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        protagSpriteRenderer = protagonist.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update() {
        if (theObject.position.y >= protagonist.position.y) {
			theObjectSpriteRenderer.sortingOrder = (protagSpriteRenderer.sortingOrder) - 1;

        }
        if (theObject.position.y < protagonist.position.y) {
			theObjectSpriteRenderer.sortingOrder = (protagSpriteRenderer.sortingOrder) + 1;
        }
    }
}
