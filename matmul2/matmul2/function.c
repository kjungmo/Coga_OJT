#include <stdio.h>
#include <stdlib.h>    // malloc, free �Լ��� ����� ��� ����

int main_a()
{
    int num1 = 20;
    int *numPtr1;
    int **numPP;

    numPtr1 = &num1;
    numPP = &numPtr1;

    int *numPtr2;     // int�� ������ ����

    numPtr2 = malloc(sizeof(int));    // int�� ũ�� 4����Ʈ��ŭ ���� �޸� �Ҵ�

    printf("%p\n", numPtr1);    // 006BFA60: ���� num1�� �޸� �ּ� ���
    // ��ǻ�͸���, ������ ������ �޶���

    printf("%p\n", numPtr2);     // 009659F0: ���� �Ҵ�� �޸��� �ּ� ���
    // ��ǻ�͸���, ������ ������ �޶���

    free(numPtr2);    // �������� �Ҵ��� �޸� ����

    return 0;
}