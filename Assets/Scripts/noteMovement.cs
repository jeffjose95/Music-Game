using UnityEngine;
using System.Collections;

public class noteMovement : MonoBehaviour {
    public float moveSpeed;
    public int speedMultiplier;

    private Vector2 movement;
	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
        speedMultiplier = 1;
        movement = new Vector2(0, -moveSpeed);
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
