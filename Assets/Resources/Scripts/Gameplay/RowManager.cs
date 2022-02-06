
public static class RowManager {
    private static int currentRow = 1;

    public static void initialiseRowManager() {
        GameEvents.revealComplete.AddListener(incrementRow);
    }

    public static int getRow() {
        return currentRow;
    }

    private static void incrementRow() {
        currentRow++;
    }

    public static void resetRow() {
        currentRow = 1;
    }
}
