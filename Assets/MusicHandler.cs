using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    public AudioSource mainMusic;

    public void musicOff()
    {
        mainMusic.volume = 0f;
    }
    public void musicOn()
    {
        mainMusic.volume = 0.5f;
    }
}
