
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public int ammo1;
    public int ammo2;
    public int ammoStart = 10;
    public Rigidbody projectile;
    Rigidbody instantiatedProjectile;
    public float speed = 20;
    public string ammoString;
    public GameObject muzzleFlash;
    public bool canShoot;
    public float delay;
    public float counter;
    public int kills;
    string killsstring;
    //public GameObject chair;



    // Use this for initialization
    void Start()
    {
        ammo1 = ammoStart;
        ammo2 = ammoStart;
        muzzleFlash.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        killsstring = ("Kills" + kills);

        counter += 1f;

        if (Input.GetButton("Fire1"))
        {

            //m4a1
            if (WeaponManager.weaponSelected == 1)
            {
                delay = 20f;
                if (counter > delay) {
                    if (ammo1 > 0)
                    {
                        counter = 0f;

                        StartCoroutine(muzzleFlasher());

                        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                        RaycastHit hit;
                        ammo1 -= 1;
                        if (Physics.Raycast(ray, out hit))
                        {

                            Vector3 hitPoint = hit.point;

                            Debug.DrawLine(transform.position, hit.point, Color.green, 99);

                            canShoot = false;

                            hit.transform.SendMessage("TakeDamage", 25);
                        }

                    }
                }
            }
        }





        //Awp
        if (WeaponManager.weaponSelected == 2)
        {
            canShoot = true;
            delay = 125f;
            if (Input.GetButton("Fire1"))
            {
               
                if (delay < counter)
                {

                    if (ammo2 > 0)
                    {


                        StartCoroutine(muzzleFlasher());
                        counter = 0f;

                        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                        RaycastHit hit;
                        ammo2 -= 1;
                        canShoot = false;
                        if (Physics.Raycast(ray, out hit))
                        {

                            Vector3 hitPoint = hit.point;

                            Debug.DrawLine(transform.position, hit.point, Color.green, 99);



                            hit.transform.SendMessage("TakeDamage", 100);
                        }

                    }
                }
            }
        }

        if (Input.GetButtonDown("Reload"))
        {
            if (WeaponManager.weaponSelected == 1)
            {
                ammo1 = ammoStart;
            }
            if (WeaponManager.weaponSelected == 2)
            {
                ammo2 = ammoStart;
            }
        }
    }







     

    






    void OnGUI()
    {
        if(WeaponManager.weaponSelected == 1)
        {
            ammoString = ("Ammo: " + ammo1);

        }

        if(WeaponManager.weaponSelected == 2)
        {
            ammoString = ("Ammo: " + ammo2);

        }
        ammoString = GUI.TextField(new Rect(10, 10, 200, 20), ammoString, 25);
        GUI.TextField(new Rect(10, 40, 200, 20),killsstring,25);
    }



IEnumerator muzzleFlasher() {
    muzzleFlash.GetComponent<Renderer>().enabled = true;
    yield return new WaitForSeconds(0.05f);
    muzzleFlash.GetComponent<Renderer>().enabled = false;

}
}
