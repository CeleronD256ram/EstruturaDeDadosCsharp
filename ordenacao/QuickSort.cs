namespace EstruturaDeDadosCsharp.ordenacao;

public class QuickSort
{
    public static void OrdenarQuickSort(int[] array, int esquerda, int direita)
    {
        //verifica se ainda existem itens para ordenar
        if (esquerda < direita)
        {
            int indicePivo = Particionar(array, esquerda, direita);

            //Ordena recursivamente os itens á esquerda do pivô
            if (indicePivo > 1)
            {
                OrdenarQuickSort(array, esquerda, indicePivo - 1);
            }

            //Agora os itens da direita
            if (indicePivo + 1 < direita)
            {
                OrdenarQuickSort(array, indicePivo + 1, direita);
            }
        }
    }

    //Particionar o array em relação ao pivô
    private static int Particionar(int[] array, int esquerda, int direita)
    {
        // escolhe o primeiro elemento como pivô
        int pivo = array[esquerda];

        // faz o particionamento enquanto os índices não se cruzam
        while (true)
        {
            // move o índice da esquerda até achar um valor maior ou igual ao pivô
            while (array[esquerda] < pivo)
            {
                esquerda++;
            }

            while (array[direita] > pivo)
            {
                direita--;
            }

            //confere se os índices não se cruzam
            if (esquerda < direita)
            {
                //se os valores forem iguais, retorna o índice da direita
                if (array[esquerda] == array[direita]) return direita;


                //troca os valores encontrados nos indices esquedo e direito
                int aux = array[esquerda];
                array[esquerda] = array[direita];
                array[direita] = aux;

            }
            else
            {
                return direita;
            }
        }
    }
}