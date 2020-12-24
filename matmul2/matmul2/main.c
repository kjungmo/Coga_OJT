#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>



int matmul(int **a, int **b);

int main(int argc, char *argv[])
{

	int row, col, i, j, k, l;

	// 명령행 인자로 들어오는 파일들로부터 함수 값 출력
	
	for (int i = 1; i < argc; i++)
	{
		FILE *f = fopen(argv[i], "r");
		fscanf(f, "%d%d", &row, &col);
		//printf("%d %d\n", row, col);

		// 행렬 메모리 할당
		int **mat = (int**)malloc((sizeof(int*)) * row);
		for (j = 0; j < row; j++)
		{
			*(mat + j) = (int*)malloc(sizeof(int) * col);
		}
 
		char *sliced = strtok(argv[i], ".");
		printf("%s = \n", sliced);

		//행렬 값 넣어서 출력
		for (k = 0; k < row; k++)
		{
			for (l = 0; l < col; l++)
			{
				fscanf(f, "%d", *(mat + k) + l);
				printf("%d ", *(*(mat + k) + l));
			}
			printf("\n");
		}
		printf("\n");
		fclose(f);
		

	}



	return 0;
}

// 행렬을 인자로 받아서 새로운 행렬을 만드는 함수
int matmul(int **a, int **b)
{
	int row = sizeof(a) / sizeof(a[0]);
	int col = sizeof(b[0]) / sizeof(int);

	int **matAB = (int**)malloc(sizeof(int*) * row);
	for (int i = 0; i < row; i++)
	{
		*(matAB + i) = (int*)malloc(sizeof(int) * col);
	}

	// 함수에 값으로는 입력 인자로 들어온 행렬의 곱 
	//TODO

	return matAB;
}
