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
        StartCoroutine("HuevoCorrutine");
        InicioHuevos();
    }
   

     }
//creamos huvos de manera random para que caigan 
    void CrearHuevo()
    {
        float posRandomx = Random.Range(0f, -157f);
        float posRandomz = Random.Range(0f, -113f);
        float posRandomy = Random.Range(0f, 200f);
        Vector3 DestPos = new Vector3(posRandomx, posRandomy, posRandomz);
        Vector3 NewPos = InitPos.position + DestPos;

        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(Huevo, NewPos, Quaternion.identity);
    }
// Update is called once per frame
        IEnumerator HuevoCorrutine()
        {

                for (int n = 0; ; n++)
                 {

                         //Intancio el prefab en coordenadas 0,0,0
                        
                         CrearHuevo();
                         yield return new WaitForSeconds(0.1f);


                }
        }
// iniciamos los huevos para que caigan en x y z
            void InicioColumnas()
            {
                      for (int n = 0; n < 5; n++)
                         {
                            float posRandomx = Random.Range(170f, -160f);
                           float posRandomz = Random.Range(240f, -110f)
                            Vector3 NewPos = new Vector3(posRandomx, posRandomy, posRandomz);
                            Vector3 finalPos = InitPos.position + NewPos;
                            Instantiate(Huevo, finalPos, Quaternion.identity);
                      }
            }   



}
