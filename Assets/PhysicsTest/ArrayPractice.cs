
using System.Collections.Generic;
using UnityEngine;

 class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] _arrayFiled;
    [SerializeField] string[] _stringArrayField;
    [SerializeField] Transform[] _transformsField;
    [SerializeField] GameObject[] _gameObjectsField;

    [SerializeField] List<int> _intList;

    void OnValidate()
    {
        for (int i = 0; i < 25; i++)
        {
            _intList.Add(Random.Range(0, 101));
        }
        _intList.Sort();
    }


    void Start()
    {
        // Tömbök
        int[] _arrayOfInts = new int[5];

        for (int i = 0; i < _arrayOfInts.Length; i++)
        {
            int _element = _arrayOfInts[i]; 
            _arrayOfInts[i] = i + 1;


        }
        int _summa = 0;

         foreach ( int _element in _arrayOfInts)
        {
            _summa += _element;
        }

        Transform[] _transforms = new Transform[6];
        Transform[] _transforms1 = FindObjectsOfType<Transform>();
        Transform[] _transforms2 = GetComponentsInChildren<Transform>();
        Transform[] _transforms3 = GetComponentsInParent<Transform>();

        string[] _stringArray = { "AAA", "BBB", "CCC" };
        _stringArray[1] = "DDD";

        // Listák

        List<int> _intList = new List<int>();

        for (int i =0; i < 10; i++)
        {
            _intList.Add(i + 1);
        }
        _intList.RemoveAt(3);
        _intList.Remove(1);
        _summa = 0;
        for (int i = 0; i < _intList.Count; i++)
        {
            _summa += _intList[i];
        }

        List<string> _stringList = new List<string>();
        _stringList.Add("XXXX");
        _stringList.Add("YYY");
        _stringList.Add("ZZ");

        bool _contains = _stringList.Contains("YYY");

        if (_contains)
            Debug.Log("CONTAINS");

        else
            Debug.Log("NOTCOUNTAINS");

        _stringList.Clear();
        int _index =_stringList.IndexOf("ZZ");

        string[] _sa = _stringList.ToArray();
        List<string> _sl = new List<string>(_sa);

        _stringList.Sort();
            
    }

   
}
