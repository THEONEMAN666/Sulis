using UnityEngine;

public class PUSKA : MonoBehaviour
{
    [SerializeField] int number1;  // Ciklusszámláás a number1 által meghatározott értékig
    void Start()
    {
        int lekvar;     //Egész számok start alatt értékkel [SeriayeField]-ben anélkül
        lekvar = 7;
                  
                                                 // ALAPMÜVELETEK
                   
        int summa;      // összeadás +
        int difference; // kivonás -
        int product;    // szorzás *
        int quotient;   // Osztas /
        int remainder;  // Maradék %
        int pow2;  // Négyzetre emelés
        float mean;     // Átlag
        string concatenated; // Összefüzés
        string textAnswer;   // Szöveges válasz
        float radius; // Sugár
        float perimeter; // Kerület
        float are; // Terület
        bool divisibleWith; // Oszthatóság
        bool isEven; // Páros e a szám
        bool isOdd; // Páratlan e a szám
        int baseNumber, exponent; // Alapérték+hatványérték
        int Mathf; //Minimum és maximum meghatározása --> min = Mathf.Min(a, b, c, d, e);
        float round, roundUp, roundDown; // Kerekitések 
        bool muveletjelek; //Egyenlõség ==,Egyenlõtlenség !=, ÉS &&,VAGY ||,Logikai kizáró ^,
        
       
        


        // SZERKEZETEK

        float sikerulj;  //Elõször el kell nevezni a valtozot amivel lehivhatjuk 
        float sikeruljmar;

        sikerulj = 2.5f;  //Utánna értéket kell adni 
        sikeruljmar = 5.5f;

        float osszeadas = sikerulj + sikeruljmar;  //Ezután meghatározzuk a müveleteket amit elvárunk tõle
        float kivonas = sikeruljmar - sikerulj;
        float szoras = sikerulj * sikeruljmar;
        float osztas = sikeruljmar / sikerulj;

        Debug.Log(kivonas);                           //A múvelet nevével irjuk ki az eredményt 

        int number, number1, number2;

        number = 50; number1 = 29; number2 = 76;

        bool equalityCheck1 = number >= number1;      // bool alapú értékhasonlitás 

        Debug.Log(equalityCheck1);

        int i = 1;
        while (i <= number1)   // Ciklus tipus meghatározása
        {
            Debug.Log(i);
            i++;   // Érték folyamatos növelése (a hurok elkerülése érdekében)
        }




    }


}
