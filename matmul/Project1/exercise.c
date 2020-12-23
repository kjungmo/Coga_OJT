#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	// A.txt의 숫자 읽어오기
	int i, j, a[2];
	FILE *f_a;
	f_a = fopen("A.txt", "r");
	// 행과 열을 txt 파일 첫 줄에서 읽어온다 
	for (i = 0; i < 2; i++)
	{
		fscanf(f_a, "%d", &a[i]);
		printf("%d ", a[i]);
	}
	int size_a = a[0] * a[1];
	int *num_a;
	num_a = (int*)malloc(sizeof(int) * size_a);


	for (j = 2; j < a[0] * a[1] + 2; j++)
	{
		fscanf(f_a, "%d", &num_a[j]);
		printf("%d ", num_a[j]);
	}
	//printf("%d %d", a[0], a[1]);
	
	// 읽어온 정보를 토대로 행렬의 크기를 디자인한다 
	int **mat_a = (int**)malloc(sizeof(int*) * a[0]);
	for (int i = 0; i < a[0]; i++)
	{
		*(mat_a + i) = (int*)malloc(sizeof(int) * a[1]);
	}

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
}

 