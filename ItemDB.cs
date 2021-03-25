using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{

    public Dictionary<string, int> people = new Dictionary<string, int>();

    private void Start()
    {
        people.Add("John", 11);
        people.Add("James", 22);
        people.Add("Rachel", 33);
        people.Add("Yin", 44);

        int rachelsAge = people["Rachel"];

        Debug.Log("age: " + rachelsAge);

    }

}


