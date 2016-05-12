using UnityEngine;
using System.Collections;

public class SniperZoom : MonoBehaviour {
    public GameObject scope;
    public GameObject sniper;
    public GameObject body;
    public GameObject cHair;
    public GameObject flash;
    public int fov = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (WeaponManager.weaponSelected == 2)
        {
            if (Input.GetButtonDown("Q"))
            {
                fov++;
                if(fov == 4)
                {
                    fov = 1;
                }
            }
            if (Input.GetButton("Fire2"))
            {
                if (fov == 3)
                {
                    Camera.main.fieldOfView = 5;
                }
                if (fov == 2)
                {
                    Camera.main.fieldOfView = 10;
                }
                if (fov == 1)
                {
                    Camera.main.fieldOfView = 20;
                }
                sniper.SetActive(false);
                scope.SetActive(true);
                cHair.SetActive(false);
                body.SetActive(false);
                flash.SetActive(false);
            }
            else
            {
                Camera.main.fieldOfView = 60;
                sniper.SetActive(true);
                cHair.SetActive(true);
                scope.SetActive(false);
                body.SetActive(true);
                flash.SetActive(true);
            }
        }
	}
}
