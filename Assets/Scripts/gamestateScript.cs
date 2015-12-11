using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class gamestateScript : MonoBehaviour {

    float counter = 0.0f;
    public Text pointsLabel;
	
	// Update is called once per frame
	void Update () {
        counter += 1 * Time.deltaTime;

        pointsLabel.text = "Time: " + (Mathf.Round(counter * 10.0f) / 10.0f)+"s";
	}

    
}
