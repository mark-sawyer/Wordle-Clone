
public static class WordLoader {
    public static string[] getWords(string fileName) {
        string beginning = "Assets\\Resources\\Words\\";
        string full = beginning + fileName;
        string[] wordList = System.IO.File.ReadAllLines(full);
        return wordList;
    }
}
