#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>



int matmul(int **a, int **b);

int main(int argc, char *argv[])
{
	
	// 명령행 인자의 개수가 2개인 경우
	if (argc < 3)
	{
		//TODO
		// 행렬인자가 1개인 경우
	}

	// 명령행 인자가 4개 이상인 경우
	else if (argc >= 4)
	{
		//TODO 
		//행렬인자가 3개 이상인 경우
	}

	// 명령행 인자가 3개인 경우
	else
	{
		
		int row, col, i, j, k, l;

		// 명령행 인자로 들어오는 파일들로부터 함수 값 출력

		for (int i = 0; i + 1 < argc; i++)
		{
			FILE *f = fopen(argv[i + 1], "r");
			fscanf(f, "%d%d", &row, &col);
			//printf("%d %d\n", row, col);

			// 행렬 메모리 할당
			//int **mat;
			//*mat + i = (int**)malloc((sizeof(int*)) * row);

			int **mat = (int**)malloc((sizeof(int*)) * row);
			*mat = *mat + (i * row * col);

			for (j = 0; j < row; j++)
			{
				*(mat + j) = (int*)malloc(sizeof(int) * col);
			}

			char *sliced = strtok(argv[ i + 1 ], ".");
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

			matmul(mat, mat * 4);

		}
		
		
		
		
		
		
		//int row_a, col_a, row_b, col_b, i, j, k;


		//// A.txt의 숫자 읽어오기

		//FILE *f_a;
		//f_a = fopen(argv[1], "r");
		//fscanf(f_a, "%d %d", &row_a, &col_a);

		//// 행렬 메모리 할당
		//int **mat_a = (int**)malloc((sizeof(int*)) * row_a);
		//for (i = 0; i < row_a; i++)
		//{
		//	*(mat_a + i) = (int*)malloc(sizeof(int) * col_a);
		//}

		//char *filenameA[10] = { NULL };
		//char *slicedA = strtok(argv[1], ".");
		//printf("%s = \n", slicedA);

		////행렬 값 넣어서 출력
		//for (i = 0; i < row_a; i++)
		//{
		//	for (j = 0; j < col_a; j++)
		//	{
		//		fscanf(f_a, "%d", *(mat_a + i) + j);
		//		printf("%d ", *(*(mat_a + i) + j));
		//	}
		//	printf("\n");
		//}
		//printf("\n");
		//fclose(f_a);

		////B.txt의 숫자 읽어오기

		//FILE *f_b;
		//f_b = fopen(argv[2], "r");
		//fscanf(f_b, "%d %d", &row_b, &col_b);

		//// 행렬 메모리 할당
		//int **mat_b = (int**)malloc((sizeof(int*)) * row_b);
		//for (i = 0; i < row_b; i++)
		//{
		//	*(mat_b + i) = (int*)malloc(sizeof(int) * col_b);
		//}

		//char *filenameB[10] = { NULL };
		//char *slicedB = strtok(argv[2], ".");
		//printf("%s = \n", slicedB);


		////행렬 값 넣어서 출력
		//for (i = 0; i < row_b; i++)
		//{
		//	for (j = 0; j < col_b; j++)
		//	{
		//		fscanf(f_b, "%d", *(mat_b + i) + j);
		//		printf("%d ", *(*(mat_b + i) + j));
		//	}
		//	printf("\n");
		//}
		//printf("\n");
		//fclose(f_b);

		//// 행렬곱 불가 디버그
		//if (col_a != row_b)
		//{
		//	printf("행렬곱 계산이 불가합니다.");
		//	exit(-1);
		//}

		////AB 행렬 메모리 할당
		//int **matAB;
		//matAB = (int**)malloc(sizeof(int*) * row_a);

		//for (i = 0; i < row_a; i++)
		//{
		//	*(matAB + i) = (int*)malloc(sizeof(int) * col_b);
		//}

		////행렬 값을 넣어줌
		//for (i = 0; i < row_a; i++)
		//{
		//	for (j = 0; j < col_b; j++)
		//	{
		//		int sum = 0;
		//		for (k = 0; k < col_a; k++)
		//		{
		//			int mul = (*(*(mat_a + i) + k)) * (*(*(mat_b + k) + j));
		//			sum += mul;
		//		}
		//		(*(*(matAB + i) + j)) = sum;

		//	}
		//}

		////행렬 출력
		//printf("AB = \n");
		//for (i = 0; i < row_a; i++)
		//{
		//	for (j = 0; j < col_b; j++)
		//	{
		//		printf("%d ", *(*(matAB + i) + j));
		//	}
		//	printf("\n");
		//}

	}
	
	////////////////////////////////////////////////////////////////
	
	//int row, col, i, j, k, l;

	//// 명령행 인자로 들어오는 파일들로부터 함수 값 출력
	//
	//for (int i = 0; i + 1 < argc; i++)
	//{
	//	FILE *f  = fopen(argv[i + 1], "r");
	//	fscanf(f, "%d%d", &row, &col);
	//	//printf("%d %d\n", row, col);

	//	// 행렬 메모리 할당
	//	//int **mat;
	//	//*mat + i = (int**)malloc((sizeof(int*)) * row);

	//	int **mat = (int**)malloc((sizeof(int*)) * row);
	//	*mat = *mat + (i * row * col);

	//	for (j = 0; j < row; j++)
	//	{
	//		*(mat + j) = (int*)malloc(sizeof(int) * col);
	//	}
 //
	//	char *sliced = strtok(argv[i], ".");
	//	printf("%s = \n", sliced);

	//	//행렬 값 넣어서 출력
	//	for (k = 0; k < row; k++)
	//	{
	//		for (l = 0; l < col; l++)
	//		{
	//			fscanf(f, "%d", *(mat + k) + l);
	//			printf("%d ", *(*(mat + k) + l));
	//		}
	//		printf("\n");
	//	}
	//	printf("\n");
	//	fclose(f);
	//	

	//}



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
