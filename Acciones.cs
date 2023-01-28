using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Acciones : MonoBehaviour
{
    public TextMeshProUGUI posibles, operacion,resultado;
    public TMP_InputField entrada1,entrada2;
    int puntos = 0;
    public GameObject[] botones;


    private void Start()
    {
        posibles.text = "2, 8, 9 , 5";
        operacion.text = "+";
        resultado.text = "11";
    }
    public void Pregunta1()
    {



        if (entrada1.text == "8" && entrada2.text == "3")
        {
            puntos++;


        }
        else if (entrada1.text == "3" && entrada2.text == "8")
        {
            puntos++;
        }
        botones[0].SetActive(false);
        botones[1].SetActive(true);

        //Inicializar pregunta2 
        posibles.text = "2, 7, 4 , 6";
        operacion.text = "+";
        resultado.text = "9";
        entrada1.text = "";
    }

    public void Pregunta2()
    {

        if (entrada1.text == "2" && entrada2.text == "7")
        {
            puntos++;

        }
     
        
        botones[1].SetActive(false);
        botones[2].SetActive(true);

        //Inicializar pregunta3 
        posibles.text = "1, 3, 9 , 2";
        operacion.text = "-";
        resultado.text = "7";
        entrada1.text = "";
    }

    public void Pregunta3()
    {

        if (entrada1.text == "9" && entrada2.text == "2")
        {
            puntos++;


        }
      
       
        botones[2].SetActive(false);
        botones[3].SetActive(true);

        //Inicializar pregunta4 
        posibles.text = "1, 4, 9 , 8";
        operacion.text = "+";
        resultado.text = "5";
        entrada1.text = "";
    }

    public void Pregunta4()
    {

        if (entrada1.text == "1" && entrada2.text == "4")
        {
            puntos++;


        }
    
        botones[3].SetActive(false);
        botones[4].SetActive(true);

        //Inicializar pregunta5 
        posibles.text = "1, 2, 9 , 6";
        operacion.text = "-";
        resultado.text = "3";
        entrada1.text = "";
    }

    public void Pregunta5()
    {

        if (entrada1.text == "9" && entrada2.text == "6")
        {
            puntos++;


        }

        botones[4].SetActive(false);
        botones[5].SetActive(true);

        //Inicializar pregunta6 
        posibles.text = "3, 2, 9 , 4";
        operacion.text = "+";
        resultado.text = "6";
        entrada1.text = "";
    }

    public void Pregunta6()
    {

        if (entrada1.text == "2" && entrada2.text == "4")
        {
            puntos++;


        }

        botones[5].SetActive(false);
        botones[6].SetActive(true);

        //Inicializar pregunta7
        posibles.text = "11, 4, 9 , 5";
        operacion.text = "+";
        resultado.text = "15";
        entrada1.text = "";
    }

    public void Pregunta7()
    {

        if (entrada1.text == "11" && entrada2.text == "4")
        {
            puntos++;


        }

        botones[6].SetActive(false);
        botones[7].SetActive(true);

        //Inicializar pregunta8 
        posibles.text = "12, 8, 9 , 10";
        operacion.text = "+";
        resultado.text = "22";
        entrada1.text = "";
    }

    public void Pregunta8()
    {

        if (entrada1.text == "12" && entrada2.text == "10")
        {
            puntos++;


        }

        botones[7].SetActive(false);
        botones[8].SetActive(true);

        //Inicializar pregunta9
        posibles.text = "1, 8, 2 , 5";
        operacion.text = "+";
        resultado.text = "3";
        entrada1.text = "";
    }

    public void Pregunta9()
    {

        if (entrada1.text == "1" && entrada2.text == "2")
        {
            puntos++;


        }

        botones[8].SetActive(false);
        botones[9].SetActive(true);

        //Inicializar pregunta10
        posibles.text = "10, 20, 9 , 3";
        operacion.text = "-";
        resultado.text = "17";
        entrada1.text = "";
    }

    public void Pregunta10()
    {

        if (entrada1.text == "20" && entrada2.text == "3")
        {
            puntos++;


        }
        botones[9].SetActive(false);
        botones[10].SetActive(true);
    }
   

    //Esconder entradas y etiquetas
    //Mostrar retroalimentacion

    public void MostrarRetro()
    {
        if (puntos <= 6)
        {
            //propiedad text poner mensaje
        }
        else if(puntos <= 9)
        {

        }
        else if(puntos == 10)
        {

        }
    }
}





