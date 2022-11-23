<?php

//identificaciones para hacer la conexión a la base de datos
$host ="localhost";
$username = "root";
$password = "Marzo2002";

//nombre de la base de datos a la que se le hará conexión
$database = "pyrodb";

$conn= new mysqli($host, $username, $password, $database);
?>