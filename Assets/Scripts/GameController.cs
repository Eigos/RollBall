using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int areaSize;
    public GameObject pointObject;

    public void AddNewPoint(){
        Vector3 position = new Vector3(Random.Range(-areaSize/2f, areaSize/2f), 0.5f, Random.Range(-areaSize/2f, areaSize/2f));
        Instantiate(pointObject, position, Quaternion.identity);
    }
}
