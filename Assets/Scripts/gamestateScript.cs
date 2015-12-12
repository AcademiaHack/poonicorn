using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStateScript : MonoBehaviour {
	
	public float bubbleSpeedChange = 4f;

	public Text pointsLabel;
	public Text pooLabel;

	public float bubbleSpeed = -0.15f;

	public int freePooLimit = 8;
	public int defecateLimit = 3;

	public float bubbleSpawnerInterval = 1f;

	float counter = 0.0f;
	public float time;
	float bubbleCounter = 0.0f;

	Generator generator;

	void Start () {
		generator = GameObject.Find ("EnemySpawner").GetComponent<Generator> ();	
	}

	void Update () {
        counter += 1 * Time.deltaTime;
		time = Mathf.Round (counter * 10.0f) / 10.0f;

        pointsLabel.text = "Time: " + time +"s";

		bubbleCounter += 1 * Time.deltaTime;

		if ((Mathf.Round (bubbleCounter * 10.0f) / 10.0f) == bubbleSpawnerInterval) {
			bubbleCounter = 0f;
			Debug.Log ("SPAWN");
			generator.GenerateBestSmellEver();
		}

		if ((time > bubbleSpeedChange && time % bubbleSpeedChange == 0) || time == bubbleSpeedChange) {
			bubbleSpeed -= 0.01f;		
			if (bubbleSpawnerInterval > 0) bubbleSpawnerInterval -= 0.1f;
		}
	}

	public void changePoo(int poo) {
		pooLabel.text = "Poo: " + poo;

		if (poo >= freePooLimit) {
			pooLabel.color = Color.red;
		} else {
			pooLabel.color = Color.gray;
		}
	}    

	public void saveme () {
		bubbleSpeed += 0.01f;
		changePoo (0);
	}

}
