using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
    public float maxHealth = 10;
    public float health;
    Vector2 startPos;
    SpriteRenderer spriteRenderer;
    public bool isRespawn;
    [SerializeField] private AudioSource deathSoundEffect;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        DieVoid();
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void DieVoid()
    {
        if(gameObject.transform.position.y <= -10)
        {
            deathSoundEffect.Play();
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        health-=damage;

        if(health <= 0)
        {
            deathSoundEffect.Play();
            Die();
        }
    }

    void Die()
    {
        if(isRespawn)
        {
            StartCoroutine(Respawn(.5f));
        }

        else
        {
            SceneManager.LoadScene("YouDied");
        }
    }

      
    IEnumerator Respawn(float duration)
    {
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        health = maxHealth;
        spriteRenderer.enabled = true;
    }


}
