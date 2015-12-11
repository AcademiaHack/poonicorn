using UnityEngine;
using System.Collections;

public class bubble : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.x +speed, this.transform.position.y, this.transform.position.z);

        if (this.transform.position.x < -10) {
            Destroy(this.gameObject);
        }
	}
}
