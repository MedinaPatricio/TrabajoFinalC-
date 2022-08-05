/*
 * Creado por SharpDevelop.
 * Usuario: FliaMedinaVillanueva
 * Fecha: 01/06/2022
 * Hora: 14:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 *

			Servicios e1 = new Servicios("Cardialogía","Patricio",30);
			Servicios e2 = new Servicios("Infectología","Matias",25);
			Servicios e3 = new Servicios("Pediatría","Lenadro",5);
			Servicios e4 = new Servicios("Traumatología","Esteban",15);
			Servicios e5 = new Servicios("Guardia","Nicolas",24);
			Servicios e6 = new Servicios("Neurología","Miguel",25);
			Servicios e7 = new Servicios("Oftalmología","Francisco",18);
			Servicios e8 = new Servicios("Terapia intensiva","Julian",30);
			Servicios e9 = new Servicios("COVID-19","Julian",8);
			c1.agregarServicio(e1);
			c1.agregarServicio(e2);
			c1.agregarServicio(e3);
			c1.agregarServicio(e4);
			c1.agregarServicio(e5);
			c1.agregarServicio(e6);
			c1.agregarServicio(e7);
			c1.agregarServicio(e8);
			c1.agregarServicio(e9);
			Medico m0 = new Medico ( 11111,  1,  "Mauro",  "Salinas",  "Cardialogía",  "Mañana");
			Medico m1 = new Medico ( 11112,  2,  "Patricio",  "Medina",  "Cardialogía",  "Tarde");
			Medico m2 = new Medico ( 11113,  3,  "Juana",  "Viale",  "Cardialogía",  "Noche");
			Medico m3 = new Medico ( 11114,  4,  "Juan",  "Perez",  "Infectología",  "Mañana");
			Medico m4 = new Medico ( 11115,  5,  "Jonathan",  "Mendez",  "Infectología",  "Tarde");
			Medico m5 = new Medico ( 11116,  6,  "Mirta",  "Ochoa",  "Infectología",  "Noche");
			Medico m6 = new Medico ( 11117,  7,  "Javier",  "Gomez",  "Pediatría",  "Mañana");
			Medico m7 = new Medico ( 11118,  8,  "Martin",  "Martinez",  "Pediatría",  "Tarde");
			Medico m8 = new Medico ( 11119,  9,  "Homero",  "Simpsons",  "Pediatría",  "Noche");
			Medico m9 = new Medico ( 111110,  10,  "Mauricio",  "Diaz",  "Traumatología",  "Mañana");
			Medico m10 = new Medico ( 111111,  11,  "Sebastian",  "Romero",  "Traumatología",  "Tarde");
			Medico m11 = new Medico ( 111112,  12,  "Bautista",  "Diaz",  "Traumatología",  "Noche");
			Medico m12 = new Medico ( 111113,  13,  "Jose",  "Garcia",  "Guardia",  "Mañana");
			Medico m13 = new Medico ( 111114,  14,  "Jose",  "Garcia",  "Guardia",  "Tarde");
			Medico m14 = new Medico ( 111115,  15,  "Francisco",  "Sosa",  "Guardia",  "Noche");
			Medico m15 = new Medico ( 111116,  16,  "Walter",  "Torres",  "Neurología",  "Mañana");
			Medico m16 = new Medico ( 111117,  17,  "Jorge",  "Ruiz",  "Neurología",  "Tarde");
			Medico m17 = new Medico ( 111118,  18,  "Lorena",  "Villa",  "Neurología",  "Noche");
			Medico m18 = new Medico ( 111119,  19,  "Lucas",  "Flores",  "Oftalmología",  "Mañana");
			Medico m19 = new Medico ( 111120,  20,  "Josefina",  "Acosta",  "Oftalmología",  "Tarde");
			Medico m20 = new Medico ( 111121,  21,  "Benjamin",  "Floresta",  "Oftalmología",  "Noche");
			Medico m21 = new Medico ( 111122,  22,  "Andrea",  "Rojas",  "Terapia intensiva",  "Mañana");
			Medico m22 = new Medico ( 111123,  23,  "Yanina",  "Roa",  "Terapia intensiva",  "Tarde");
			Medico m23 = new Medico ( 111124,  24,  "Martina",  "Altamirano",  "Terapia intensiva",  "Noche");
			Medico m24 = new Medico ( 111125,  25,  "Veronica",  "Sanchez",  "COVID-19",  "Mañana");
			Medico m25 = new Medico ( 111126,  26,  "Juana",  "Benitez",  "COVID-19",  "Tarde");
			Medico m26 = new Medico ( 111127,  27,  "Claudia",  "Mao",  "COVID-19",  "Noche");
			e1.agregarMedicoAUnServicio(m0);
			e1.agregarMedicoAUnServicio(m1);
			e1.agregarMedicoAUnServicio(m2);
			e2.agregarMedicoAUnServicio(m3);
			e2.agregarMedicoAUnServicio(m4);
			e2.agregarMedicoAUnServicio(m5);
			e3.agregarMedicoAUnServicio(m6);
			e3.agregarMedicoAUnServicio(m7);
			e3.agregarMedicoAUnServicio(m8);
			e4.agregarMedicoAUnServicio(m9);
			e4.agregarMedicoAUnServicio(m10);
			e4.agregarMedicoAUnServicio(m11);
			e5.agregarMedicoAUnServicio(m12);
			e5.agregarMedicoAUnServicio(m13);
			e5.agregarMedicoAUnServicio(m14);
			e6.agregarMedicoAUnServicio(m15);
			e6.agregarMedicoAUnServicio(m16);
			e6.agregarMedicoAUnServicio(m17);
			e7.agregarMedicoAUnServicio(m18);
			e7.agregarMedicoAUnServicio(m19);
			e7.agregarMedicoAUnServicio(m20);
			e8.agregarMedicoAUnServicio(m21);
			e8.agregarMedicoAUnServicio(m22);
			e8.agregarMedicoAUnServicio(m23);
			e9.agregarMedicoAUnServicio(m24);
			e9.agregarMedicoAUnServicio(m25);
			e9.agregarMedicoAUnServicio(m26);
			string hoy = DateTime.Now.ToString("dd-MM-yyyy");
			Paciente p1 = new Paciente( "José",  "Morales",  111,  "COVID-19 Positivo", "03/05/1991", hoy,);
			Paciente p2 = new Paciente( "Martin",  "Martinez",  112,  "COVID-19 Positivo", "03/05/1991", hoy);
			Paciente p3 = new Paciente( "Manuela",  "Pérez",  113,  "COVID-19 Positivo", "03/05/1991", hoy);
			Paciente p4 = new Paciente( "Oscar",  "Medina",  114,  "COVID-19 Positivo", "03/05/1991", hoy);
			Paciente p5 = new Paciente( "Javier",  "Taquichiri",  115,  "COVID-19 Positivo", "03/05/1991", hoy);
			Paciente p6 = new Paciente( "Ana",  "Rodriguez",  116,  "COVID-19 Positivo", "03/05/1991", hoy);
			Paciente p7 = new Paciente( "Anabela",  "Villanueva",  117,  "COVID-19 Positivo", "03/05/1991", hoy);
			Paciente p8 = new Paciente( "Josefa",  "Villareal",  118,  "COVID-19 Positivo", "03/05/1991", hoy);
			m24.internarPaciente(p1);
			m25.internarPaciente(p2);
			m26.internarPaciente(p3);
			m24.internarPaciente(p4);
			m25.internarPaciente(p5);
			m26.internarPaciente(p6);
			m24.internarPaciente(p7);
			m25.internarPaciente(p8);


*/

