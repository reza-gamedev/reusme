#include <iostream>
int Wcounter(char x[]);
int main() {
	char x[100];
	std::cin.getline(x,100);
	std::cout << "Number of words : " << Wcounter(x);
	return 0;
}
int Wcounter(char x[]) {
	int i{ 0 };
	int sum{ 1 };
	while (x[i] != '\0') {
		if (x[i] == ' ') {
			sum++;
		}
		i++;
	}
	return sum;
}