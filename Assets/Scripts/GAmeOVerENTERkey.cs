using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAmeOVerENTERkey : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
        }
    }
}
