using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void PlayGame()
    {
        // Týklanmýþ butonu yakalamak için kullanýlan komut:
        int selectedCharacter =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharacterIndex = selectedCharacter;

        // Ancak bu esnada eski scene de kalan hangi karakter olduðu bilgisi aktarýlamaz.
        // Çünkü scene geçiþlerinde unity eski scenedeki variable larý silmektedir.
        // Bunun üstesinden gelebilmek için Singleton pattern kullanýlmaktadýr.
        SceneManager.LoadScene("Gameplay");
    }
}
