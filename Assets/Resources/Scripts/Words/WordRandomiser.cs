using System;

public static class WordRandomiser {
    private static Random random = new Random();

    public static string getRandomWord(string[] wordList) {
        int listLength = wordList.Length;
        int index = random.Next(listLength);
        string randomWord = wordList[index];
        return randomWord;
    }
}
