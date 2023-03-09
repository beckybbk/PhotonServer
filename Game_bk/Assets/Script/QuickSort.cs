using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    int[] data = new[] { 4, 8, 2, 3, 9, 7, 1, 6, 10, 5 };

    void QuickFunction(int[] array, int start, int end)
    {
        int pivot = start;
        int left = pivot + 1;
        int right = end;  // data.Length-1�� �̹� �μ��� (end)�� ���������Ƿ�. 
        // pivot ����, left ����, right ���� �ʿ�
        int temp = 0;
        // temp ���� �ʿ�
        while (left <= right)
        {
            while (left <= end && array[left] < array[pivot])
            {
                left++;
            }

            while (right > start && array[right] > array[pivot])
            {
                right--;
            }

            // + ���� �̵� (left�� end���� �۰ų� ������ &&) + ������ �̵�(right�� start ���� ũ�ٸ� &&)

            if (left > right)
            {
                temp = array[right];
                array[left] = array[pivot];
                array[pivot] = temp;

            }
            else // left�� right ���� �۰ų� ���ٸ� ��� ���� 
            {
                temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
            // + �������� + ������ �ƴҶ� (�Ѵ� �� ����)
        }
    }
    void Start()
    {
        QuickFunction(data, 0, data.Length - 1);
        for(int i=0; i<data.Length; i++) 
        {
            Debug.Log(data[i]);
        }
    }
}
