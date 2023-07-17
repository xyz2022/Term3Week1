using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeRocket : MonoBehaviour
{
    public GameObject parts;
    public GameObject explosion;
    private new ParticleSystem particleSystem;
    // Start is called before the first frame update



    void Start()
    {
        particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Explode()
    {
        parts.SetActive(false);
        particleSystem.Play();

    }
}
