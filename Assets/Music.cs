using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject MusicPlayer;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(MusicPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
