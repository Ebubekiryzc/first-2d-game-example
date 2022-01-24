using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnHowToProgram : MonoBehaviour
{
    void Start()
    {
        // Coroutines: Delaylenmi� i�lemler i�in kullan�l�r.
        // Oyunumda bir �ey oldu�unda ba�ka bir �eyin olmas�n� tetiklemek i�in kullan�labilir.
        // �rne�in bir boss odas�na girdi�in anda bossun spawnlanmas�n� istemeyiz. Belli bir s�re sonra gelsin istersek kullan�labilir.

        // Bir �al��t�rma y�ntemi bu �ekilde:
        // StartCoroutine(ExecuteSomething());

        // Bir di�eri ise bu �ekildedir:
        StartCoroutine("ExecuteSomething");

        // Fark� string ile yaz�lan� yine string ile yazarak durdurabiliyor olmam�zd�r.
        StopCoroutine("ExecuteSometing");
    }

    IEnumerator ExecuteSomething()
    {
        // �ki saniye boyunca burada dursun daha sonra alttaki koda ge�ip �al��t�rs�n gibi i�liyor.
        // Parametre de alabilirler.
        yield return new WaitForSeconds(2f);

        Debug.Log("Something is executed");

        yield return new WaitForSeconds(2f);

        Debug.Log("Birden fazla da kullan�labilir.");
    }
}
