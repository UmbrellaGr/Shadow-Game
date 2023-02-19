using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadDeMovmiento;

    private Vector2 offset;

    private Material material;

    private Rigidbody2D jugador;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        offset = (jugador.velocity.x * 0.1f) * velocidadDeMovmiento * Time.deltaTime;
        material.mainTextureOffset += offset;

    }
}
