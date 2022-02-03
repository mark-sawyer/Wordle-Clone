
public static class RowManager {
    private static int currentRow = 1;

    public static int getRow() {
        return currentRow;
    }

    public static void incrementRow() {
        currentRow++;
    }

    public static void resetRow() {
        currentRow = 1;
    }
}
