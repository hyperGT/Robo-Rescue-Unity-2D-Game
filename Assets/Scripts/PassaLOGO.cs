using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaLOGO : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        StartCoroutine("PassaLOGO1");
    }

    private IEnumerator PassaLOGO1()
    {
        yield return new WaitForSeconds(3.4f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
    }
}
