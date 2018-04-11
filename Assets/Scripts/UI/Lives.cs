using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour 
{
    public delegate void UpdateLives();
    public UpdateLives OnLifeUpdate;

    [SerializeField] int lives;
    [SerializeField] Text lifeText;
    [SerializeField] GameObject gameOverCanvas;
    PlayerHealth playerHealth;

    void Awake()
    {
        gameOverCanvas.SetActive(false);
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        OnLifeUpdate += LivesUpdate;
        lifeText.text = string.Format("Lives: {0}", lives);
    }

    void LivesUpdate()
    {
        lives--;

        if (lives < 0)
            lives = 0;

        lifeText.text = string.Format("Lives: {0}", lives);

        if (lives == 0)
            Die();
    }

    void Die()
    {
        Destroy(playerHealth.gameObject);
        Time.timeScale = 0f;
        gameOverCanvas.SetActive(true);
    }
}
