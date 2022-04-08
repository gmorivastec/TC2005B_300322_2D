using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioCharacter : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;

    private AudioSource player;
    private int pistaActual;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
        pistaActual = 0;

        player.clip = clips[0];

        player.mute = false;
        player.loop = true;
        player.playOnAwake = false;         
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            pistaActual++;
            // +=
            // -=
            // *=
            // /=
            // %=
            pistaActual %= clips.Length;
            player.clip = clips[pistaActual];
        }

        if(Input.GetKeyDown(KeyCode.S)){
            player.Play();
        }

        if(Input.GetKeyDown(KeyCode.D)){
            player.Pause();
        }

        if(Input.GetKeyDown(KeyCode.F)){
            player.Stop();
        }
    }
}
