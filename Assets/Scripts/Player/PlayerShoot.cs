using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float fireRate;
    [SerializeField] float bulletSpeed;
    [SerializeField] float gunOffset;
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            InvokeRepeating("Shoot", 0f, fireRate);
        }
	}

    void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, Vector3.up * gunOffset, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, bulletSpeed * Time.deltaTime), ForceMode2D.Impulse);
    }
}
