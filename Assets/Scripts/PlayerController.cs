using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
    [SerializeField] PlayerUnitSpawner spawner;
    [SerializeField] SpellLauncher spellLauncher;

    private int selectedSpell = 1;

    private void OnPrevious() {
        selectedSpell = 1;
        UIManager.instance.UpdateSelectedSpell(1);
    }

    private void OnNext() {
        selectedSpell = 2;
        UIManager.instance.UpdateSelectedSpell(2);
    }

    private void OnThree() {
        selectedSpell = 3;
        UIManager.instance.UpdateSelectedSpell(3);
    }

    private void OnFour() {
        selectedSpell = 4;
        UIManager.instance.UpdateSelectedSpell(4);
    }

    private void Update() {
       if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame) {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            if (selectedSpell == 1)
                spawner.SpawnUnit(worldPos);
            else if (selectedSpell == 2)
                spellLauncher.LaunchSpell(worldPos);
            else if (selectedSpell == 3)
                spawner.SpawnSoulGenerator(worldPos);
            else if (selectedSpell == 4)
                spellLauncher.LaunchThunderSpell(worldPos);
            else 
                Debug.Log("This shouldn't be possible. What did you do?");
        } 
    }
}
