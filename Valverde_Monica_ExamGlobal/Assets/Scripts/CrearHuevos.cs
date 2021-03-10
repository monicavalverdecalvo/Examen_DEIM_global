using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearHuevos : MonoBehaviour
{
    //Variable que contendré el prefab con el huevo
    [SerializeField] GameObject Huevo;
    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;

    //Variables para generar huevoss de forma random
    private float randomNumber;
    Vector3 RandomPos;

    //Distacia a la que se crean los huevos iniciales
    [SerializeField] float distaciaInicial = 5;


    // Start is called before the first frame update
    void Start()
    {
        //Crear huevos iniciales

        for (int n = 1; n <= 30; n++)
        {

            CrearHuevo(n * distaciaInicial);
        }

        //Lanzo la corrutina
        StartCoroutine("InstanciadorHuevos");
    }
//Creamos huevos de manera random
    void CrearHuevo(float posZ = 0f)
    {
        randomNumber = Random.Range(0f, 7f);
        RandomPos = new Vector3(randomNumber, 0, 0);
        RandomPos = new Vector3(randomNumber, 0, posZ);
        //print(RandomPos);
        Vector3 FinalPos = InitPos.position + RandomPos;
        Instantiate(Huevo, FinalPos, Quaternion.identity);

    }
        // Update is called once per frame
        void Update()
        {

        }
}
