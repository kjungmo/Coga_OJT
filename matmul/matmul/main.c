#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	FILE* fp = fopen("AA.txt", "r");
	char string[255];
	char string2[255];
	int number;

	//fprintf(fp, "hello world! %d", 1234);

	fscanf(fp, "%s%s%d", string, string2, &number);
	printf("%s %s %d\n", string, string2, number);

	fclose(fp);

	return 0;
}

