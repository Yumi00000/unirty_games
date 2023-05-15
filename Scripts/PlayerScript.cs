using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 20.5f;
    private float minX = -1.82f;
    private float maxX = 1.82f;
    
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;
        if (h > 0)
        {
            // moving to the rigth side
            currentPosition.x += speed * Time.deltaTime;
        }
        else if (h < 0)
        {
            // moving to the left left
            currentPosition.x -= speed * Time.deltaTime;
        }
        
        if (currentPosition.x > maxX)
        {

            currentPosition.x = maxX;
        }
        if (currentPosition.x < minX)
        {
            
            currentPosition.x = minX;
        }
        transform.position = currentPosition;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Time.timeScale = 0f;
        }
    }
}
