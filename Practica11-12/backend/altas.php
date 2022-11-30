<?php

include("conexion.php");
$conn = conectar();

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

if(isset($_POST["guardar"])) {

    $Categoria = $_POST['categoria'];
    if(($Categoria=$_POST['3'])||($Categoria=$_POST['6'])||($Categoria=$_POST['7'])||($Categoria=$_POST['11'])||($Categoria=$_POST['16'])||($Categoria=$_POST['18'])) {
        $Tipo = 'Hardgoods';
    } else {
        $Tipo = 'Softgoods';
    }
    $Categoria = $_POST['categoria'];
    $Cant = $_POST['cantidad'];
    $Descripcion = $_POST['descripcion'];
    $Marca = $_POST['marca'];
    $Medida = $_POST['medida'];
    $PCompra = $_POST['precioCompra'];
    $PDolar = $_POST['precioDolar'];
    $PVenta = $_POST['precioVenta'];
    $edo = 'Activo';

    $stmt = "INSERT INTO articulo (descripcion, tipo, categoria, marca, medida, cant_existencia, precio_venta, precio_dolares, costo_compra, estado) 
            VALUES ('$Descripcion', '$Tipo', '$Categoria', '$Marca', '$Medida', '$Cant', '$PVenta', '$PDolar', '$PCompra', '$edo')";
    $r = mysqli_query($conn,$stmt);

    if($r) {
        echo "<script>alert('Se agregó correctamente');</script>";
    } else {
        echo "<script>alert('Error');</script>";
    }
}

?>