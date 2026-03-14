using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public static UIManager instance;

    [SerializeField] TextMeshProUGUI summonResource;
    [SerializeField] TextMeshProUGUI spellResource;
    [SerializeField] Image summonImage;
    [SerializeField] Image spellImage;

    private void Awake() {
        instance = this;
        UpdateSelectedSpell(1);
    }

    public void UpdateResource (int value) {
        summonResource.text = value.ToString(); 
    }

    public void UpdateSpellResource (int value) {
        spellResource.text = value.ToString(); 
    }

    public void UpdateSelectedSpell(int index) {
        if (index == 1) {
            summonImage.color = Color.blue;
            spellImage.color = Color.white;
        } else if (index == 2) {
            summonImage.color = Color.white;
            spellImage.color = Color.blue;
        } else 
            Debug.Log("This shouldn't be possible. What did you do?");
    }
}
