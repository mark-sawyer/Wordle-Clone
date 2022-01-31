
public static class WordComparer {
    public static LetterColour[] compareWords(string answer, string guess) {
        LetterColour[] outcome = new LetterColour[5];
        int guessPos = 0;

        foreach (char guessLetter in guess) {
            outcome[guessPos] = getCharOutcome(guessLetter, guessPos, guess, answer);
            guessPos++;
        }

        return outcome;
    }

    private static LetterColour getCharOutcome(char guessLetter, int guessPos, string guess, string answer) {
        LetterColour outcome = LetterColour.GREY;
        int answerPos = 0;

        foreach (char answerLetter in answer) {
            if (isGreen(guessLetter, guessPos, answerLetter, answerPos)) {
                outcome = LetterColour.GREEN;
                break;
            }
            else if (isYellowSoFar(guessLetter, answerLetter, answerPos, guess, answer)) {
                outcome = LetterColour.YELLOW;
            }

            answerPos++;
        }

        return outcome;
    }

    private static bool isGreen(char guessLetter, int guessPos, char answerLetter, int answerPos) {
        return (guessLetter == answerLetter) && (guessPos == answerPos);
    }

    private static bool isYellowSoFar(char guessLetter, char answerLetter, int answerPos, string guess, string answer) {
        return (guessLetter == answerLetter) && (answer[answerPos] != guess[answerPos]);
    }
}
