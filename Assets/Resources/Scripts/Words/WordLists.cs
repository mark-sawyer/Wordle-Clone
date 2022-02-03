
public static class WordLists {
    public static readonly string[] answers;
    public static readonly string[] onlyGuesses;

    static WordLists() {
        answers = WordLoader.getWords(Constants.ANSWERS);
        onlyGuesses = WordLoader.getWords(Constants.ALLOWED_GUESSES);
    }
}
