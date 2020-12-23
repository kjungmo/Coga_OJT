#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	// A.txt의 숫자 읽어오기
	int row_a, col_a, row_b, col_b, i, j;
	FILE *f_a;

	f_a = fopen("A.txt", "r");
	fscanf(f_a, "%d %d", &row_a, &col_a);
	printf("%d X %d 행렬 \n", row_a, col_a);

	// 행렬 메모리 할당
	int **mat_a = (int**)malloc((sizeof(int*)) * row_a);
	for (i = 0; i < row_a; i++)
	{
		*(mat_a + i) = (int*)malloc(sizeof(int) * col_a);
	}

	//행렬 값을 넣어줌
	for (i = 0; i < row_a; i++)
	{
		for (j = 0; j < col_a; j++)
		{
			fscanf(f_a, "%d", *(mat_a + i) + j);
			printf("%d", *(*(mat_a + i) + j));
		}
		printf("\n");
	}
	printf("\n");

	// B.txt의 숫자 읽어오기
	FILE *f_b;

	f_b = fopen("B.txt", "r");
	fscanf(f_b, "%d %d", &row_b, &col_b);
	printf("%d X %d 행렬 \n", row_b, col_b);

	// 행렬 메모리 할당
	int **mat_b = (int**)malloc((sizeof(int*)) * row_b);
	for (i = 0; i < row_b; i++)
	{
		*(mat_b + i) = (int*)malloc(sizeof(int) * col_b);
	}

	//행렬 값을 넣어줌
	for (i = 0; i < row_b; i++)
	{
		for (j = 0; j < col_b; j++)
		{
			fscanf(f_b, "%d", *(mat_b + i) + j);
			printf("%d", *(*(mat_b + i) + j));
		}
		printf("\n");
	}
	printf("\n");


	if (col_a != row_b)
	{
		printf("행렬곱 계산이 불가합니다.");
		exit(-1);
	}
	//AB 행렬 메모리 할당
	int **matAB;
	matAB = (int**)malloc(sizeof(int*) * row_a);

	for (i = 0; i < row_a; i++)
	{
		*(matAB + i) = (int*)malloc(sizeof(int) * col_b);
	}

	//행렬 값을 넣어줌
	for (i = 0; i < row_a; i++)
	{
		for (j = 0; j < col_b; j++)
		{
			//*(*(matAB + i) + j) = i * row_a + j;
			*(*(matAB + i) + j) =
				(*(*(mat_a + i))) * (*(*(mat_b) + j)) +
				(*(*(mat_a + i) + 1)) * (*(*(mat_b + 1) + j));
				
			//	행렬 곱셈을 넣어주자;
		}
	}

	//행렬 출력
	for (i = 0; i < row_a; i++)
	{
		for (j = 0; j < col_b; j++)
		{
			printf("%d", *(*(matAB + i) + j));
		}
		printf("\n");
	}

	return 0;
}