using UnityEngine;

class HelloWorld : MonoBehaviour
{
    void Start()
    {   // szégyeld magad 
        Debug.Log("Hello World?");
        
        Debug.Log("Mi van mi?");
        /* lekvár*/
        int myFirstVariable;
        myFirstVariable = 56;
        myFirstVariable = 47;
        int a, b, c;
        a = 3;
        b = 7;
        c = a + b;
        
        Debug.Log(c);
        c = 11;
        
        Debug.Log(c);
        int d = a - b;
        int e = a * b;
        int f = a / b;
        Debug.Log(f);
        float myFirstFloat = 2.67f;
        float mySecondFloat = 4;
        float ratio = myFirstFloat / mySecondFloat;
        Debug.Log(ratio);

       

        float fff = (float)a / b;
        Debug.Log(fff);

        // Casting
        float f1 = 1;
        int i1 = (int) 2.4f;

 string myFirstString = "Hello ";
        string mySecondString = "World";

        string sss = myFirstString + mySecondString;

        string s1 = $"Hello World { i1}, { ratio}";

        int age = 31;
        float height = 1.89f;
        string myname = "Dávid";

        string introduction = $"My name is {myname}, I'm {height} m height and {age} years old.";
            Debug.Log(introduction);

        int m = 22 % 7;         // 1
        float mf = 12.34f % 5;   // 2.34f

        bool bbb = true;
        bool bbb3 = false;


            
        







    }

}
