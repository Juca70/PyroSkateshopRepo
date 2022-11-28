<?php

include("conexion.php");

$conn= new mysqli($host, $username, $password, $database);

if ($conn->connect_error) {
    die("Connection failed: ".$conn->connect_error);
}

$sql = "select * from articulo";
$result = $conn->query($sql);

if ($result->num_rows > 0) {

    while($row = $result->fetch_assoc()) {
        echo 
        "id: ".$row["id"].
        ", descripcion: ".$row["descripcion"].
        ", tipo: ".$row["tipo"].
        ", categoria:  ".$row["categoria"].
        ", marca: ".$marcar.$row["marca"].
        ", medida: ".$row["medida"].
        ", existencias: ".$row["cant_existencia"].
        ", precio de venta: ".$row["precio_venta"].
        ", precio en dolares: ".$row["precio_dolares"].
        ", costo de compra: ".$row["costo_compra"].
        ", estado: ".$row["estado"]."<br>";
        // // echo
        // "<tr>".
        //     "<th>".$row["id"]."</th>".
        //     "<th>".$row["descripcion"]."</th>".
        //     "<th>".$row["tipo"]."</th>".
        //     "<th>".$row["categoria"]."</th>".
        //     "<th>".$row["marca"]."</th>".
        //     "<th>".$row["medida"]."</th>".
        //     "<th>".$row["cant_existencia"]."</th>".
        //     "<th>".$row["precio_venta"]."</th>".
        //     "<th>".$row["precio_dolares"]."</th>".
        //     "<th>".$row.["costo_compra"]."</th>".
        //     "<th>".$row["estado"]."</th>".  
        // "</tr>";
    }
}
else {
    echo "0 results";
}

mysqli_close($conn);
?>