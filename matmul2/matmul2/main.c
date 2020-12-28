#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>



//int matmul(int **a, int **b);

void createMatrix(char *argv[])
{
	int row, col, i, j, k;

	FILE *f = fopen(argv, "r");
	fscanf(f, "%d%d", &row, &col);
	printf("%d X %d sized Matrix\n", row, col);

	int **mat = (int**)malloc((sizeof(int*) * row));

	for (i = 0; i < row; i++)
	{
		*(mat + i) = (int*)malloc(sizeof(int) * col);
	}

	char *sliced = strtok(argv, ".");
	printf("%s = \n", sliced);

	for (j = 0; j < row; j++)
	{
		for (k = 0; k < col; k++)
		{
			fscanf(f, "%d", *(mat + j) + k);
			printf("%d ", *(*(mat + j) + k));
		}
		printf("\n");
	}
	printf("sizeof(mat) : %i\n", sizeof(mat)); 
	printf("sizeof(*mat) : %i\n", sizeof(*mat)); //8
	printf("sizeof(**mat) : %i\n", sizeof(**mat)); //4

	printf("&mat : %p\n", &mat);
	printf("&*mat : %p\n", &*mat);
	printf("&**mat : %p\n", &**mat);

	free(mat); // temporary ( planning to make a function for free() )
}

