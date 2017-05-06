
namespace Cryptography.AES
{
    internal class RectangularArrays
    {
        internal static sbyte[][] ReturnRectangularSbyteArray(int rows, int columns)
        {
            sbyte[][] array = new sbyte[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = new sbyte[columns];
            }

            return array;
        }
    }
}
