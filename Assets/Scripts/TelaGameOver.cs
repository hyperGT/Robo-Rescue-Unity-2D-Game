using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaGameOver : MonoBehaviour
{

    public static TelaGameOver instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
}
