using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public static UIManager instance;

    [SerializeField] TextMeshProUGUI summonResource;
    [SerializeField] TextMeshProUGUI spellResource;
    [SerializeField] Image summonImage;
    [SerializeField] Image spellImage;
    [SerializeField] Image soulGeneratorImage;
    [SerializeField] Image thunderSpellImage;

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
            summonImage.enabled = true;
            spellImage.enabled = false;
            soulGeneratorImage.enabled = false;
            thunderSpellImage.enabled = false;
        } else if (index == 2) {
            summonImage.enabled = false;
            spellImage.enabled = true;
            soulGeneratorImage.enabled = false;
            thunderSpellImage.enabled = false;
        } else if (index == 3) {
            summonImage.enabled = false;
            spellImage.enabled = false;
            soulGeneratorImage.enabled = true;
            thunderSpellImage.enabled = false;
        } else if (index == 4) {
            summonImage.enabled = false;
            spellImage.enabled = false;
            soulGeneratorImage.enabled = false;
            thunderSpellImage.enabled = true;
        } else 
            Debug.Log("This shouldn't be possible. What did you do?");
    }
}
