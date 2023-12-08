using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public int Puntos;
    public Text Puntostxt;
    public AudioSource _compAudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        _compAudioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        UpdatePoints(0);
    }
    public void UpdatePoints(int score)
    {
        Puntos = Puntos + score;
        Puntostxt.text = "Puntos: " + Puntos;
    }
}
