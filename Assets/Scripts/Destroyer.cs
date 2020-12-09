using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public int point;
    public GameObject masterObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<Score>().AddPoint(point);
        
        masterObj.GetComponent<GameMaster>().boxNum--;
        Destroy(gameObject);
    }
}
