using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixasDePoder : MonoBehaviour
{


/*
Caixa verde: aumento de 20% do poder de fogo, duração: 20s. Total: 200% de dano 10 tiros 
Caixa amarela: aumento de 40% do poder de fogo, duração: 10s. Total: 400% 
Caixa Azul: aumento de 60% de poder de fogo, aumento da velocidade do tiro, duração: 8s 
Caixa Vermelho: aumento de 100% de poder de fogo, Invencibilidade, duração: 5s.   
*/

    [SerializeField]
    private GameObject PowerVerde;  
    [SerializeField]
    private GameObject PowerAmarela; 
    [SerializeField]
    private GameObject PowerAzul;
    [SerializeField]
    private GameObject PowerVermelho; 
   
    [SerializeField]
    private GameObject ShielHero;

    private bool verify = false;

    [SerializeField]
    private CapsuleCollider2D MikeCC2D;
    

    [SerializeField]
    private int InformaDanoPlayer;

    void Start()
    {
        MikeCC2D = GetComponent<CapsuleCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.CompareTag("CaixaVerde"))
        {
            if(verify == false)
            {
            verify = true;
            }
            
        StartCoroutine("CaixaVerde");
        }
        if(collision.gameObject.CompareTag("CaixaAmarela"))
        {
            if(verify == false)
            {
            verify = true;
            }

            StartCoroutine("CaixaAmarela");   
        }
        if(collision.gameObject.CompareTag("CaixaAzul"))
        {
            if(verify == false)
            {
            verify = true;
            }

            StartCoroutine("CaixaAzul");
        }   
        if(collision.gameObject.CompareTag("CaixaVERMELHA"))
        {
            if(verify == false)
            {
            verify = true;
            }

            StartCoroutine("CaixaVERMELHA");
        }   
        }
    

    private IEnumerator CaixaVERMELHA()
    {
        if(verify == true)
        {
        PowerVermelho.SetActive(true);
        Moveplane.instance.DanoPlayer += 100; 

        MikeCC2D.GetComponent<CapsuleCollider2D>().enabled = false;
        
        Moveplane.instance.ShieldHero.SetActive(true);
        
        //Moveplane.instance.TiroPreFab.SetActive(false); 
        //Moveplane.instance.TiroFenixDeFogoPrefab.SetActive(true);
        //Moveplane.instance.AudioREDTiro.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        verify = false;
        }
        if(verify == false)
        {   
            PowerVermelho.SetActive(false);
            MikeCC2D.GetComponent<CapsuleCollider2D>().enabled = true;
            Moveplane.instance.DanoPlayer -= 100;
        }
    }
    private IEnumerator CaixaAzul()
    {
        if(verify == true)   
        {

        PowerAzul.SetActive(true);
        Moveplane.instance.DanoPlayer += 60;
        
        Moveplane.instance.TiroPreFab.SetActive(false);
        Moveplane.instance.Audio_tiro.SetActive(false);

        Moveplane.instance.TiroAzulPrefab.SetActive(true);
        Moveplane.instance.AudioBlueTiro.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        verify = false;
        }
        if(verify == false)
        {
        PowerAzul.SetActive(false);
        Moveplane.instance.DanoPlayer -= 60;
        Moveplane.instance.TiroPreFab.SetActive(true);
        Moveplane.instance.Audio_tiro.SetActive(true);

        Moveplane.instance.TiroAzulPrefab.SetActive(false);
        Moveplane.instance.AudioBlueTiro.SetActive(false);
        }
    }
    private IEnumerator CaixaAmarela()
    {
        if(verify == true)   
        {
            PowerAmarela.SetActive(true);
            Moveplane.instance.DanoPlayer += 40;
            yield return new WaitForSeconds(10.0f);
            verify = false;
        }
        if(verify == false)
        {
            PowerAmarela.SetActive(false);
            Moveplane.instance.DanoPlayer -= 40;
        }
    }
    private IEnumerator CaixaVerde()
    {
        if(verify == true)
        {
        PowerVerde.SetActive(true);
        Moveplane.instance.DanoPlayer += 20;
        yield return new WaitForSeconds(20.0f);
        verify = false;
        }
        if(verify == false)
        {
            PowerVerde.SetActive(false);
            Moveplane.instance.DanoPlayer -= 20;
        }
    }
    
}

