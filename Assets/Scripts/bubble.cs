using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {
	
	GameStateScript state;
	float speed;

	// Use this for initialization
	void Start () {
		state = GameObject.Find ("GameState").GetComponent<GameStateScript> ();
		speed = state.bubbleSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.x +speed, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.x < -10) {
            Destroy(this.gameObject);
        }
	}
}
