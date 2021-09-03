# App UWP Gestión Actividades de la Facultad
## Menú principal
En la primera página de la aplicación encontramos el menú principal, el cuál a parte de darnos
la bienvenida, tiene la funcionalidad de navegar entre las distintas páginas de la aplicación; ya
sea a través de los botones con imágenes que describen la finalidad de cada página o mediante
la barra de herramientas inferior (ToolBar).

<div align="center">
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/portada.png" width="500" />
</div>

## Añadir nueva actividad
En esta página se registra la información de dicha actividad (titulo, aula, fecha y hora).

Abajo del todo a través de la barra de herramientas (ToolBar) tenemos tres botones:

• Añadir: nos registra toda la información introducida como una nueva actividad dentro de la ListaActividades. Además, nos informa de que la actividad ha sido introducida satisfactoriamente mediante un mensaje por pantalla (MessageDialog) y nos limpia las cajas de texto y pickers para introducir una nueva actividad.
          
• Limpiar: nos limpia las cajas de texto y los pickers.

• Volver: nos lleva de vuelta a la página del menú de inicio.

<div align="center">
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/addActividad.png" width="500" />
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/addActividad2.png" width="500" />
</div>

## Inscripción de alumnos a actividades
En esta página se introduce la información de un alumno para su inscripción a una actividad.

La barra de herramientas (ToolBar) tiene los mismos botones que la pagina anterior de añadir
actidad, añadiendo esta vez la información como un nuevo alumno en la ListaAlumnos y dentro
de este alumno las actividades a las que se ha inscrito en ListaActividadesAlumno.

<div align="center">
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/inscripcion.png" width="500" />
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/inscripcion2.png" width="500" />
</div>

## Búsqueda de alumnos
Encontramos una caja de texto en la que se introduce un DNI y un botón para buscar en la
ListaAlumnos. Si existe alguien registrado con ese DNI muestra mas a bajo en
un ListView toda la información de dicho alumno y en otro ListView las actividades a las que se
ha inscrito.

Si no encuentra un alumno registrado con ese DNI, muestra el error por pantalla y limpia la
caja de texto para volver a intentarlo.

En la ToolBar encontramos solo el boton de atrás y de limpiar, que limpiar la caja de texto y
vacía los ListView.

<div align="center">
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/busqueda.png" width="500" />
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/busqueda2.png" width="500" />
</div>

## Eliminar alumnos
En esta página al igual que en la anterior de buscar alumnos, encontramos debajo del titulo una
caja de texto para el dni y un boton, pero esta vez para eliminar el alumno que coincida con el
DNI introducido de la ListaAlumnos.

En la ToolBar encontramos un boton para limpiar la caja de texto y otro para volver atrás.

<div align="center">
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/elimiar.png" width="500" />
</div>

## Mostrar alumnos de una actividad
En esta página debajo del titulo encontramos un ListView rellenado con todas las actividades
disponibles en la ListaActividades.

Mas abajo un borde y debajo de este otro ListView que se rellenara cuando clickemos sobre
una actividad con todos los alumnos inscritos a ella.

Cuando clickamos sobre un alumno nos enviara a otra pagina (ShowStudentPage.xaml) donde
se mostrará toda la información de este alumno.

<div align="center">
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/mostrar.png" width="500" />
  <img src="https://github.com/road2root/App-UWP-Gestion-Actividades-de-la-Facultad/blob/main/Capturas/mostrar2.png" width="500" />
</div>
