#include<stdio.h>

/*
문제

The administrators of algospot.com are so merciful, that they prepared really, really easy problem to prevent contestants from frustration.

입력

Input contains just one positive integer N(N <= 10).

출력

Print N lines. Every line should contain 'Hello Algospot!'(quotation marks for clarity) and nothing else.
*/

int main(void)
{
	int count;

	scanf("%d", &count);

	if (count <= 10)
	{
		for (int i = 0; i<count; i++)
		{
			printf("Hello Algospot!\n");
		}
	}
	return 0;
}