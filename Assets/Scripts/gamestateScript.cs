using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStateScript : MonoBehaviour {
	
	
	public Text pointsLabel;
	public Text pooLabel;

	public int freePooLimit = 8;
	public int defecateLimit = 3;

	public float bubbleSpeed = -0.2f; //-0.15f;
	public float bubbleSpawnerInterval = 1f;

	float counter = 0.0f;
	float time;

	float bubbleSpeedChange = 8f;
	int lastBubbleSpeedChange = 0;
	
	Generator generator;

	void Start () {
		generator = GameObject.Find ("EnemySpawner").GetComponent<Generator> ();	
		generator.ProgrameSpawner(bubbleSpawnerInterval);
	}

	void Update () {
        counter += 1 * Time.deltaTime;
		time = Mathf.Round (counter * 10.0f) / 10.0f;

        pointsLabel.text = "Time: " + time +"s";

        Debug.Log(((int)time) + " -- " + bubbleSpeedChange);
    	if ( lastBubbleSpeedChange != (int)time && ( 
			((int)time > bubbleSpeedChange && (int)time % bubbleSpeedChange == 0) || 
			(int)time == bubbleSpeedChange)
		) {
    		lastBubbleSpeedChange = (int)time;
			Debug.Log("Multiplo");
			bubbleSpeed -= 0.004f;		
			if (bubbleSpawnerInterval > 0.01f) {
				bubbleSpawnerInterval -= 0.04f;
			} else {
				bubbleSpawnerInterval = 0.01f;
			}
			Debug.Log(bubbleSpawnerInterval);
			generator.ProgrameSpawner(bubbleSpawnerInterval);
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
