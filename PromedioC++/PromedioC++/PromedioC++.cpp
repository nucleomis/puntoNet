/*
Ejercicio # 4
El departamento de Recursos Humanos de la empresa café Combate quiere desarrollar 
un calendario en línea para sus empleados, para calendarizar el número de días hábiles
de trabajo de tal manera que el empleado introduzca un número de mes (1 a 12), y visualice
el número de días de ese mes. Debe considerar que el mes 2 corresponde a febrero que pude
tener 29 o 28 días dependiendo de si es o no bisiesto, el año correspondiente. 
Desarrolle un programa en C++ que cumpla con las especificaciones mencionadas 
y muestre en pantalla el mes, el numero de días y en el caso de que sea año bisiesto 
mostrar el mensaje de que es año bisiesto.
*/

#include <iostream>
using namespace std;

int main()
{
	int numero_meses,anio=0;
	string mes,tipo_anio,tipo_mes;

	cout << "ingrese el anio: ";
	cin >> anio;

	cout << "ingrese el mes en numero: ";
	cin >> numero_meses;

	switch (numero_meses)
	{
	case 1: //si el mes es enero
		mes = "enero";
		break;
	case 2:
		mes = "febrero";
		break;
	case 3:
		mes = "marzo";
		break;
	case 4:
		mes = "abril";
		break;
	case 5:
		mes = "mayo";
		break;
	case 6:
		mes = "junio";
		break;
	case 7:
		mes = "julio";
		break;
	case 8:
		mes = "agosto";
		break;
	case 9:
		mes = "septiembre";
		break;
	case 10:
		mes = "octubre";
		break;
	case 11:
		mes = "noviembre";
		break;
	case 12:
		mes = "diciembre";
		break;
	}

	/*if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
	{
		cout << "el anio es bisiesto" << endl;
		if (numero_meses == 2)
		{
			cout << "el mes es: " << mes << " tiene 29 dias" << endl;
		}
		else if (numero_meses%2==0)
		{
			cout << "el mes es: " << mes << " y tiene: 30 dias" << endl;
		}
		else if (numero_meses%2!=0 && numero_meses!=2){
			cout << "el mes es: " << mes << " y tiene 31 dias" << endl;
		}
	}
	else
	{
		cout << "el anio no es bisiesto" << endl;
		if (numero_meses == 2)
		{
			cout << "el mes es: " << mes << " tiene 28 dias" << endl;
		}
		else if (numero_meses % 2 == 0)
		{
			cout << "el mes es: " << mes << " y tiene: 30 dias" << endl;
		}
		else if (numero_meses % 2 != 0 && numero_meses != 2) {
			cout << "el mes es: " << mes << " y tiene 31 dias" << endl;
		}
	}*/

	(anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0 ? 
		tipo_anio="el anio es bisiesto\n",
		tipo_mes=(numero_meses == 2? "el mes es: "+ mes + " tiene 29 dias":
			(numero_meses % 2 == 0? "el mes es: " + mes + " y tiene: 30 dias":
				(numero_meses % 2 != 0 && numero_meses != 2? "el mes es: " + mes + " y tiene 31 dias":"")))
		:
		tipo_anio= "el anio no es bisiesto\n",
		tipo_mes=(numero_meses == 2? "el mes es: " + mes + " y tiene: 28 dias":
			(numero_meses % 2 == 0? "el mes es: " + mes + " y tiene: 30 dias":
				(numero_meses % 2 != 0 && numero_meses != 2? "el mes es: " + mes + " y tiene 31 dias":"")))
		);

	cout <<"\n"<< tipo_anio << "" << tipo_mes << endl;
	system("pause");
}

