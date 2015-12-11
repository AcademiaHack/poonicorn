using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour {
    System.Random r = new System.Random();

    public GameObject enemy;
    
	GameStateScript state;
    
    public void GenerateBestSmellEver() {
        Instantiate(enemy, new Vector3(this.transform.position.x, this.transform.position.y + (float)rnd(-5.0f, 5.0f), 0), Quaternion.identity);
    }

    double rnd(double a, double b) {
        return a + r.NextDouble() * (b - a);
    }
}
