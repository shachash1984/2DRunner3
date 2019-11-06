using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

    public float minSpawnTime = 2f;
    public float maxSpawnTime = 4f;


	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn());
	}

    // Update is called once per frame
    void Update() { }
	IEnumerator Spawn ()
        {
            while (true) //get random interval
            {
            float intervalTime = Random.Range(minSpawnTime, maxSpawnTime);

            yield return new WaitForSeconds(intervalTime);

            int platformIndex = Random.Range(1, 4);

            Instantiate(Resources.Load("Platform" + platformIndex), gameObject.transform.position, Quaternion.identity);
            }

        }
	
}
