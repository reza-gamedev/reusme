#include <iostream>
int sutCounter(char x[]);
int main() {
	char x[100];
	std::cin.getline(x,100);
	std::cout << "Number Of 'sut' = " << sutCounter(x);
	return 0;
}
int sutCounter(char x[]) {
	int i{ 0 };
	int sum{ 0 };
	while (x[i] != '\0') {
		int j{ i };
		if (x[j] == 's') {
			if (x[j + 1] == 'u') {
				if (x[j + 2] == 't') {
					sum++;
				}					
			}
		}
		i++;
	}
	return sum;
}