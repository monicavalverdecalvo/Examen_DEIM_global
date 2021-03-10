using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCaja : MonoBehaviour
{

    [SerializeField] float speed = 50f;
    //Texto que contiene el texto de tiempo
    [SerializeField] Text textoHuevoroto;

    [SerializeField] MeshRenderer myMeshRender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //declaro la funcion para que se mueva la caja
        MoverCajita();

    }

   
    
   void MoverCajita()

    {
        //Llamo a la funcion que mueve la caja
        //Mueve la caja en horizontal (pero al reves no se por que xD)
        float desplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.left * desplX * Time.deltaTime);

        //Limitador en X
        if (transform.position.x <= -150f)
        {
            transform.position = new Vector3(-150f, transform.position.y);
        }
        else if (transform.position.x >= 150f)
        {
            transform.position = new Vector3(150f, transform.position.y);
        }

      
      
        //para hacer que la cesta desaparezca creamos buleana para cuando se presiona el boton aparezca la cesta(no recuerdo si es false o true pero es asi)
      
        if (Input.GetKey("jostick button 5"))
        {
            myMeshRender.enabled = false;
        }


    }
}

