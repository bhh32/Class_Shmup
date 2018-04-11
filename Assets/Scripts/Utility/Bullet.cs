using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField] float damageAmt;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player") && gameObject.CompareTag("EnemyBullet"))
            other.gameObject.GetComponent<PlayerHealth>().OnHealthUpdate("damage", damageAmt);
        else if (other.collider.CompareTag("Enemy") && gameObject.CompareTag("Bullet"))
            other.gameObject.GetComponent<EnemyHealth>().OnHealthUpdate(damageAmt);

        Destroy(gameObject);
    }
}
