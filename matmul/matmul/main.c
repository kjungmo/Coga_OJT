#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>





int main(int argc, char *argv[])
{

	if (argc == 3)
	{
		int row_a, col_a, row_b, col_b, i, j, k;


		// A.txt의 숫자 읽어오기

		FILE *f_a;
		f_a = fopen(argv[1], "r");
		fscanf(f_a, "%d %d", &row_a, &col_a);

		// 행렬 메모리 할당
		int **mat_a = (int**)malloc((sizeof(int*)) * row_a);
		for (i = 0; i < row_a; i++)
		{
			*(mat_a + i) = (int*)malloc(sizeof(int) * col_a);
		}

		char *filenameA[10] = { NULL };
		char *slicedA = strtok(argv[1], ".");
		printf("%s = \n", slicedA);

		//행렬 값 넣어서 출력
		for (i = 0; i < row_a; i++)
		{
			for (j = 0; j < col_a; j++)
			{
				fscanf(f_a, "%d", *(mat_a + i) + j);
				printf("%d ", *(*(mat_a + i) + j));
			}
			printf("\n");
		}
		printf("\n");
		fclose(f_a);

		//B.txt의 숫자 읽어오기

		FILE *f_b;
		f_b = fopen(argv[2], "r");
		fscanf(f_b, "%d %d", &row_b, &col_b);

		// 행렬 메모리 할당
		int **mat_b = (int**)malloc((sizeof(int*)) * row_b);
		for (i = 0; i < row_b; i++)
		{
			*(mat_b + i) = (int*)malloc(sizeof(int) * col_b);
		}

		char *filenameB[10] = { NULL };
		char *slicedB = strtok(argv[2], ".");
		printf("%s = \n", slicedB);


		//행렬 값 넣어서 출력
		for (i = 0; i < row_b; i++)
		{
			for (j = 0; j < col_b; j++)
			{
				fscanf(f_b, "%d", *(mat_b + i) + j);
				printf("%d ", *(*(mat_b + i) + j));
			}
			printf("\n");
		}
		printf("\n");
		fclose(f_b);

		// 행렬곱 불가 디버그
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
				int sum = 0;
				for (k = 0; k < col_a; k++)
				{
					int mul = (*(*(mat_a + i) + k)) * (*(*(mat_b + k) + j));
					sum += mul;
				}
				(*(*(matAB + i) + j)) = sum;

			}
		}

		//행렬 출력
		printf("AB = \n");
		for (i = 0; i < row_a; i++)
		{
			for (j = 0; j < col_b; j++)
			{
				printf("%d ", *(*(matAB + i) + j));
			}
			printf("\n");
		}

	}



	return 0;
}