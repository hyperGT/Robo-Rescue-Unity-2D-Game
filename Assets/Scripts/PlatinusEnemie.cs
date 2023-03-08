using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatinusEnemie : MonoBehaviour
{
    [SerializeField]
    private GameObject TiroInimigoPl;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Platinus_mEchius();
    }

    void Platinus_mEchius()
    {
        StartCoroutine("TiroDoPlatinus");
    }

    private IEnumerator TiroDoPlatinus()
    {
        if(Inimigos.instance.verifyCriaPl = true)
        {
            Instantiate(TiroInimigoPl, transform. position, Quaternion.identity); 
            yield return new WaitForSeconds(0.5f);
        }
    }
}
