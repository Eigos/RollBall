using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using System.Threading;

  
public class BallController : MonoBehaviour
{   

    public TextMeshProUGUI pointText ;

    public GameObject winTextObject;
    Rigidbody rb;
    public int point;
    public float speed;
    public GameController gameController;



    void Start()
     {

        rb = GetComponent<Rigidbody>();

        SetPointText();
        winTextObject.SetActive(false);
        

    }

    void SetPointText()
    {
        pointText.text = "Point = " + point.ToString();

    }

    void Update()
    {
        float hValue = Input.GetAxis("Horizontal");
        float vValue = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(hValue * speed, rb.velocity.y, vValue * speed);
        
       
    
    }

    void OnTriggerEnter(Collider other)
     {
      
        point++;
        Destroy(other.gameObject);
        gameController.AddNewPoint();
        pointText.text = "Point = " + point.ToString();
        

        if(point >= 50)
        {
             winTextObject.SetActive(true);

             
            
            if(EditorApplication.isPlaying) 
            {
    
             UnityEditor.EditorApplication.isPlaying = false;
            }

             
        }

        
        
        
    
    }
}
