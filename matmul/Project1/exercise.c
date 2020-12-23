#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	// A.txt의 숫자 읽어오기
	int i, j, k, a[2];
	FILE *f_a;
	f_a = fopen("A.txt", "r");
	// 행과 열을 txt 파일 첫 줄에서 읽어온다 
	for (i = 0; i < 2; i++)
	{
		fscanf(f_a, "%d", &a[i]);
		printf("%d ", a[i]);
	}
	
	printf("\n배열 a의 크기 : %d \n", sizeof(a));
	printf("배열 a의 길이 : %d \n", sizeof(a) / sizeof(int));

	// 행렬 안의 값을 불러옴
	int size_a = a[0] * a[1];

	printf("size_a의 값은? : %d \n", size_a);

	int *num_a = malloc(size_a * sizeof(int));
	if (num_a == NULL)
	{
		printf("malloc error");
	}
	
	printf("\n");
	printf("배열 num_a의 크기 : %d \n", sizeof(num_a));
	printf("배열 num_a의 길이 : %d \n", sizeof(num_a) / sizeof(int));

	// 집합 숫자 할당
	for (j = 2; j < a[0] * a[1] + 2; j++)
	{
		fscanf(f_a, "%d", &num_a[j]);
		printf("%d ", num_a[j]);
	}
	printf("\n num_a 인자들 : %d %d\n", num_a[0], num_a[0]+1);

	printf("\n");
	printf("배열 num_a의 크기 : %d \n", sizeof(num_a));
	printf("배열 num_a의 길이 : %d \n", sizeof(num_a) / sizeof(int));


	free(num_a);


	// 읽어온 정보를 토대로 행렬의 크기를 디자인한다 
	int **mat_a = (int**)malloc(sizeof(int*) * a[0]);
	for (int i = 0; i < a[0]; i++)
	{
		*(mat_a + i) = (int*)malloc(sizeof(int) * a[1]);
	}
	
	free(mat_a);
	fclose(f_a);

	printf("\n");
	// B.txt의 숫자 읽어오기

	int l, m, b[2];
	FILE *f_b;
	f_b = fopen("B.txt", "r");
	// 행과 열을 txt 파일 첫 줄에서 읽어온다 
	for (l = 0; l < 2; l++)
	{
		fscanf(f_b, "%d", &b[l]);
		printf("%d ", b[l]);
	}
	int size_b = b[0] * b[1];
	int *num_b;
	num_b = (int*)malloc(sizeof(int) * size_b);


	for (j = 2; j < b[0] * b[1] + 2; j++)
	{
		fscanf(f_b, "%d", &num_b[j]);
		printf("%d ", num_b[j]);
	}
	//printf("%d %d", b[0], b[1]);

	// 읽어온 정보를 토대로 행렬의 크기를 디자인한다 
	int **mat_b = (int**)malloc(sizeof(int*) * b[0]);
	for (int i = 0; i < b[0]; i++)
	{
		*(mat_b + i) = (int*)malloc(sizeof(int) * b[1]);
	}


	
	fclose(f_b);
	if (a[1] != b[0])
	{
		printf("앞 행렬의 열과 뒤 행렬의 행의 개수가 맞지 않습니다");
	}
	else
	{
		printf("계산 진행합니다.\n");

		int size_mul = a[0] * a[1] * b[1];
		int size_add = a[0] * b[1];
		// 행렬 곱 계산 하는 부분 넣어주기 

		int *num_mul, *num_add;
		num_mul = (int*)malloc(sizeof(int) * size_mul);
		num_add = (int*)malloc(sizeof(int) * size_add);

		// 행렬곱의 값이 저장될 행렬 메모리 할당
		int **matrix = (int**)malloc(sizeof(int*) * a[0]);
		for (i = 0; i < a[0]; i++)
		{
			*(matrix + i) = (int*)malloc(sizeof(int) * b[1]);
		}

		// 완성된 행렬곱의 값을 넣어주기
		for (i = 0; i < a[0]; i++)
		{
			for (j = 0; j < b[1]; j++)
			{
				*(*(matrix + i) + j) = i * a[0] + j;
			}
		}


		// 완성된 행렬곱의 값을 출력해주기
		for (i = 0; i < a[0]; i++)
		{
			for (j = 0; j < b[1]; j++)
			{
				printf("%d ", *(*(matrix+i) + j)); 
			}
			printf("\n");
		}


	}
	return 0;
	
}

 