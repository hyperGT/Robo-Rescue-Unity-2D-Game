using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiscaTexto : MonoBehaviour
{

 private float velocidade,tempoanimbkp;
 private Text texto;

 [SerializeField]
 private float tempoanim;


 void Start () 
 {
 texto = GetComponent<Text>();
 tempoanimbkp = tempoanim;
 }
 
 
 void Update () 
 {

 tempoanim -= Time.deltaTime;

 if (tempoanim <= 0)
 {
 texto.enabled = !texto.enabled;
 tempoanim = tempoanimbkp;
 }

 }

}

