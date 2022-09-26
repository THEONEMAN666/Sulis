using UnityEngine;

class  BoolPractice : MonoBehaviour
{

    [SerializeField] float A, B;
    [SerializeField] float sum, difference, product, rate;

    void OnValidate()
    {
        float sum = A + B;
        float difference = A - B;
        float product = A * B;
        float rate = A / B;
    }


}
