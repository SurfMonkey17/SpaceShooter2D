using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _enemySpeed = 4.0f;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomX = Random.Range(-8f, 8f); //variable to use anytime we go off screen and want to spawn randomly along x-axis. 

        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime);        
       
        if (transform.position.y < -4.5f) 
        {
            transform.position = new Vector3(randomX, 6, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit: " + other.transform.name);

      
        if (other.tag == "Player")
        {
           
            Player player = other.transform.GetComponent<Player>();
            
            if(player != null)
            {
                player.Damage();
            }
            
            Destroy(this.gameObject);
        }
        
        
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        
        
        
    }
}
