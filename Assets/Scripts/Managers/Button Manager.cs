using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelect;
    public void Play()
    {
        levelSelect.SetActive(true);
        mainMenu.SetActive(false);
    }
}
