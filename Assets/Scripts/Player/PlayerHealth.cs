using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour 
{
    public delegate void UpdateHealth(string healthUpdateType, float healthChange);
    public UpdateHealth OnHealthUpdate;

    Lives lifeManager;

    [SerializeField] float maxHealth;
    public float MaxHealth
    {
        set { maxHealth = value; }
    }
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
        lifeManager = GameObject.Find("LifeManager").GetComponent<Lives>();
    }

    void HealthUpdate(string healthUpdateType, float healthChange)
    {
        switch (healthUpdateType)
        {
            case "damage":
                Health -= healthChange;

                if (Health <= 0)
                {
                    lifeManager.OnLifeUpdate();
                    Health = maxHealth;
                }
                break;
            case "heal":
                Health += healthChange;
                break;
            default:
                break;
        }
    }
}
