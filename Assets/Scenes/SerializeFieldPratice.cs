
using UnityEngine;

public class SerializeFieldPratice : MonoBehaviour
{
    [SerializeField] int age;
    [SerializeField] float heiht;
    [SerializeField] string myName;
    [SerializeField] bool smoking;

    [SerializeField] int number1, number2;
    [SerializeField] int sum;
    [SerializeField] int difference;
    [SerializeField] int product;
    [SerializeField] float rate;

    


    void Start()
    {
        int i;
        
        
    }

     void OnValidate()
    {
        sum = number1 + number2;
        difference = number1 - number2;
        product = number1 * number2;
        rate = (float) number1 / number2;

    }



}
