using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10.0F;
	public int poo = 0;
		
	void Start () {
	
	}

	void OnTriggerEnter2D (Collider2D collision) {
		if (collision.gameObject.tag.Equals("Bubble")) {
			Destroy(collision.gameObject);
			poo++;
		}
	}
	
	void Update () {
		
		float translationY = Input.GetAxis("Vertical") * speed;
		float translationX = Input.GetAxis("Horizontal") * speed;
		translationY *= Time.deltaTime;
		translationX *= Time.deltaTime;
		transform.Translate(translationX, translationY, 0);

	}
}
