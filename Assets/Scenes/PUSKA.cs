using UnityEngine;

public class PUSKA : MonoBehaviour
{
    [SerializeField] int number1;  // Ciklussz�ml��s a number1 �ltal meghat�rozott �rt�kig
    void Start()
    {
        int lekvar;     //Eg�sz sz�mok start alatt �rt�kkel [SeriayeField]-ben an�lk�l
        lekvar = 7;
                  
                                                 // ALAPM�VELETEK
                   
        int summa;      // �sszead�s +
        int difference; // kivon�s -
        int product;    // szorz�s *
        int quotient;   // Osztas /
        int remainder;  // Marad�k %
        int pow2;  // N�gyzetre emel�s
        float mean;     // �tlag
        string concatenated; // �sszef�z�s
        string textAnswer;   // Sz�veges v�lasz
        float radius; // Sug�r
        float perimeter; // Ker�let
        float are; // Ter�let
        bool divisibleWith; // Oszthat�s�g
        bool isEven; // P�ros e a sz�m
        bool isOdd; // P�ratlan e a sz�m
        int baseNumber, exponent; // Alap�rt�k+hatv�ny�rt�k
        int Mathf; //Minimum �s maximum meghat�roz�sa --> min = Mathf.Min(a, b, c, d, e);
        float round, roundUp, roundDown; // Kerekit�sek 
        bool muveletjelek; //Egyenl�s�g ==,Egyenl�tlens�g !=, �S &&,VAGY ||,Logikai kiz�r� ^,
        
       
        


        // SZERKEZETEK

        float sikerulj;  //El�sz�r el kell nevezni a valtozot amivel lehivhatjuk 
        float sikeruljmar;

        sikerulj = 2.5f;  //Ut�nna �rt�ket kell adni 
        sikeruljmar = 5.5f;

        float osszeadas = sikerulj + sikeruljmar;  //Ezut�n meghat�rozzuk a m�veleteket amit elv�runk t�le
        float kivonas = sikeruljmar - sikerulj;
        float szoras = sikerulj * sikeruljmar;
        float osztas = sikeruljmar / sikerulj;

        Debug.Log(kivonas);                           //A m�velet nev�vel irjuk ki az eredm�nyt 

        int number, number1, number2;

        number = 50; number1 = 29; number2 = 76;

        bool equalityCheck1 = number >= number1;      // bool alap� �rt�khasonlit�s 

        Debug.Log(equalityCheck1);

        int i = 1;
        while (i <= number1)   // Ciklus tipus meghat�roz�sa
        {
            Debug.Log(i);
            i++;   // �rt�k folyamatos n�vel�se (a hurok elker�l�se �rdek�ben)
        }




    }


}
