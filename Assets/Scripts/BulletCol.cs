using UnityEngine;
using System.Collections;

public class BulletCol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       // Destroy(gameObject, 2);
	}
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        if(col.gameObject.tag == "Zombie")
        {
            //  gameObject.transform.parent = null;
            Debug.Log("You hit " + col.gameObject.name);
        }
        //  Destroy(col.gameObject);
        //  print(col.gameObject);

    }
}
