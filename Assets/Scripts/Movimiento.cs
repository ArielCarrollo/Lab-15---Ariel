using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float Speed;
    public float Horizontal;
    public float Vertical;
    public GameObject BallPrefab;
    private SpriteRenderer _compSpriteRenderer;
    private Rigidbody2D _compRigidbody2D;
    public AudioSource _compAudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(BallPrefab, transform.position, transform.rotation);
            _compAudioSource.Play();
        }
        if (Horizontal == 1)
        {
            _compSpriteRenderer.flipX = false;
        }
        else if (Horizontal == -1)
        {
            _compSpriteRenderer.flipX = true;
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(Horizontal * Speed, Vertical * Speed);
    }
}
