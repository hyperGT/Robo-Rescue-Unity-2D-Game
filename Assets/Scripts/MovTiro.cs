using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTiro : MonoBehaviour
{
    [SerializeField]
		private float VelTiro;

    void Start()
    {
        
    }

    void Update()
    {
      transform.Translate(VelTiro * Time.deltaTime,0 , 0);
    }

	private void OnTriggerEnter2D(Collider2D collision)
    {
		if(collision.gameObject.CompareTag("LIMITE"));
		{
			Destroy(gameObject);
		}
	}
}
