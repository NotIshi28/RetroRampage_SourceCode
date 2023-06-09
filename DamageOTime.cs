using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOTime : MonoBehaviour
{
    public PlayerHealth pH;
    public float damageAmount;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DamageOverTime(damageAmount);
    }

    public void DamageOverTime(float damageAmount)
    {
        pH.health -= damageAmount;
    }
}
