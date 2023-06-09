using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterStomp : MonoBehaviour
{

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
        if(collision.gameObject.tag == "Weak Point")
        {
            Destroy(collision.gameObject);

            if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("BOSS")) 
            {
                SceneManager.LoadScene(8);
            }

            else
            {

            }

        }
    }
}

