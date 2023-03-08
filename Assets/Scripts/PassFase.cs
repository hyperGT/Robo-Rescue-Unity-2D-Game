using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassFase : MonoBehaviour
{
    public int ScoreFinal;

    [SerializeField]
    private GameObject ImgPDF, TransitionW, Mike, HUD_img, Agradecimento;

    private bool verify = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        ScoreFinal = UI.instance.Score;
        
        StartCoroutine("PassouDeFase");
    }

    private IEnumerator PassouDeFase()
    {
        if(ScoreFinal == 10500)
        { 
           HUD_img.SetActive(false);
           TransitionW.SetActive(true);
           ImgPDF.SetActive(true);
           Agradecimento.SetActive(true);
           //UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 2");
           
           yield return new WaitForSeconds(5.0f);
           UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
           verify = true;
        }
        else if(verify == true)
        {
            
                
           /*HUD_img.SetActive(true);
           TransitionW.SetActive(false);
           ImgPDF.SetActive(false);*/
        }
    }

}
