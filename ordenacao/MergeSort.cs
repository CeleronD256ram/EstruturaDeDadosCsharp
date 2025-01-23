namespace EstruturaDeDadosCsharp.ordenacao;

public class MergeSort
{
    public static void Msort(int[] array, int[] temp, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int meio = (inicio + fim) / 2;

            Msort(array, temp, inicio, meio);
            Msort(array, temp, meio + 1, fim);

            Mesclar(array, temp, inicio, meio, fim);
        }
    }

    public static void Mesclar(int[] array, int[] temp, int inicio, int meio, int fim)
    {
        for (int i = inicio; i <= fim; i++)
        {
            temp[i] = array[i];

        }
        
        int esquerda = inicio;
        int direita = meio + 1;

        for (int i = inicio; i <= fim; i++)
        {
            if (esquerda > direita)
            {
                array[i] = temp[direita++];
            }
            else if (direita > fim)
            {
                array[i] = temp[esquerda++];
            }
            else if (temp[esquerda] < temp[direita])
            {
                array[i] = temp[esquerda++];
            }
            else
            {
                array[i] = temp[direita++];
            }
            
        }



    }
    
}