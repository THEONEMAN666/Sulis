using UnityEngine;


class HaziFeladat : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] bool divisibleWith7;
    [SerializeField] bool divisibleWith15;
    [SerializeField] bool divisibleWith99; 

    void OnValidate()
    {
        int remainder = number % 7;       
        divisibleWith7 = remainder == 0;
        divisibleWith15 = number % 15 == 0;
        divisibleWith99 = number % 99 == 0;

    }


}

public class HaziFeladat2 : MonoBehaviour
{
               //A 1/es feladat
    
    [SerializeField] float a;
    [SerializeField] float b;

    [SerializeField] float summa;       
    [SerializeField] float difference;  
    [SerializeField] float product;     
    [SerializeField] float quotient;
              void OnValidate()
    {
      summa = a + b;
      difference = a - b;
      product = a * b;
      quotient = a / b;
    }
 }


