#include <iostream>
#include <string>
int main(){
std::string data[10];
for (int i = 0;i < 10;i++){
    std::cout << "data [ " << i << " ] = ";
    std::cin >> data[i];
}
return 0;
}