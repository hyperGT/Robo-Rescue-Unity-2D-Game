using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplane : MonoBehaviour
{

	public static Moveplane instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
	[SerializeField]
	private string[] Informações;


    [SerializeField]
    private float VelY, VelX; 
	
	public GameObject TiroPreFab;
	public GameObject TiroAzulPrefab;
	//public GameObject TiroFenixDeFogoPrefab;

	[SerializeField]
	private float timeSTiro;

    private Rigidbody2D MikeRB;
    private Animator PlaneAnim;
    private Vector3 AjusteFino;
	public Rigidbody2D	TiroRB;	
	public int DanoPlayer;

	private bool Atirar;
	private bool verify = false;

	//private int DanoMechanicus = 1;

	
    public GameObject AudioBlueTiro;

   
    public GameObject Audio_tiro;

	//public GameObject AudioREDTiro;

	
	public GameObject ShieldHero;
	


    void Start()
    {
		Physics2D.IgnoreLayerCollision(10, 11, true);
		DanoPlayer = 40;
        MikeRB = GetComponent<Rigidbody2D>();
        PlaneAnim = GetComponent<Animator>();
        AjusteFino = new Vector3(-1.15f, 0.15f, 0);
		TiroAzulPrefab.SetActive(false);
		AudioBlueTiro.SetActive(false);
		Audio_tiro.SetActive(true);
		ShieldHero.SetActive(false);
    }

    
    void Update()
    {
        LeituraTeclasEixoY();
		LeituraTeclasEixoX();
		LeituraTiro();
		TesteDeDano();
    }

    //Leitura Eixo Y
		void LeituraTeclasEixoY()
		{
		if(Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
		{
			MikeRB.velocity = new Vector2(MikeRB.velocity.x, VelY);
		}
		else if(Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
		{
			MikeRB.velocity = new Vector2(MikeRB.velocity.x, -VelY);
		}
		else
		{
		MikeRB.velocity = new Vector2(MikeRB.velocity.x, 0);
		}
		}

		//Leitura Eixo X

		void LeituraTeclasEixoX()
		{
		if(Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
		{
			MikeRB.velocity = new Vector2(VelX, MikeRB.velocity.y);
			//AjusteFino = new Vector3(0, 0, 0);
		}
		else if(Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
		{
			MikeRB.velocity = new Vector2(-VelX, MikeRB.velocity.y );
		}
		else
		{
			MikeRB.velocity = new Vector2(0, MikeRB.velocity.y);
		}
		}

	void LeituraTiro()	
		{
			if(Input.GetKey(KeyCode.Space))
			{
				if(verify == false)
				{
				verify = true;
				
				Instantiate(TiroPreFab, (transform.position - AjusteFino), Quaternion.identity);
				Instantiate(TiroAzulPrefab, (transform.position - AjusteFino), Quaternion.identity);
				Instantiate(Audio_tiro, transform.position, Quaternion.identity);
				Instantiate(AudioBlueTiro, transform.position, Quaternion.identity);
				//Instantiate(AudioREDTiro, transform.position, Quaternion.identity);
				

				StartCoroutine("timeTiro");
				}
			    
			}
		}


		private IEnumerator timeTiro()
		{
			if(verify == true)
			{
			yield return new WaitForSeconds(timeSTiro);
			verify = false;
			}
		}

		/*private void OnTriggerEnter2D(Collider2D collision)
		{
			if(collision.gameObject.CompareTag("TIRO_inimigo"))
        {
            Destroy(collision.gameObject);
            UI.instance.lifeBar -= DanoMechanicus;
        }
		}*/
	

	void TesteDeDano()
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			UI.instance.lifeBar -= 1;
		}
		if(Input.GetKeyDown(KeyCode.X))
		{
			UI.instance.lifeBar += 1;
			UI.instance.Score += 10400;

		}
	}
}
