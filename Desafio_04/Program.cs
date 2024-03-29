﻿// Desafio
// Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.

// Entrada
// A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.

// Saída
// A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.

// Exemplo 1
// Entrada
// 3
// 7
// 5
// 7	
// Saída
// 7

// Exemplo 2
// Entrada	
// 9
// 2
// 1
// 1
// 1
// 2
// 2
// 2
// 1
// 2
// Saída
// 2


class DIO_4
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));

    }
    public static int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        int major = nums[0];
        int count = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                major = nums[i];
                count = 1;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                    if (count > (nums.Length / 2))
                    {
                        return major;
                    }
                }
            }
        }
        major = 0;
        return major;
    }
}