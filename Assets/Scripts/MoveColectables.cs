using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveColectables : MonoBehaviour
{
    
    [SerializeField] 
    private float Velocidade; 


    void Update()
    {
        transform.Translate(-Velocidade * Time.deltaTime,0,0);
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fim_inimigo"))
        {
            Destroy(gameObject);   
        }
    }
}
