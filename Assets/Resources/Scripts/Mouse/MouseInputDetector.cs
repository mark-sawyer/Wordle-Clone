using UnityEngine;

public static class MouseInputDetector {
    public static KeyCode returnMouseInput() {
        if (!Input.GetMouseButtonDown(0)) return KeyCode.None;

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D ray = Physics2D.Raycast(mousePos, Vector2.zero, 0f);

        if (ray.collider == null) return KeyCode.None;

        GameObject screenKey = ray.collider.gameObject;
        KeyCode key = ScreenKeyToKeyCode.getKeyCode(screenKey);
        return key;
    }
}
