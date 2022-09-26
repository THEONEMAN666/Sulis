
using UnityEngine;

public class Próba : MonoBehaviour
{
    [SerializeField] int number1;        // Ciklusszámláás a number1 által meghatározott értékig
    void Start()
    {
        float sikerulj;                               //Először el kell nevezni a valtozot amivel lehivhatjuk 
        float sikeruljmar;

        sikerulj = 2.5f;                              //Utánna értéket kell adni 
        sikeruljmar = 5.5f;

        float osszeadas = sikerulj + sikeruljmar;     //Ezután meghatározzuk a müveleteket amit elvárunk tőle
        float kivonas = sikeruljmar - sikerulj;
        float szoras = sikerulj * sikeruljmar;
        float osztas = sikeruljmar / sikerulj;

        Debug.Log(kivonas);                           //A múvelet nevével irjuk ki az eredményt 

        int number, number1, number2;

        number = 50; number1 = 29; number2 = 76;

        bool equalityCheck1 = number >= number1;      // bool alapú értékhasonlitás 

        Debug.Log(equalityCheck1);

        int i = 1;
        while (i <= number1)          // Ciklus tipus meghatározása
        {
            Debug.Log(i);
            i++;                      // Érték folyamatos növelése (a hurok elkürése érdekében)
        }


        if (number > 49) ;
        {
            Debug.Log(number2);
        }
        
    }
 
         
              
    
}








     