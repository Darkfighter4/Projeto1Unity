using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);

        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Moneys restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes = restantes - valor;
        hud.text = $"Moneys restantes: {restantes}";
        source.PlayOneShot(clipMoeda);
        
        if(restantes <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "  Para-Béns clap clap";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
