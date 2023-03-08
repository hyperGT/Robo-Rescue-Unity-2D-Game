using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip_Cutscen : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void SkiparCutscene()
    {   
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
    }
}
