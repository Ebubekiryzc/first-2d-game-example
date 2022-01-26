using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void PlayGame()
    {
        // T�klanm�� butonu yakalamak i�in kullan�lan komut:
        int selectedCharacter =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharacterIndex = selectedCharacter;

        // Ancak bu esnada eski scene de kalan hangi karakter oldu�u bilgisi aktar�lamaz.
        // ��nk� scene ge�i�lerinde unity eski scenedeki variable lar� silmektedir.
        // Bunun �stesinden gelebilmek i�in Singleton pattern kullan�lmaktad�r.
        SceneManager.LoadScene("Gameplay");
    }
}
