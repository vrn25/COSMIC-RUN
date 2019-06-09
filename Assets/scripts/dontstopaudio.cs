using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontstopaudio : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
