using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{

     public static Inimigos instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    } 
    
    private Rigidbody2D CriarRB;
    
    [SerializeField]
    private float Velocidade;

    [SerializeField] 
    private GameObject Black_NOVA, Eneasimus_Green, Mechanicus, Platinus_mEchius;

    private int Cont = 0;

    [SerializeField]
    private int QNT;

    private int Ramdom = 0;

    public int ScoreV;

    public bool verifyCriaPl = false;

    void Start()
    {
        CriarRB = GetComponent<Rigidbody2D>(); 
        CriarRB.velocity = new Vector2(CriarRB.velocity.x, Velocidade);
    }

   
    void FixedUpdate()
    {
        ScoreV = UI.instance.Score;
    }

    void LateUpdate()
    {
        RandomizeTheEnemies();
        EscalaScore();
    }

    void EscalaScore()
    {
        if(ScoreV <= 1000)
        {
            QNT = 310;
        }
        else if(ScoreV > 1000 && ScoreV <= 2000)
        {
            QNT = 250;
        }
        else if(ScoreV > 2000 && ScoreV <= 5000)
        {
            QNT = 230;
        }
        else if(ScoreV > 5000 && ScoreV <= 6000)
        {
            QNT = 200;
        }
        else if(ScoreV > 6000 && ScoreV <= 8000)
        {
            QNT = 180;
        }
        else if(ScoreV > 8000 && ScoreV <= 10000)
        {
            QNT = 130;
        }
    }

    void VerificaValores()
    {
        if(QNT <= 0)
        {
            QNT = 0;
        }
    }
    

    void RandomizeTheEnemies()
    {
        Cont++;
        if(Cont >= QNT)
        {
            Cont = 0;
          

            Ramdom = Random.Range(0,20);

            switch(Ramdom)
            {
                case 0: CriarGreen(); break;
                case 1: CriarBlack(); break;
                case 2: CriarGreen(); break;
                case 3: CriarBlack(); break;
                case 4: CriarGreen(); break;
                case 5: CriarBlack(); break;
                case 6: CriarBlack(); break;
                case 7: CriarGreen(); break; 
                case 8: CriarBlack(); break;
                case 9: CriarGreen(); break;

                /*case 10: CriarGreen(); break;
                case 11: CriarBlack(); break;
                case 12: CriarGreen(); break;
                case 13: CriarBlack(); break;
                case 14: CriarGreen(); break;
                case 15: CriarBlack(); break;
                case 16: CriarBlack(); break;
                case 17: CriarGreen(); break; 
                case 18: CriarBlack(); break;
                case 19: CriarGreen(); break;*/

                default: CriarBlack(); break;    //10 casos 1 avião random 2 total 5 chances green 6 chances black ou seja: 60% de chance black e 40% Green
            }
        }
    }

    void CriarMechanicus()
    {
        //Instantiate();   
    }

    void CriarPlatinus()
    {
        verifyCriaPl = true;
        //Instantiate(); 
    }

    

    void CriarBlack()
    {
        Instantiate(Black_NOVA, transform.position, Quaternion.identity);
    }

    void CriarGreen() 
    {
        Instantiate(Eneasimus_Green, transform.position, Quaternion.identity);
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
