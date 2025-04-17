#include<iostream>
#include<locale>

using namespace std;

int inversor(int numero) {
    int inverter = 0;
    while (numero > 0) {
        inverter = inverter * 10 + numero % 10;
        numero = numero / 10;
    }
    return inverter;
}

int main() {
    setlocale(LC_ALL, "pt_BR.utf8"); 
    int num;
    cout << "Digite um número e ele será invertido: ";
    cin >> num;
    int numero_invertido = inversor(num);
    cout << "Seu número é: " << num << endl;
    cout << "Seu número de forma invertida é: " << numero_invertido << endl;
}