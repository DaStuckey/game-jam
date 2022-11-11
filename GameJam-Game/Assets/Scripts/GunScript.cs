using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class GunScript : MonoBehaviour
{
    bool ray = false;
    public GameObject bullet;
    public GameObject gun;

    //Try to make private later if possible
    public float gunForce;
    public float recoil; //Might not need

    public float shootingCoolDown, spread, reload, shotCoolDown;
    public int magSize, shootSize;
    public bool canSpray;
    private int bulletsRemaining, bulletsFired;

    bool shooting, canShoot, reloading;

    public Camera Cam;
    public Transform attackPoint, targetPoint;

    public bool allowInvoke;
         
    void Start()
    {
        bulletsRemaining = magSize;
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
    }
    private void MyInput()
    {
        if (canSpray) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        if (canShoot && shooting && !reloading && bulletsRemaining > 0)
        {
            bulletsFired = 0;

            Shoot();
        }
    }
    private void Shoot()
    {
        canShoot = false;


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f))
        {
            ray = true;
            
        }
        RaycastHit hit;

        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;
        }
        else targetPoint = ray.GetPoint(75);

        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        Vector3 directionWithSpread = directionWithoutSpread + new Vector3(x, y, 0);

        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);
        currentBullet.transform.forward = directionWithSpread.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * gunForce, ForceMode.Impulse);


        bulletsRemaining--;
        bulletsFired++;

        if (allowInvoke)
        {
            Invoke("ResetShot", shootingCoolDown);
                allowInvoke = false;
        }

        if (bulletsFired < shootSize && bulletsRemaining > 0) Invoke("Shoot", shootingCoolDown);
    }
}
*/