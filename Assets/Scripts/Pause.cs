using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public static Pause instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

// --------------------------------------------------------------- xGT

    

    public GameObject BackFase1Theme;

    [SerializeField]
    private GameObject TextoEnter, Continue, Options, Quit, PAUSE_MENU;
    
    public GameObject MusicButton, ParticlesOpt, BackBtn, ButtonAcesss, ButtonSFX; //options 
    
    public GameObject MusicButtonOff, ParticlesOptOff, ButtonAcesssOFF, ButtonSFX_off; //options 

    [SerializeField]
    private GameObject HUD_img; //options

    [SerializeField]
    private GameObject ImagemOptionsInGame; //options

    [SerializeField]
    private GameObject tEXtoTutorial; 
    
    
    [SerializeField]
    private SpriteRenderer MikeOpacit;
    [SerializeField]
    private GameObject PAUSE_BackGround;

    [SerializeField]
    private GameObject AudioButtonBack, AudioBtnSelect, AudioBtnSkip;


    /*[SerializeField]
    private int COnt = 0;*/

    [SerializeField]
    private float timePause;

    public bool verify = false;

    public bool verifyAcessibilidade = false;

    //private int Ramdom = 0;

    /*[SerializeField]
    private Vector3 AjusteBackGround;
   */

    

    void Start()
    {
        MikeOpacit = GetComponent<SpriteRenderer>();
        //BackFase1Theme = GetComponent<AudioSource>();
        ButtonAcesss.SetActive(false);
    }

    void Update()
    {
        functionPAUSE();
        if(Broderagem_de_CENAS.instance.Verify2 == false)
        {
            BackFase1Theme.SetActive(true);
        }
        else
        {
            
            BackFase1Theme.SetActive(false);
        }
    }

    // Nessa função, tudo vai ser desativado ou ativado, conforme vc pausa o jogo ou despausa.  //função ENTER
    void functionPAUSE()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(Time.timeScale == 1)
            {   
                PauseButton();
            }
            else 
            {
                ContinueButton();
            }
        }
    }

    public void ContinueButton()
    {
        ButtonBack();
        tEXtoTutorial.SetActive(true);
        //DesativaBackGround();

        PAUSE_BackGround.SetActive(false);
        
        PAUSE_MENU.SetActive(false);
        ///
        Continue.SetActive(false);
        Options.SetActive(false);
        Quit.SetActive(false);
        TextoEnter.SetActive(false);
        

        

        verify = false;

        Time.timeScale = 1;
        
    }
    void PauseButton()
    {
                tEXtoTutorial.SetActive(false);
                
                //Marcador de tempo 
                timePause += Time.deltaTime;


                PAUSE_BackGround.SetActive(true);
                
                PAUSE_MENU.SetActive(true);
                ///
                Continue.SetActive(true);
                Options.SetActive(true);
                Quit.SetActive(true);

                TextoEnter.SetActive(true);
                
                
                Time.timeScale = 0;
    }


    public void OptionsInGame()
    {
        PAUSE_BackGround.SetActive(false);
        
        PAUSE_MENU.SetActive(false);
        ////
        Continue.SetActive(false);
        Options.SetActive(false);
        Quit.SetActive(false);
        //TextoEnter.SetActive(false);

        

        // -----------------------------------

        /*Text1Acessibility.SetActive(true);
        Text2Music.SetActive(true);
        Text3Particles.SetActive(true);*/
        ImagemOptionsInGame.SetActive(true);

        
        
        HUD_img.SetActive(false);
        
        
    }

  
    public void Ativabotoes()
    {
        ButtonAcesss.SetActive(true);
        MusicButton.SetActive(true);
        ParticlesOpt.SetActive(true);
        BackBtn.SetActive(true);
    }
    public void DesativaBotoes()
    {
        ButtonAcesss.SetActive(false);
        MusicButton.SetActive(false);
        ParticlesOpt.SetActive(false);
        BackBtn.SetActive(false);
    }

    public void AcessibilidadeON()
    {
        verifyAcessibilidade = true;
        ButtonAcesss.SetActive(false);
        ButtonAcesssOFF.SetActive(true);
    }
    public void AcessibilidadeOFF()
    {
        verifyAcessibilidade = false;
        ButtonAcesss.SetActive(true);
        ButtonAcesssOFF.SetActive(false);
    }
    

    public void ButtonBack()
    {
        //ativa denovo o menu de pause
        PAUSE_BackGround.SetActive(true);
 
        PAUSE_MENU.SetActive(true);
        ///
        Continue.SetActive(true);
        Options.SetActive(true);
        Quit.SetActive(true);
        TextoEnter.SetActive(true);

        // -----------------------

        // desativa tudo que compõe o Menu de options dentro do jogo
        /*Text1Acessibility.SetActive(false);
        Text2Music.SetActive(false);
        Text3Particles.SetActive(false);*/
        ImagemOptionsInGame.SetActive(false);

        HUD_img.SetActive(true);
        TextoEnter.SetActive(true);
    }

    public void buttonOnMusic()
    {
        Broderagem_de_CENAS.instance.Verify2 = true;
        MusicButton.SetActive(false);
        MusicButtonOff.SetActive(true);
        BackFase1Theme.SetActive(false);
    }
    public void buttonOFFMusic()
    {
        Broderagem_de_CENAS.instance.Verify2 = false;
        MusicButton.SetActive(true);
        MusicButtonOff.SetActive(false);
        BackFase1Theme.SetActive(true);
    }
    public void ParticlesOn()
    {
        ParticlesOpt.SetActive(false);
        ParticlesOptOff.SetActive(true);
    }
    public void ParticlesOFF()
    {
        ParticlesOpt.SetActive(true);
        ParticlesOptOff.SetActive(false);  
    }
    public void SFX_ON()
    {
        ButtonSFX.SetActive(false);
        ButtonSFX_off.SetActive(true);
    }
    public void SFX_OFF()
    {
        ButtonSFX.SetActive(true);
        ButtonSFX_off.SetActive(false);  
    }

    public void VoltaMenuScreen()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");

    }

    void OpacityPause()
    {
        //MikeOpacit.color = new Color(1,1,1,0);
        //EnemiesOp1.color = new Color(1,1,1,0);
        //EnemiesOp2.color = new Color(1,1,1,0);
    }
    void OpacityGame()
    {
        //MikeOpacit.color = new Color(1,1,1,0.8f);
        //EnemiesOp1.color = new Color(1,1,1,0.8f);
        //EnemiesOp2.color = new Color(1,1,1,0.8f);
    }


    
}
