#include <iostream>
#include <locale> //Para usar acentuação
#include <windows.h>
using namespace std;

void  ativ1()
{   
    setlocale(LC_ALL, "pt_BR.utf8"); 
    int quantidade;
    cout << "Digite a quantidade de números a serem inseridos: ";
    cin >> quantidade;
    int soma = 0;
    int contador = 0;
    while (quantidade > 0) {
        int numero;
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }

        quantidade--;
    }

    if (contador > 0) {
        double media = static_cast<double>(soma) / contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }

}
void ativ2()
{    
    setlocale(LC_ALL, "pt_BR.utf8"); 
    int soma = 0;
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;
}
void ativ3()
{    
    setlocale(LC_ALL, "pt_BR.utf8"); 
    cout << "Digite um número: ";
    int numero;
    cin >> numero;
    int quadrado = numero * numero;
    int somaDigitos = 0;
    while (quadrado > 0) {
        somaDigitos += quadrado % 10; 
        quadrado /= 10; 
    }

    cout << "A soma dos dígitos do quadrado de " << numero << " é: " << somaDigitos << endl;

}
int main(){
    setlocale(LC_ALL, "pt_BR.utf8"); 
    int opcao;
    do {
        cout << "Escolha uma opção:" << endl;
        cout << "1. Atividade 1" << endl;
        cout << "2. Atividade 2" << endl;
        cout << "3. Atividade 3" << endl;
        cout << "0. Sair" << endl;
        cin >> opcao;

        switch (opcao) {
            case 1:
                ativ1();
                break;
            case 2:
                ativ2();
                break;
            case 3:
                ativ3();
                break;
            case 0:
                cout << "Saindo..." << endl;
                break;
            default:
                cout << "Opção inválida!" << endl;
        }
    } while (opcao != 0);
}
