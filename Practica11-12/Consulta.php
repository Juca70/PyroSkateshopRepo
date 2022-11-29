
<?php

include("conexion.php");

$sql = "SELECT * FROM articulo";
$query = mysqli_query($conn,$sql);

$row = mysqli_fetch_array($query);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/Estilo1.css">
    <link rel="stylesheet" href="css/Consulta.css">
    <title>Área de administrador</title>
</head>

<body>
    <div class="bannerUsuario">
        <h3>Hola, usuario</h3>
    </div>
    <div class="bannerFecha">
        <h3>23/11/2022</h3>
    </div>

    <div class="menuLateral">
        <div class="logo">
            <div class="logoP">
                <img id="logo" src="img/LN_PYRO_WHT.jpg" alt="">
            </div>
        </div>
        
        <ul>
            <li class="btnVentanas">
                <div>
                    <img class="icon" src="img/Agregar.png" alt="Registro">
                </div>
                <a>Registrar artículo</a>
            </li>
            <li class="btnVentanas">
                <div>
                    <img class="icon" src="img/Inventario.png" alt="Consultas">
                </div>
                <a>Inventario</a>
            </li>
            <li class="btnVentanas">
                <div>
                    <img class="icon" src="img/Carrito.png" alt="Punto de venta">
                </div>
                <a>Realizar venta</a>
            </li>
            <li class="btnVentanas">
                <div>
                    <img class="icon" src="img/reporte.png" alt="Reporte de ventas">
                </div>
                <a>Reporte de venta</a>
            </li>
            <li class="btnVentanas">
                <div>
                    <img class="icon" src="img/Herramientas.png" alt="Herramientas">
                </div>
                <a>Herramientas</a>
            </li>
            <li class="btnVentanas">
                <div>
                    <img class="icon" src="img/Icono Cerrar Sesión.png" alt="Cerrar Sesión">
                </div>
                <a>Cerrar sesión</a>
            </li>
        </ul>
       
    </div>

    <div class="consulta">
        <div class="barra_consulta">
            <form action="backend/obtenerTodos.php" method="post">
                <input type="text" id="searchterm" name="busqueda" placeholder="Búscar artículo por descripción">
                <input type="submit" id="search" value="Búscar">
            </form>
        </div>

        <div class="tabla">
            <table>

                <?php
                    while($row=mysqli_fetch_array($query)){
                ?>

                <tr>
                  <th>Id</th>
                  <th>Descripción</th>
                  <th>Tipo</th>
                  <th>Categoría</th>
                  <th>Marca</th>
                  <th>Medida</th>
                  <th>Cantidad</th>
                  <th>Precio de venta</th>
                  <th>Precio en dolares</th>
                  <th>Costo de compra</th>
                  <th>Estado</th>  
                </tr>

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
                ?>

            </table>
        </div>
    </div>

</body>
</html>
