# Alumnos

Programa que permite generar alumnos en formato txt o json y guardarlos en sus respectivos archivos. El formato se puede cambiar en cualquier momento a traves del menu principal.

A cada alumno se le asigna un GUID que sirve para compararlos en los tests y en la búsqueda para no añadirlo si ya existe.
El test para comprobar si el alumno se ha añadido correctamente al archivo funciona.
Se añade un alumno, se busca y se compara el alumno devuelto por la búsqueda con el alumno previamente enviado. Esta comparación se realiza mediante el método Equals que se ha sobreescrito.

El formato se guarda como variable de entorno para ser accesible desde el proyecto principal y desde el test.
Los archivos se guardan en la carpeta Mis Documentos de forma dinámica usando la siguiente variable:
public static string Folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\";