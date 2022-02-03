using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnswerHolder {
    private static string answer;

    public static void getNewAnswer() {
        answer = WordRandomiser.getRandomWord(WordLists.answers);
    }

    public static string getAnswer() {
        return answer;
    }
}
