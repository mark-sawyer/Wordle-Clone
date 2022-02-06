using UnityEngine;

public static class RowReorderer {
    public static void makeRowLast(int row) {
        string rowName = Constants.SQUARE_ROW_GAMEOBJECT + row;
        GameObject rowGameObject = GameObject.Find(rowName);
        rowGameObject.transform.SetAsLastSibling();
    }
}
