using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField] float damageAmt;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
            other.gameObject.GetComponent<PlayerHealth>().OnHealthUpdate("damage", damageAmt);
        else if (other.collider.CompareTag("Enemy"))
            other.gameObject.GetComponent<EnemyHealth>().OnHealthUpdate(damageAmt);

        Destroy(gameObject);
    }
}
