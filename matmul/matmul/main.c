#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

struct matrix {
	int rows;
	int columns;
	int m11;
	int m12;
	int m21;
	int m22;
};

int main(void)
{

	//for (int i = 1; i < argc; i++)
	//{
	//	
	//	printf("argv[%d] = %s\n", i, argv[i]);
	//	FILE *fp;
	//	fp = fopen(*argv[i], "r");
	//	//fscanf(fp, "%d %d %d %d %d %d"
	//	if (fp == NULL)
	//	{
	//		printf("파일 %s을 열 수 없습니다.\n", *argv[i]);
	//		exit(1);
	//	}
	//	printf("파일 %s을 열 수 있습니다.\n", *argv[i]);
	//	/*fscanf(fp, "%d %d %d %d %d %d", &m.rows, &m.columns, &m.m11, &m.m12, &m.m21, &m.m22);
	//	printf("A = \n%d %d \n%d %d\n", m.m11, m.m12, m.m21, m.m22);*/

	//	fclose(fp);
	//}

	struct matrix ma;
	FILE *fp_a;
	fp_a = fopen("A.txt", "r");
	int *a = malloc(sizeof(int));
	printf("%d\n", a);
	free(a);
	a = malloc(sizeof(int));
	printf("%d\n", a);
	
	fscanf(fp_a, "%d %d %d %d %d %d", &ma.rows, &ma.columns, &ma.m11, &ma.m12, &ma.m21, &ma.m22);
	printf("A = \n%d %d \n%d %d", ma.m11, ma.m12, ma.m21, ma.m22);
	fclose(fp_a);
	free(a);
	printf("\n");
	
	struct matrix mb;
	FILE *fp_b;
	fp_b = fopen("B.txt", "r");
	fscanf(fp_b, "%d %d %d %d %d %d", &mb.rows, &mb.columns, &mb.m11, &mb.m12, &mb.m21, &mb.m22);
	printf("B = \n%d %d \n%d %d", mb.m11, mb.m12, mb.m21, mb.m22);
	fclose(fp_b);

	printf("\n");

	printf("AB = \n%d %d \n%d %d ", 
		ma.m11*mb.m11+ma.m12*mb.m21, ma.m11*mb.m12+ma.m12*mb.m22,
		ma.m21*mb.m11+ma.m22*mb.m21, ma.m21*mb.m12+ma.m22*mb.m22
		);

	// 행렬 틀 만들기
		// 행 선언
		int **p = (int**)malloc(sizeof(int*) * 행의 개수);
		// 열 선언
		for (int i = 0; i < 행의 개수; i++)
		{
			*(p + i) = (int*)malloc(sizeof(int) * 열의 개수);
		}
	// 행렬에 값을 채우기
		for (int i = 0; i < 행의 개수; i++)
		{
			for (int j = 0; j < 열의 개수; j++)
			{
				*(*(p + i) + j) = i * 행의 개수 + j;
			}
		}
	// 값 출력
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				printf("%d ", *(*(p + i) + j));
			}
			printf("\n");
		}
	return 0;
}

