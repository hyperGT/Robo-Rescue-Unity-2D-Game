using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPOWERR : MonoBehaviour
{
    

    private Rigidbody2D CriarRB;

    private int Cont = 0;

    [SerializeField]
    private int QNT;

    private int Ramdom = 0;

    [SerializeField]
    private float Velocidade;

    [SerializeField] 
    private GameObject CaixaVerde, CaixaAmarela, CaixaAzul, CaixaVermelha, Health;




    void Start()
    {
        CriarRB = GetComponent<Rigidbody2D>(); 
        CriarRB.velocity = new Vector2(CriarRB.velocity.x, Velocidade);
    }

    
    void Update()
    {
        RandomizePowerUp();
    }

    void RandomizePowerUp()
    {
        Cont++;
        if(Cont >= QNT)
        {
            Cont = 0;
          

            Ramdom = Random.Range(0,16);

            switch(Ramdom)
            {
                case 0: CriarCaixaVerde(); break;
                case 1: CriarCaixaAmarela(); break;
                case 2: CriarCaixaAmarela(); break;
                case 3: CriarCaixaVerde(); break;
                case 4: CriarCaixaVerde(); break;
                case 5: CriarCaixaVerde(); break;
                case 6: CriarCaixaAzul(); break;
                case 7: CriarCaixaAmarela(); break; 
                case 8: CriarCaixaAzul(); break;
                case 9: CriarCaixaVERMELHA(); break;
                case 10: CriarCaixaVIDA(); break;
                case 11: CriarCaixaVerde(); break;
                case 12: CriarCaixaVIDA(); break;
                case 13: CriarCaixaAmarela(); break;
                case 14: CriarCaixaVIDA(); break;
                case 15: CriarCaixaVIDA(); break;

                default: CriarCaixaVerde(); break;    
            }
        }
    }

    void CriarCaixaVerde()
    {
        Instantiate(CaixaVerde, transform.position, Quaternion.identity);

    }
    void CriarCaixaAmarela() 
    {
        Instantiate(CaixaAmarela, transform.position, Quaternion.identity);
    }
    void CriarCaixaAzul()
    {
        Instantiate(CaixaAzul, transform.position, Quaternion.identity);

    }
    void CriarCaixaVERMELHA() 
    {
        Instantiate(CaixaVermelha, transform.position, Quaternion.identity);
    }
    void CriarCaixaVIDA() 
    {
        Instantiate(Health, transform.position, Quaternion.identity);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CIMA"))
        {
            CriarRB.velocity = new Vector2(CriarRB.velocity.x, -Velocidade);
        }
        if(collision.gameObject.CompareTag("BAIXO"))
        {
            CriarRB.velocity = new Vector2(CriarRB.velocity.x, Velocidade);
        }
    }
}
