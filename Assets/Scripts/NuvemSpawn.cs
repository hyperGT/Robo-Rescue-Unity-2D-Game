using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuvemSpawn : MonoBehaviour
{
    private Rigidbody2D CriarRB;

    [SerializeField]
    private float Velocidade;

    [SerializeField] 
    private GameObject NvemSpawn;




    void Start()
    {
        CriarRB = GetComponent<Rigidbody2D>(); 
        CriarRB.velocity = new Vector2(CriarRB.velocity.x, Velocidade);
    }

    
    void Update()
    {
        
    }
}
