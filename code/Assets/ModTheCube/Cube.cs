using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    public float speed;
    public float newColorTime = 1f;
    public float passedTime;
    void Start()
    { 
        speed = Random.Range(-200f, 200f);
        transform.position = new Vector3(Random.Range(-5f,15f), 0, Random.Range(-5f,15f));
        transform.localScale = Vector3.one * Random.Range(0,20);
        
        Material material = Renderer.material;
    
        material.color = new Color
        (
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f)
        );

       
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("ResetOrExit");
        }

        passedTime += Time.deltaTime;
        

        transform.Rotate(speed * Time.deltaTime, 0.0f, 0.0f);

        if (passedTime >= newColorTime)
        {   
            speed = Random.Range(-200f, 200f);
            transform.position = new Vector3(Random.Range(-5f,15f), 0, Random.Range(-5f,15f));
            transform.localScale = Vector3.one * Random.Range(0,20);
            
            Material material = Renderer.material;
            material.color = new Color
            (
                    Random.Range(0f, 1f), 
                    Random.Range(0f, 1f), 
                    Random.Range(0f, 1f)
            );
            
            passedTime = 0;
        }

    }
}
