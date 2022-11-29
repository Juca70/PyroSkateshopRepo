<?php

include("conexion.php");

$conn = conectar();

$sql = "SELECT * FROM articulo";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0) {
    //OUTPUT DATA OF EACH ROW
    while ($row = mysqli_fetch_assoc($result)) { 
?>

<tr>
    <th><?php echo $row['id']?></th>
    <th><?php echo $row['descripcion']?></th>
    <th><?php echo $row['tipo']?></th>
    <th><?php echo $row['categoria']?></th>
    <th><?php echo $row['marca']?></th>
    <th><?php echo $row['medida']?></th>
    <th><?php echo $row['cant_existencia']?></th>
    <th><?php echo $row['precio_venta']?></th>
    <th><?php echo $row['precio_dolares']?></th>
    <th><?php echo $row['costo_compra']?></th>
    <th><?php echo $row['estado']?></th>  
</tr>

<?php
    }
}
?>