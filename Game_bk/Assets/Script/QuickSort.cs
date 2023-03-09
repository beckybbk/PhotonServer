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
        int right = end;  // data.Length-1이 이미 인수로 (end)로 정해졌으므로. 
        // pivot 변수, left 변수, right 변수 필요
        int temp = 0;
        // temp 변수 필요
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

            // + 왼쪽 이동 (left가 end보다 작거나 같으면 &&) + 오른쪽 이동(right가 start 보다 크다면 &&)

            if (left > right)
            {
                temp = array[right];
                array[left] = array[pivot];
                array[pivot] = temp;

            }
            else // left가 right 보다 작거나 같다면 계속 진행 
            {
                temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
            // + 엇갈릴때 + 엇갈림 아닐때 (둘다 값 스왑)
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
