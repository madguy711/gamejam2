using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f; 
    public float moveTime = 5f; // How long the enemy will move in one direction
    private bool movingRight = false; 
    private float timer = 0f; // The timer for the pause time
    

    
    
    void Update()
    {
        // Move the object to the right or left based on the current direction
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // If the timer is greater than or equal to the pause time, reverse the direction and reset the timer
        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            transform.Rotate(0, 0, 180);
            //movingRight = !movingRight;
            timer = 0f;
        }
    }
}






