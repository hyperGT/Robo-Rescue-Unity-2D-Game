using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broderagem_de_CENAS : MonoBehaviour
{
        public static Broderagem_de_CENAS instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    } 

    [SerializeField]
    private GameObject MusicOfMainThemeMenu;

    [SerializeField]
    private GameObject TransitionBlack;

    [SerializeField]
    private GameObject AtivOptions, AtivStart, AtivCredits,MusicButtonON, MusicButtonOFF;

    [SerializeField]
    private GameObject ButtonBack, AudioButtonBack, AudioBtnSelect, AudioBtnSkip, TextCopyRight;

    /*[SerializeField]
    private GameObject TiroSe;*/

    public bool Verify2 = false;



    void Start()
    {
        
    }

    void Update()
    {
        if(Verify2 == false)
        {
            MusicOfMainThemeMenu.SetActive(true);
        }
        else
        {
            
            MusicOfMainThemeMenu.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 1");
            Instantiate(AudioBtnSkip, transform.position, Quaternion.identity);
        }
    }

    public void StartTheGame()
    {
        
        Instantiate(AudioBtnSelect, transform.position, Quaternion.identity);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");  
        StartConfig();
    }

    public void ExitTutorial()
    {   
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase 1");
        StartConfig();
    }

    public void RunOptions()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Options");
        
        Instantiate(AudioBtnSelect, transform.position, Quaternion.identity);
        AtivOptions.SetActive(true);
        AtivStart.SetActive(false);
        
        Instantiate(TransitionBlack, transform.position, Quaternion.identity);
    }

    

    public void CREDITOS_CENA()
    {
        Instantiate(AudioBtnSelect, transform.position, Quaternion.identity);
        Instantiate(TransitionBlack, transform.position, Quaternion.identity);
        AtivStart.SetActive(false);
        AtivCredits.SetActive(true);
        ButtonBack.SetActive(true);
    }

    public void BackStartMenu()
    {
        Instantiate(AudioButtonBack, transform.position, Quaternion.identity);
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
        Instantiate(TransitionBlack, transform.position, Quaternion.identity);
    }

    public void BackToMenu()
    {
        StartConfig();
        
        Instantiate(AudioButtonBack, transform.position, Quaternion.identity);
        ButtonBack.SetActive(false);
        AtivOptions.SetActive(false);
        AtivCredits.SetActive(false);
        AtivStart.SetActive(true);
        

        Instantiate(TransitionBlack, transform.position, Quaternion.identity);
    }

    public void SairJOGO()
    {
        Application.Quit(); 
    }


    public void MUsicON()
    {
        Instantiate(AudioBtnSelect, transform.position, Quaternion.identity);
        MusicButtonON.SetActive(false);
        MusicButtonOFF.SetActive(true);
        MusicOfMainThemeMenu.SetActive(false);
        Verify2 = true;
    }
    public void MusicOFF()
    {
        Verify2 = false;
        Instantiate(AudioBtnSelect, transform.position, Quaternion.identity);
        MusicButtonON.SetActive(true);
        MusicButtonOFF.SetActive(false);
        MusicOfMainThemeMenu.SetActive(true);
    }

    // foi implementado pra corrigir um bug da 0.7.1, onde, ao pausar o jogo e selecionar pra sair da Fase1 e voltar para o menu, e selecionar a opção START pra iniciar o jogo de novo, por algum motivo, o TimeScale do jogo iniciava em 0;
    //serve também para modificar o jogo.
   void StartConfig()
    {
        Time.timeScale = 1;
        //TiroSe.SetActive(true);
    }
}
