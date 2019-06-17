using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour{
    // Distance between protagonist and camera in horizontal direction 
    public float xOffset = 0f;
    // Distance between protagonist and camera in vertical direction 
    public float yOffset = 0f;

    // Reference to the protagonist's transform. 
    public Transform protagonist;

    void LateUpdate() {
        this.transform.position = new Vector3(protagonist.transform.position.x +
          xOffset, this.transform.position.y + yOffset, -10);
    }
}
