#include<stdio.h>

int main(void)
{
	int count = 0;
	int num;

	scanf("%i", &count);
	for (int i = 0; i < count; i++)
	{
		scanf("%d", &num);
	}

	printf("%o\n", num);

	return 0;
}