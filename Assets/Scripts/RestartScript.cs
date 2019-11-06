using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

    private Vector2 initialposition;

    private Rigidbody2D rigidbody2d;

    // Use this for initialization
    void Start () {
        initialposition = gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
      
	
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Collector")
        {

            gameObject.transform.position = initialposition;
            rigidbody2d.velocity = Vector2.zero;
            rigidbody2d.angularVelocity = 0;
            gameObject.transform.eulerAngles = Vector3.zero;
        }
    }
}
