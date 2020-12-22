#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

struct matrix {
	int rows;
	int columns;
	int m11;
	int m12;
	int m21;
	int m22;
};

int main()
{
	struct matrix ma;
	FILE *fp_a;
	fp_a = fopen("A.txt", "r");
	fscanf(fp_a, "%d %d %d %d %d %d", &ma.rows, &ma.columns, &ma.m11, &ma.m12, &ma.m21, &ma.m22);
	printf("A = \n%d %d \n%d %d", ma.m11, ma.m12, ma.m21, ma.m22);
	fclose(fp_a);
	
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

	return 0;
}

