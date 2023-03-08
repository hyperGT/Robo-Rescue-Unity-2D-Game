using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRestore : MonoBehaviour
{

    [SerializeField]
    private GameObject AudioHestCollect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.CompareTag("Protagonista"))
        {
            UI.instance.lifeBar += 5;
            Destroy(gameObject);
            Instantiate(AudioHestCollect, transform.position, Quaternion.identity);
        }
    }
    void Update()
    {
        
    }
}
