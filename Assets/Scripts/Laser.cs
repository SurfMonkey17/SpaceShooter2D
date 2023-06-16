using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
   
    [SerializeField]
    private float _speed = 10f; 
   
    // Update is called once per frame
    void Update()
    {
        //translate laser up infinitely. 
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        //if laser position >12 on y, destroy object
        if (transform.position.y > 12)
            Destroy(gameObject);
    }
}
