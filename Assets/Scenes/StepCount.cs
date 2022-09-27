
using UnityEngine;

public class StepCount : MonoBehaviour
{
    [SerializeField] Vector2 a, b;
    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;


    private void OnValidate()
    {
        stepCount = Mathf.CeilToInt(Vector2.Distance(a, b)); // 1 egységnyi lépés, önnállóan alakít int-be
        step = (b - a) / stepCount; // lépések számának meghatározása


    }
}
