<?php

    //identificaciones para hacer la conexión a la base de datos
    $host ="localhost";
    $username = "root";
    $password = "Marzo2002";

    //nombre de la base de datos a la que se le hará conexión
    $database = "pyrodb";

    session_start();

    $conn = mysqli_connect($host, $username, $password);

    mysql_select_db($conn,$database);

?>