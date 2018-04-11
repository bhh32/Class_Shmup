using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour 
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject gunPos;
    [SerializeField] float fireRate = 0f;
    [SerializeField] float startFireRate = 4f;
    [SerializeField] float bulletSpeed;

    void Update()
    {
        fireRate -= Time.deltaTime;

        if (fireRate <= 0f)
        {
            Shoot();
            fireRate = startFireRate;
        }
    }

    void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, gunPos.transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -bulletSpeed * Time.deltaTime), ForceMode2D.Impulse);
    }
}
