using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip gallina;
    public AudioClip hamster;
    public AudioClip lagarto;

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
        AudioSource.PlayClipAtPoint(clip, cameraPosition);
    }
    public void PlayChiken()
    {
        PlaySound(gallina);
    }

    public void PlayHamser()
    {
        PlaySound(hamster);
    }

    public void Playlagarto()
    {
        PlaySound(lagarto);
    }
}