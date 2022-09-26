using UnityEngine;

public class HáziFeladat2 : MonoBehaviour
{
    //A2/es Feladat

    [SerializeField] int c;
    [SerializeField] float d;

    [SerializeField] float summa;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float quotient;
    void OnValidate()
    {
        summa = c + d;
        difference = c- d;
        product = c * d;
        quotient = c / d;
    }
}
    

