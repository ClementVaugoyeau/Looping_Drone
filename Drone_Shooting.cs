using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Drone_Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource shot; 
    public AudioSource shot2;
    public AudioSource shot3;

    public float bulletForce = 2f;
    public bool soundChange = true;
    public float nextFire = 1;
    public float fireRate = 0f;
       
    
    
    // Update is called once per frame
    
    
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire) 
        {
            nextFire = Time.time + fireRate;

           

            Shoot();
        
        
        }

    }

    public void Shoot()
    {
      GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
      bulletRb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        PlayShootSound();







    }

    public void PlayShootSound()
    {
        int roll = Random.Range(1, 3);

        switch(roll)
        {
            case 1:
                shot.Play();
                break;
            case 2:
                shot2.Play();
                break;
            case 3:
                shot3.Play();
                break;
        }


    }
        

}
