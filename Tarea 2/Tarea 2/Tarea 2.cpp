#include <stdio.h>
#include <stdlib.h>

int main() {
	double clientesEntran[6];
	clientesEntran[0] = 12;
	clientesEntran[1] = 0;
	clientesEntran[2] = 23;
	clientesEntran[3] = 45;
	clientesEntran[4] = 21;
	clientesEntran[5] = 0;
	double totalClientes = 0;
	int horaMaxClientes = 0;
	double media;
	int i;

	for (i = 0; i < sizeof(clientesEntran) / sizeof(clientesEntran[0]); i++) {
		totalClientes = totalClientes + clientesEntran[i];
		if (clientesEntran[i] == 0) {
			printf("En la hora %d no entro ningun cliente\n", i + 1);
		}
		if (horaMaxClientes < clientesEntran[i]) {
			horaMaxClientes = i;
		}
	}
	media = totalClientes / 6;

	printf("El total de clientes que entraron al banco en el dia son: %lf\n", totalClientes);
	printf("En la hora %d entro el mayor numero de clientes\n", horaMaxClientes);   
	printf("El numero medio de personas por hora que entraron al banco es: %lf", media);

	return 0;
}