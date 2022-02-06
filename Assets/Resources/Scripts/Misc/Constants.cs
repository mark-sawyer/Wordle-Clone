using UnityEngine;

public static class Constants {
    public static readonly string ALLOWED_GUESSES = "wordle-allowed-guesses.txt";
    public static readonly string ANSWERS = "wordle-answers-alphabetical.txt";

    public static readonly string GREEN_SPRITE_ADDRESS = "Sprites/Letter Colours/green";
    public static readonly string YELLOW_SPRITE_ADDRESS = "Sprites/Letter Colours/yellow";
    public static readonly string GREY_SPRITE_ADDRESS = "Sprites/Letter Colours/grey";
    public static readonly string BLANK_SPRITE_ADDRESS = "Sprites/Letter Colours/blank";

    public static readonly string GREEN_LETTER_SPRITE_ADDRESS = "Sprites/Screen Keys/letter_green";
    public static readonly string YELLOW_LETTER_SPRITE_ADDRESS = "Sprites/Screen Keys/letter_yellow";
    public static readonly string GREY_LETTER_SPRITE_ADDRESS = "Sprites/Screen Keys/letter_grey";
    public static readonly string NORMAL_LETTER_SPRITE_ADDRESS = "Sprites/Screen Keys/letter";

    public static readonly string MANAGER_GAMEOBJECT = "manager";
    public static readonly string SQUARE_ROW_GAMEOBJECT = "square_row_";

    public static readonly int NUMBER_OF_LETTERS = 5;
    public static readonly int NUMBER_OF_ROWS = 6;
    public static readonly float ANGLE_CHANGE_PER_FRAME = 90f / 16f;
    public static readonly float ERROR_WOBBLE_SECONDS = 0.5f;
    public static readonly float VICTORY_WOBBLE_SECONDS = 1.35f;
    public static readonly float BULGE_FACTOR = 1.16f;

    public static readonly KeyCode NEW_GAME_KEY = KeyCode.KeypadMinus;

    public static readonly char[] LETTERS = new char[26] {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    };
}
