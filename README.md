# Scripts de Unity
Repositorio de Scripts utilizados en la clases de Unity

<p align="center" style="margin-top: 30px;">

</p>

## Script RestarVida 

Este Script fue creado para poder restarle vida a un objeto y que se destruya, teniendo en cuanta la colision con OnTriggerEnter. 

Pasos para implementar el Script RestarVida:
- Paso 1
- Paso 2
- Paso 3
- Paso 4

## Script InstanciarObjetos

Este Script nos permite crear copias de objetos en tiempo de ejecución, asignando una posición y rotación específicas. Un prefab es una plantilla del objeto que queremos instanciar, el cual consta de tres partes que detallamos a continuacion:

El objeto: Esto se logra mediante la creación de un "prefab" (abreviatura de objeto prefabricado).
La posición: Especificamos la ubicación en la que queremos colocar la instancia del objeto. Esto se logra proporcionando un vector de posición que indique los ejes (X,Y,Z)
La rotación: Similar a la posición pero definimos la rotación de la instancia mediante un vector de rotación. fue creado para poder restarle vida a un objeto y que se destruya, teniendo en cuanta la colision con OnTriggerEnter. 

Pasos para Implementarlo:

- Crear el Prefab arrastrando el objeto que queremos clonar a la carpeta del proyecto.
- Arrastrar y soltar el prefab recien creado en la ventana del inspector, script donde dice objeto.


 


## Script CambiaDireccion 

Este Script fue creado para poder cambiar la direccion de movimiento de un objeto cuando colisione con otro mediante la colision con OnTriggerEnter. 

## Script ManagerEscena  

Este Script fue creado para poder cargar otra escena mediante un boton que se encuentra dentro de un canvas. [Ver Codigo](ManagerEscenas.cs) 

## Script SonidoPickup

SonidoPick nos permite integrar un sonido cuando colisione con otro objeto y asi poder emular agarrar cosas como (pociones, monedas, etc..) para usar este script debemos primero crear una variable publica tipo AudioClip que es la que nos va a permitir agregar el sonido en el unity, tambien tener en cuenta que debemos colocarle un componente AudioSource al objeto que asignemos este script. [Ver Codigo](SonidoPickup.cs) 

