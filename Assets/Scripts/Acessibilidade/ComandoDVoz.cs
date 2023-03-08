using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandoDVoz : MonoBehaviour
{
    
 
    [SerializeField]
    private GameObject audio1, audio2;
    
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.CompareTag("cima"))
        {     
         StartCoroutine("Audio1");
        }
    }
    private IEnumerator Audio1()
    {
        if(Pause.instance.verifyAcessibilidade = true)
        {
            //instantiate();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
