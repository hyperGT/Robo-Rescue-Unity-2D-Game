using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemy : MonoBehaviour
{

    [SerializeField] 
    private float XIAO;  //velocidade

    [SerializeField]
    private int EnemyHealth;

    [SerializeField]
    private GameObject Explosao;
    
    

    [SerializeField]
    private GameObject AudioExplosion;

    [SerializeField]
    private int Pontos;

    [SerializeField]
    private GameObject PointsSprite;
    
    [SerializeField]
    private Vector3 Ajuste;

    

    //private int LifeP;

    void Start()
    {
        //Ajuste = new Vector3(0, 0.22f, 0);
        Physics2D.IgnoreLayerCollision(8, 9, true);
        Physics2D.IgnoreLayerCollision(8,11, true);
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }

    
    void Update()
    {

        transform.Translate(-XIAO * Time.deltaTime,0,0);
        
        

        if(EnemyHealth <= 0 )
        {
            Destroy(gameObject);

            
            Instantiate(Explosao, transform.position, Quaternion.identity);
            Instantiate(PointsSprite, (transform.position - Ajuste), Quaternion.identity);
            Instantiate(AudioExplosion, transform.position, Quaternion.identity);


            UI.instance.Score += Pontos;

        
        }
   
    }

    



    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if(collision.gameObject.CompareTag("TIRO"))
        {
            Destroy(collision.gameObject);
            EnemyHealth -= Moveplane.instance.DanoPlayer;
        }

        if(collision.gameObject.CompareTag("Fim_inimigo"))
        {
            Destroy(gameObject);   

            //UI.instance.Score -= Pontos;
        }
         if(collision.gameObject.CompareTag("Protagonista"))
        {
            UI.instance.lifeBar -= 1;
        }
    }

   
}
