using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private float maxX = 2.55f;
    private float minX = -2.55f;
   

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 temp = transform.position;
        if(h > 0)
        {
            temp.x += speed * Time.deltaTime;
        }
        else if(h < 0)
        {
            temp.x -= speed * Time.deltaTime;
        }

        if(temp.x < minX) temp.x = minX;      
        if (temp.x > maxX) temp.x = maxX;
        
        transform.position = temp;
    }



















}//class






















