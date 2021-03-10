using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
// script para cuando el huevo colisiona con el suelo
    [SerializeField] MeshRenderer myMesh;
    Vector3 pos;
    public float speed = 3f;
   
    //para los diferentes tipos de audio que hay
    AudioSource audioSource;
    [SerializeField] AudioClip Fondo;
    [SerializeField] AudioClip HuevoCae;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 1f;


    }
    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Huevo")
        {

            HuevoRoto();
        }
    }

    void HuevoRoto()
    {
        myMesh.enabled = false;
        speed = 0;
        pos = transform.position;
      
        audioSource.PlayOneShot(explosion, 1f);
    }


}