#include <iostream>
int main(){
    int i = 0;
    int k = 0;
    int len = 0;
    int Sum = 0;
    int sum[100];
    char x[100];
    gets(x);
    while(x[i] != '\0'){
        len++;
        i++;
    }
    for (int j = 0;j <= len - 1;j++){
        if (x[j] >= 48 && x[j] <= 57){
            sum[k] = x[j] - 48;
            k++;
        }
    }
    for (int j = 0;j <= len - 1;j++){
        Sum += sum[j];
    }
    std::cout << Sum;
}