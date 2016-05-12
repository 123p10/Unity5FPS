using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    public GameObject zombiePrefab;
    public Transform spawnPrefab;
    public GameObject[] zombieArray;
    public GameObject[] numZombie;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        numZombie = GameObject.FindGameObjectsWithTag("Zombie");
        if(numZombie.Length < 1)
        {
            Instantiate(zombiePrefab, new Vector3(spawnPrefab.position.x, 120, spawnPrefab.position.z), spawnPrefab.rotation);

        }
        // Instantiate(zombiePrefab, new Vector3(spawnPrefab.position.x, 120, spawnPrefab.position.z), spawnPrefab.rotation);

    }
}
