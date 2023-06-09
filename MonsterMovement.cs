using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(isChasing)
        {
            
        }

        else
        {
            
            if(Vector2.Distance(transform.position, playerTransform.position) < chaseDistance)
            {
                isChasing = true;
            }
            

            //Making the AI patrol
            if(patrolDestination == 0)
            {
        
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
        
                if(Vector2.Distance(transform.position, patrolPoints[0].position)< 0.5f)
                {
               
                transform.localScale = new Vector3(1,1,1);
                patrolDestination = 1;
                }
            }

            if(patrolDestination == 1)
            {
        
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
        
                if(Vector2.Distance(transform.position, patrolPoints[1].position)< 0.5f)
                {  
                transform.localScale = new Vector3(-1,1,1);
                patrolDestination = 0;
                }
            }
        }
    }
}