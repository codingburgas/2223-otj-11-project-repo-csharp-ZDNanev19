#include <iostream>
using namespace std;

int main() {
    int rows, cols;
    cin >> rows >> cols;

    int arr[100][100];

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            cin >> arr[i][j];
        }
    }

    for (int i = 0; i < rows; i++) {
        double sum = 0;
        for (int j = 0; j < cols; j++) {
            sum += arr[i][j];
        }
        double avg = sum / cols;
        cout << "The average value of row " << i << " is ";
        if (avg == (int)avg) {
            cout << avg << endl;
        }
        else {
            cout << avg << endl;
        }
    }

    return 0;
}