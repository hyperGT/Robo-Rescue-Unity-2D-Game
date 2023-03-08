using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxEfeito : MonoBehaviour
{
    [SerializeField]
	private float velocidade;

	[SerializeField]
	private Renderer Quad;

	private Vector2 Offset;

	void Start(){
	
	Quad = GetComponent<Renderer>();
	
	}
	
	
  
    void Update()
    {
	Offset = new Vector2(velocidade * Time.deltaTime, 0);    
	
	Quad.material.mainTextureOffset += Offset;
    }
}
