using UnityEngine;
using System.Collections;
using Pathfinding;
public class Enemy : MonoBehaviour {
    public int hp;
    public int starthp = 100;
    public Animator myAnim;
    public bool Dead;
    public GameObject Player;
    public Transform spawnPrefab;
    public GameObject zombiePrefab;
    public float amountOfLengths = 4f;
    // Use this for initialization

    void Start()
    {

        hp = starthp;

    }

    // Update is called once per frame
    void Update () {
        if (hp <= 0)
        {
            GetComponent<NavMeshAgent>().Stop();
            myAnim.SetBool("isDead",true);
            // Destroy(gameObject);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        else
        {
            this.GetComponent<NavMeshAgent>().destination = Player.transform.position;

        }
    }
  
   void TakeDamage(int taken)
    {
        //Instantiate(zombiePrefab, new Vector3(spawnPrefab.position.x,120,spawnPrefab.position.z), spawnPrefab.rotation);

        hp -= taken;
       
    }
    




}
