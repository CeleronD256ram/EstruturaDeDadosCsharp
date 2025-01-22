namespace EstruturaDeDadosCsharp.ordenacao;

public class SelectionSort
{
    public static void OrdenarSelection(double[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int menorElemento = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[menorElemento] > array[j])
                {
                    menorElemento = j;
                }
            }

            double temp = array[i];
            array[i] = array[menorElemento];
            array[menorElemento] = temp;
        }
    }
}