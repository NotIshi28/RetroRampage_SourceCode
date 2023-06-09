using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleHeal : MonoBehaviour
{
    
    public int heal;
    public PlayerHealth pH;
    public PlayerMovement playerM;
    [SerializeField] private AudioSource collectionSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collectionSoundEffect.Play();
            Heal(heal);
            Destroy(gameObject);

        }
    }

    public void Heal(int heal)
    {
        heal = 4;
        pH.health += heal;
    }

}
