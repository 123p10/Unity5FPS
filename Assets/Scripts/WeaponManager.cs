using UnityEngine;
using System.Collections;

public class WeaponManager : MonoBehaviour {
    public static int weaponSelected = 1;
    public GameObject m4a1;
   public GameObject sniper;
    public GameObject muzzleFlash;
	// Use this for initialization
	void Start () {
        weaponSelected = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("1"))
        {
            weaponSelected = 1;
           // m4a1 = GameObject.Find("M4A1");
            m4a1.gameObject.SetActive(true);
            sniper.gameObject.SetActive(false);
            muzzleFlash.gameObject.SetActive(false);

        }
        if (Input.GetButtonDown("2"))
        {
            weaponSelected = 2;
         //   sniper = GameObject.Find("AWP");
            sniper.gameObject.SetActive(true);
            m4a1.gameObject.SetActive(false);
            muzzleFlash.gameObject.SetActive(true);
        }
    }
}
