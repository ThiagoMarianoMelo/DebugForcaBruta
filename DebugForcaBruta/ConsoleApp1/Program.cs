﻿

using Class.Banco;
using Class.Client;

var banco = new Banco("Banco");
var cliente = new Cliente("Yollanda", 21, 150.00, 50.00);

banco.SacarDinheiro(cliente, 100.00);