# Iniciando con C#
aqui mostrare comandos importates o formas de iniciar para programar en C#.

```dotnet``` sirve para inicar comandos o sentencias mediante la terminal, para el entorno de ```.NET```.
## creación de un .gitignore


si quieres usar un ```VCS (version control system)``` lo principal es tener un archivo que ignore ciertos ficheros, carpetas, etc. En mi caso al usar Github & Git usare ```dotnet new gitignore```. 

El cual hace que git ignore archivos _temporales, generados por compilación, informacion sensible, .env, etc_.

## creación de un proyecto nuevo (terminal)

para crear un nuevo proyecto (```aplicación de consola```) hay que usar el comando ```dotnet new console```, creandonos una estructura con los archivos:

- ```(nombre del proyecto).csproj```
- ```program.cs```