namespace CSharpPracticeLibrary.Section01HelloWorld.Lesson05MultiLineComments.Exercise03;
public static class MainClass
{
    /*
    the method returns the total price.
    the itemPrice represents the price of the item.
    the quantity represents the quanity (how many are being purchased).
    the value returns is multipliying the price times the quantity.   for example if you purchase 2, its double the price of one.
*/

    public static int GetTotalPrice(int itemPrice, int quantity)
    {
        return itemPrice * quantity;
    }
}