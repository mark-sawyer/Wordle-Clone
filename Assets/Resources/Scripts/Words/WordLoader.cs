using UnityEngine;

public static class WordLoader {
    public static string[] getWords(string wordsToLoad) {
        string words = Resources.Load<TextAsset>("Words/" + wordsToLoad).ToString();
        int numberOfWords = (words.Length + 1) / 6;
        string[] wordList = new string[numberOfWords];

        int start;
        for (int i = 0; i < numberOfWords; i++) {
            start = i * 6;
            wordList[i] = words.Substring(start, Constants.NUMBER_OF_LETTERS);
        }

        return wordList;
    }
}
