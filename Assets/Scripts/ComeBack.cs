using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComeBack : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ExampleCoroutine());

    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuScene");
    }
}
