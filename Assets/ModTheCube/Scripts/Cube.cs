using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float cubeSpeed = 10.0f;
    public float cubeDimension = 1.3f;

    private float randomRangeMin = 0f;
    private float randomRangeMax = 5f;

    void Start()
    {
        transform.localScale = Vector3.one * cubeDimension;
        InvokeRepeating("ChangeColor", 0f, 1.0f);
        InvokeRepeating("ChangePosition", 0f, 1.0f);

    }
    
    void Update()
    {
        transform.localScale = Vector3.one * cubeDimension;
        transform.Rotate(cubeSpeed * Time.deltaTime, 0.0f, 0.0f);   

        if(Input.GetKey(KeyCode.Space))
        {
            ++cubeSpeed;
        }
        else if(Input.GetKey(KeyCode.R))
        {
            cubeSpeed = 10.0f;
        }
    }

    void ChangeColor()
    {
        //Changing color with random values between 0f and 1.0f
        Renderer.material.color = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 0f, 1f);
    }

    void ChangePosition()
    {
        //Generating a temporal vector 3 position
        Vector3 tempPos = new Vector3(Random.Range(randomRangeMin, randomRangeMax), Random.Range(randomRangeMin, randomRangeMax), Random.Range(randomRangeMin, randomRangeMax));
        //Assigning the temporal vector 3 position to the cube
        gameObject.transform.position = tempPos;
    }

}
