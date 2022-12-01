<?php

function conectar() {
    $servername ="localhost";
    $username = "root";
    $password = "Marzo2002"; //aqui va tu contraseña

    //nombre de la base de datos a la que se le hará conexión
    $database = "pyrodb";

    $conn = mysqli_connect($servername, $username, $password, $database);

    if (!$conn) {
        die ("Connection failed".mysqli_connect_error());
    }

    return $conn;
}

?>