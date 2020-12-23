#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	// A.txt의 숫자 읽어오기
	int a1, a2, b1, b2, i, j, k;
	FILE *f_a;

	f_a = fopen("A.txt", "r");
	fscanf(f_a, "%d %d", &a1, &a2);
	printf("%d X %d 행렬 \n", a1, a2);

	// 행렬 메모리 할당
	int **mat_a = (int**)malloc((sizeof(int*)) * a1);
	for (i = 0; i < a1; i++)
	{
		*(mat_a + i) = (int*)malloc(sizeof(int) * a2);
	}

	//행렬 값을 넣어줌
	for (i = 0; i < a1; i++)
	{
		for (j = 0; j < a2; j++)
		{
			fscanf(f_a, "%d", *(mat_a + i) + j);
			printf("%d", *(*(mat_a + i) + j));
		}
	}
	printf("\n");

	return 0;
}