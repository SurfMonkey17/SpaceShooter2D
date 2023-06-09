using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //speed variable of 8

    [SerializeField]
    private float _speed = 8f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
