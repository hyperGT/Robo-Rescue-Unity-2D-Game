using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// xGT

public class Del : MonoBehaviour
{   
    




        [SerializeField]
        private float DelTime;

        void Start()
        {
            Invoke("Deletar", DelTime);  //invocar o cmd Del = Deletar pra deletar ele
        }

        

        void Deletar()
        {
            Destroy(gameObject);  //Destruir o obj da cena
        }
}
