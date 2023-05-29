using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip gallina;
    public AudioClip pato;
    public AudioClip hamster;
    public AudioClip lagarto;
    public AudioClip serpiente;
    public AudioClip mono;
    public AudioClip vaca;
    public AudioClip pajaro;

    [SerializeField] private AudioSource audio;

    private Vector3 cameraPosition;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        cameraPosition = Camera.main.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void PlaySound(AudioClip clip)
    {
        audio.clip = clip;
        audio.Play();
    }
    public void PlayChicken()
    {
        PlaySound(gallina);
    }
    public void PlayDuck()
    {
      PlaySound(pato);
     }
    public void PlayTaipan()
    {
        PlaySound(serpiente);
    }
    public void PlayMuskrat()
    {
        PlaySound(hamster);
    }
    public void PlayGecko()
    {
        PlaySound(lagarto);
    }
    public void PlayColobus()
    {
        PlaySound(mono);
    }
    public void PlayPudu()
    {
        PlaySound(vaca);
    }

    public void PlaySparrow()
    {
        PlaySound(pajaro);
    }
}