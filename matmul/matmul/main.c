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
	struct matrix m;
	FILE *fp;
	fp = fopen("B.txt", "r");
	//char string[255];
	//char string2[255];

	//fprintf(fp, "hello world! %d", 1234);

	fscanf(fp, "%d %d %d %d %d %d", &m.rows, &m.columns, &m.m11, &m.m12, &m.m21, &m.m22);
	printf("B = \n%d %d \n%d %d", m.m11, m.m12, m.m21, m.m22);

	fclose(fp);

	return 0;
}

