
public static class WordLists {
    public static readonly string[] answers;
    public static readonly string[] guesses;

    static WordLists() {
        answers = WordLoader.getWords(Constants.ANSWERS);
        guesses = WordLoader.getWords(Constants.ALLOWED_GUESSES);
    }
}
