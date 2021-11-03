using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour
{
    public AudioClip SomPegarMoeda;
    public GameObject TextoMoedas;

    private int QtdMoedas;
    void Start()
    {
        this.QtdMoedas = 0;
        AtualizarHUD();
    }

    private void AtualizarHUD()
    {
        TextoMoedas.GetComponent<Text>().text = QtdMoedas.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("coin"))
        {
            Destroy(col.gameObject);
            this.GetComponent<AudioSource>().PlayOneShot(SomPegarMoeda);
            this.QtdMoedas++;
            AtualizarHUD();
        }
    }
}
