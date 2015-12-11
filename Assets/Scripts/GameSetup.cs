using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	
	public Camera mainCamera;
	
	public BoxCollider2D top;
	public BoxCollider2D bottom;
	public BoxCollider2D left;
	public BoxCollider2D right;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		/*top.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width*2f, 0f, 0f)).x, 1f);
		top.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
		
		bottom.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width*2f, 0f, 0f)).x, 1f);
		bottom.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
		
		left.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
		left.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
		
		right.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y);
		right.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);*/
	}
}
