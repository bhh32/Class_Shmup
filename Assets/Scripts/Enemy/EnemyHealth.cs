using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour 
{
    public delegate void UpdateHealth(float healthChange);
    public UpdateHealth OnHealthUpdate;

    Score scoreManager;
    [SerializeField] float scoreValue;
    [SerializeField] float maxHealth;

    private float health;
    public float Health
    {
        get { return health; }
        set { health = value; }
    }

    void Awake()
    {
        health = maxHealth;
        OnHealthUpdate += HealthUpdate;
    }

    void Start()
    {
        scoreManager = GameObject.FindWithTag("ScoreManager").GetComponent<Score>();
    }

    void HealthUpdate(float healthChange)
    {
        Health -= healthChange;

        if (Health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        scoreManager.OnScoreUpdate(scoreValue);
        Destroy(gameObject);
    }
}