int main(int argc, char *argv[])
{
	
	// 
	if (argc < 3)
	{

		printf("Error. \n");

	}

	else if (argc = 3)
	{

		int row, col, i, j, k, l;

		for (int i = 0; i + 1 < argc; i++)
		{
			createMatrix(argv[i + 1]); // only using a function
			
			printf("\n");



		}



	}


	///////===================/////////////// erase

	// if more than 3 command line arguments (more than 2 matrix text files)
	//else if (argc = 3)
	//{

	//	int row, col, i, j, k, l;

	//	for (int i = 0; i + 1 < argc; i++)
	//	{
	//		FILE *f = fopen(argv[i + 1], "r");
	//		fscanf(f, "%d%d", &row, &col);

	//		// allocate memory for Matrix
	//		//int **mat;
	//		//*mat + i = (int**)malloc((sizeof(int*)) * row);

	//		int **mat = (int**)malloc((sizeof(int*)) * row);
	//		//*mat = *(mat + (i * row * col));
	//		
	//		for (j = 0; j < row; j++)
	//		{
	//			*(mat + j) = (int*)malloc(sizeof(int) * col);
	//		}

	//		char *sliced = strtok(argv[i + 1], ".");
	//		printf("%s = \n", sliced);

	//		//print values
	//		for (k = 0; k < row; k++)
	//		{
	//			for (l = 0; l < col; l++)
	//			{
	//				fscanf(f, "%d", *(mat + k) + l);
	//				printf("%d ", *(*(mat + k) + l));
	//			}
	//			printf("\n");
	//		}
	//		printf("\n");
	//		
	//		printf("sizeof(mat) : %i\n", sizeof(mat)); //8(64bit)
	//		printf("sizeof(*mat) : %i\n", sizeof(*mat)); //8
	//		printf("sizeof(**mat) : %i\n", sizeof(**mat)); //4

	//		printf("&mat : %p\n", &mat);
	//		printf("&*mat : %p\n", &*mat);
	//		printf("&**mat : %p\n", &**mat);

	//		free(mat);
	//		fclose(f);

	//		/*matmul(mat, mat * 4);*/

	//	}






	//	//int row_a, col_a, row_b, col_b, i, j, k;


	//	//// read values from A.txt

	//	//FILE *f_a;
	//	//f_a = fopen(argv[1], "r");
	//	//fscanf(f_a, "%d %d", &row_a, &col_a);

	//	//// allocate memory for Matrix
	//	//int **mat_a = (int**)malloc((sizeof(int*)) * row_a);
	//	//for (i = 0; i < row_a; i++)
	//	//{
	//	//	*(mat_a + i) = (int*)malloc(sizeof(int) * col_a);
	//	//}

	//	//char *filenameA[10] = { NULL };
	//	//char *slicedA = strtok(argv[1], ".");
	//	//printf("%s = \n", slicedA);

	//	////print values
	//	//for (i = 0; i < row_a; i++)
	//	//{
	//	//	for (j = 0; j < col_a; j++)
	//	//	{
	//	//		fscanf(f_a, "%d", *(mat_a + i) + j);
	//	//		printf("%d ", *(*(mat_a + i) + j));
	//	//	}
	//	//	printf("\n");
	//	//}
	//	//printf("\n");
	//	//fclose(f_a);

	//	//// read values from B.txt

	//	//FILE *f_b;
	//	//f_b = fopen(argv[2], "r");
	//	//fscanf(f_b, "%d %d", &row_b, &col_b);

	//	//// allocate memory for Matrix
	//	//int **mat_b = (int**)malloc((sizeof(int*)) * row_b);
	//	//for (i = 0; i < row_b; i++)
	//	//{
	//	//	*(mat_b + i) = (int*)malloc(sizeof(int) * col_b);
	//	//}

	//	//char *filenameB[10] = { NULL };
	//	//char *slicedB = strtok(argv[2], ".");
	//	//printf("%s = \n", slicedB);


	//	////print values
	//	//for (i = 0; i < row_b; i++)
	//	//{
	//	//	for (j = 0; j < col_b; j++)
	//	//	{
	//	//		fscanf(f_b, "%d", *(mat_b + i) + j);
	//	//		printf("%d ", *(*(mat_b + i) + j));
	//	//	}
	//	//	printf("\n");
	//	//}
	//	//printf("\n");
	//	//fclose(f_b);

	//	//// matrix multiplication not allowed when
	//	//if (col_a != row_b)
	//	//{
	//	//	printf("Matrix multiplication cannot be done.");
	//	//	exit(-1);
	//	//}

	//	//// matrix AB memory allocation 
	//	//int **matAB;
	//	//matAB = (int**)malloc(sizeof(int*) * row_a);

	//	//for (i = 0; i < row_a; i++)
	//	//{
	//	//	*(matAB + i) = (int*)malloc(sizeof(int) * col_b);
	//	//}

	//	//// values in Matrix
	//	//for (i = 0; i < row_a; i++)
	//	//{
	//	//	for (j = 0; j < col_b; j++)
	//	//	{
	//	//		int sum = 0;
	//	//		for (k = 0; k < col_a; k++)
	//	//		{
	//	//			int mul = (*(*(mat_a + i) + k)) * (*(*(mat_b + k) + j));
	//	//			sum += mul;
	//	//		}
	//	//		(*(*(matAB + i) + j)) = sum;

	//	//	}
	//	//}

	//	//// print values 
	//	//printf("AB = \n");
	//	//for (i = 0; i < row_a; i++)
	//	//{
	//	//	for (j = 0; j < col_b; j++)
	//	//	{
	//	//		printf("%d ", *(*(matAB + i) + j));
	//	//	}
	//	//	printf("\n");
	//	//}

	//}


	// 명령행 인자가 4개 이상인 경우 (행렬 .txt파일이 3개 이상인 경우)
	else
	{
		//TODO 
		//행렬 txt가 3개 이상인 경우
		// 순차적으로 1번 2번 행렬을 곱하고 곱한 행렬 값을 메모리에 저장한다
		// 1번과 2번 행렬의 메모리를 free해주고
		// 3번 메모리 공간을 확보하고 값을 저장한다
		// 12곱과 3을 곱하고 123행렬 메모리 할당 + 값을 메모리에 저장한다
		// 12곱과 3의 메모리를 free

		// 이후에도 행렬이 존재한다면 같은 방식으로 
		// 곱이 존재한다면? 곱 메모리가 순차적으로 먼저 생기고, argv[i]를 이동시키면서 해당 행렬을 불러온다.

		


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
//int matmul(int **a, int **b)
//{
//	int row, col; 
//	int col = sizeof(b[0]) / sizeof(int); 이부분이 잘못됐다.
//
//	int **matAB = (int**)malloc(sizeof(int*) * row);
//	for (int i = 0; i < row; i++)
//	{
//		*(matAB + i) = (int*)malloc(sizeof(int) * col);
//	}

	// 함수에 값으로는 입력 인자로 들어온 행렬의 곱 
	//TODO

	//return matAB;
//}
