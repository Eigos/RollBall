using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int areaSize;
    public GameObject pointObject;


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    public void AddNewPoint()
    {
        Vector3 position = new Vector3(Random.Range(-areaSize/2f, areaSize/2f), 0.95f, Random.Range(-areaSize/2f, areaSize/2f));
        Instantiate(pointObject, position, pointObject.transform.rotation);
   
    }

}

    
    
