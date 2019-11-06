using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("platform hit the wall");
        Destroy(other.gameObject);
    }
}
