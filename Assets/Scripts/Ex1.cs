using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    [SerializeField] private int[] intArray;

    private void Start()
    {
        
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log($"{i}");
        }
    }
}
