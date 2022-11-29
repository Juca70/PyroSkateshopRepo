<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/Estilo1.css">

    <title>Registro de artículos</title>
    <style>
        html,
        body {
            min-height: 100%;
        }

        body,
        div,
        form,
        input,
        select {
            padding: 0;
            margin: 0;
            outline: none;
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
            font-size: 14px;
            color: rgb(0, 0, 0);
            line-height: 22px;
            border-radius: 15px;
        }

        h4 {
            margin: 20px 0 4px;
            font-weight: 800;
        }

        .testbox {
            display: flex;
            justify-content: center;
            align-items: center;
            height: inherit;
            padding: 3px;
            margin-left: 13.1vw;
            margin-top: 1.5vw;
        }

        form {
            width: 93%;
            padding: 30px;
            background: #EBEBEB;
            box-shadow: 0 5px 5px rgb(187, 187, 187);
        }

        input {
            width: calc(100% - 42px);
            padding: 20px;
            border: 0px solid #ccc;
            box-shadow: 0 5px 5px rgb(187, 187, 187);
            border-radius: 8px;
            vertical-align: middle;
            background: rgb(250, 250, 250);
        }

        select {
            padding: 20px;
            border-radius: 8px;
            border: 0px solid #ccc;
            box-shadow: 0 5px 5px rgb(187, 187, 187);
            background: rgb(250, 250, 250);
            width: 20%;
        }

        input:hover,
        select:hover {
            outline: none;
            background: rgb(255, 255, 255);
            /* border: .5px solid #000000; */
        }

        .title-block select,
        .title-block input {
            margin-bottom: 10px;
        }

        option {
            background: #fff;
        }

        .day-visited,
        .time-visited {
            position: relative;
        }

        input[type="date"]::-webkit-inner-spin-button {
            display: none;
        }

        input[type="time"]::-webkit-inner-spin-button {
            margin: 2px 22px 0 0;
        }

        .day-visited i,
        .time-visited i,
        input[type="date"]::-webkit-calendar-picker-indicator {
            position: absolute;
            top: 8px;
            font-size: 20px;
        }

        .day-visited i,
        .time-visited i {
            right: 5px;
            z-index: 1;
            color: #a9a9a9;
        }

        [type="date"]::-webkit-calendar-picker-indicator {
            right: 0;
            z-index: 2;
            opacity: 0;
        }

        textarea {
            width: calc(100% - 6px);
        }

        .btn-block {
            margin-top: 20px;
            text-align: right;
        }

        button {
            width: 225px;
            height: 50px;
            padding: 10px;
            border: none;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 8px;
            background-color: #E60123;
            font-size: 16px;
            color: #fff;
            cursor: pointer;
        }

        button:hover {
            /* background-color: #0666a3; */
        }

        @media (min-width: 568px) {
            .title-block {
                display: flex;
                justify-content: space-between;

            }

            /* .txtt{
                visibility: hidden;
            } */

            .title-block select {
                width: 30%;
                margin-bottom: 0;
            }

            .title-block input {
                width: 31%;
                margin-bottom: 0;
            }

            th,
            td {
                word-break: keep-all;
            }

            h1 {
                margin-left: 15vw;
                margin-top: 3vw;
                margin-bottom: 1.5vw;
            }

            .titless {
                display: flex;
                justify-content: space-between;
            }
        }

        @media (max-width: 1020px) {
            .txtt {
                visibility: hidden;
            }

            .icon {
                width: 50%;
                height: 50%;
            }
        }
    </style>
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
                <a class="txtt">Registrar artículo</a>
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
    <h1><b>AGREGAR ARTÍCULOS</b></h1>

    <div class="testbox">
        <form action="/">
            <h2>Nuevo artículo</h2>
            <br>
            <hr>
            <div class="titless">
                <h4 class="t1">Categoria</h4>
                <h4 class="t2">Tipo</h4>
                <h4 class="t3">Cantidad</h4>
            </div>
            <div class="title-block">
                    <select>
                        <option value="title" selected>Selecciona categoria</option>
                        <option value="acc">Accesories</option>
                        <option value="bea">Bearings</option>
                        <option value="dec">Decks</option>
                        <option value="fle">Fleece</option>
                        <option value="gar">Garment</option>
                        <option value="gri">Griptape</option>
                        <option value="har">Hardware</option>
                        <option value="hat">Hats</option>
                        <option value="pan">Pants</option>
                        <option value="pro">Protecciones</option>
                        <option value="ribu">Riser pads-bushing</option>
                        <option value="sho">Shoes</option>
                        <option value="soc">Socks</option>
                        <option value="sti">Stickers</option>
                        <option value="tsh">T-Shirt</option>
                        <option value="tru">Truk</option>
                        <option value="wax">Wax</option>
                        <option value="whe">Wheels</option>
                    </select>
                <input class="name" type="" name="name" placeholder="Tipo" />
                <input class="name" type="number" name="name" placeholder="Cantidad" />
            </div>
            <h4>Descripción</h4>
            <input type="text" name="name" placeholder="Descripción" />
            <div class="titless">
                <h4 class="t1">Marca</h4>
                <h4 class="t2">Medida</h4>
            </div>
            <div class="title-block">
                <input class="name" type="" name="name" placeholder="Marca" />
                <input class="name" type="number" name="name" placeholder="Medida" />
            </div>
            <div class="titless">
                <h4 class="t1">Precio de compra</h4>
                <h4 class="t2">Precio en dolares</h4>
                <h4 class="t3">Precio de venta</h4>
            </div>
            <div class="title-block">
                <input class="name" type="number" name="name" placeholder="Precio de compra" />
                <input class="name" type="number" name="name" placeholder="Precio en dolares" />
                <input class="name" type="number" name="name" placeholder="Precio de venta" />
            </div>
            <br>
            <hr>
            <div class="btn-block">
                <button type="submit" href="/">Cancelar</button>
                <button type="submit" href="/">Guardar</button>
            </div>
        </form>
    </div>
</body>

</html>