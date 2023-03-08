using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanicus : MonoBehaviour
{
    [SerializeField]
    private GameObject TiroMechanicus;

    [SerializeField]
    private float AjusteTiro;

    void Start()
    {

    }

    void Update()
    {

    }
    void AtiraInimigo()
    {
        Instantiate(TiroMechanicus, transform.position, Quaternion.identity);
    }
}
