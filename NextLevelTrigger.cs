using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevelTrigger : MonoBehaviour
{

    public int sceneBuildIndex;
    [SerializeField] private AudioSource finishSoundEffect;

    private void OnTriggerEnter2D(Collider2D other){
        print("Trigger Entered");

        if(other.tag == "Player"){
            finishSoundEffect.Play();
            DontDestroyOnLoad(transform.gameObject);
            print("Switching scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
