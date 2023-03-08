using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
                            
    public static UI instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // ---------------------------------------------------------------------------------------- // xGT

    /*[SerializeField]
    private int Chances;*/

    public int lifeBar;

	[SerializeField]
	private Image[] Life;

    [SerializeField]
    private Text ScoreV;

    public int Score;

    [SerializeField]
    private Text LivesQnt;

    public int chances;

    public float TempoDeJogo;
    
    [SerializeField]
    private GameObject AudioBGMGameOver;

    void Start()
    {
        lifeBar = 10;
        //Chances = 3;
        chances = 3;
    }

    
    void Update()
    {
        TempoDeJogo += Time.deltaTime;
        EnhancedLifeControl();
        ScoreMainC();
        //LivesPlayer();
        SistemaDEvida();
        LifeBarControl();
        DetectaVida();
    }

    
    

    void ScoreMainC()
    {
        ScoreV.text = Score.ToString("00000000");

        if(Score <= 0)
        {
            Score = 0;
        }
    }

    void SistemaDEvida()
    {
        LivesQnt.text = chances.ToString("00");

        if(chances <= 0)
        {
            chances = 0;
        }
    }

    /*void LivesPlayer()
    {
        if(Chances <= 0)
        {
            Chances = 0;
        }
        if(lifeBar <= 0)
        {
            Chances -= 1;
            lifeBar = 10;
        }
    }*/

    void LifeBarControl()
    {
        if(lifeBar <= 0)
        {
            chances -= 1;
            lifeBar = 10;
        }


        /*if(chances <= 2)
        {
            lifeBar -= 3;
        }
        else if(chances <= 1)
        {
            lifeBar -= 5;
        } */
    }

    void DetectaVida()
    {
        if(chances <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            Instantiate(AudioBGMGameOver, transform.position, Quaternion.identity);
        }
    }

    void EnhancedLifeControl()
    {

        if(lifeBar >= 10)
        {
            lifeBar = 10;
        }
        if(lifeBar <= 0)
        {
           lifeBar = 0;             
        }

        for(int i = 0 ; i <= 9 ; i++)
        {
            Life[i].color = new Color(1,1,1,0);
        }
        for(int i = 0 ; i < lifeBar ; i++)
        {
            Life[i].color = new Color(1,1,1,0.8f);
        }

       
    }


}
