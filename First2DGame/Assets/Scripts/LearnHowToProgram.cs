using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnHowToProgram : MonoBehaviour
{
    void Start()
    {
        // Coroutines: Delaylenmiþ iþlemler için kullanýlýr.
        // Oyunumda bir þey olduðunda baþka bir þeyin olmasýný tetiklemek için kullanýlabilir.
        // Örneðin bir boss odasýna girdiðin anda bossun spawnlanmasýný istemeyiz. Belli bir süre sonra gelsin istersek kullanýlabilir.

        // Bir çalýþtýrma yöntemi bu þekilde:
        // StartCoroutine(ExecuteSomething());

        // Bir diðeri ise bu þekildedir:
        StartCoroutine("ExecuteSomething");

        // Farký string ile yazýlaný yine string ile yazarak durdurabiliyor olmamýzdýr.
        StopCoroutine("ExecuteSometing");
    }

    IEnumerator ExecuteSomething()
    {
        // Ýki saniye boyunca burada dursun daha sonra alttaki koda geçip çalýþtýrsýn gibi iþliyor.
        // Parametre de alabilirler.
        yield return new WaitForSeconds(2f);

        Debug.Log("Something is executed");

        yield return new WaitForSeconds(2f);

        Debug.Log("Birden fazla da kullanýlabilir.");
    }
}
