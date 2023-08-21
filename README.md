## 🚗🛠️Web Api Diagnostic Guru🛠️🚗

este es el primer componente que alamacena mi proyecto de  diagnostico y revision de vehiculos, en breve se anexara su complemento front.


## mision proyecto

este proyecto tiene como finalidad poder poner a prueba todo lo visto durante las clases y sus respectivos componentes y a su vez convertirse en una evidencia de desarrollo de aprendizaje personal y hacer uso de las buenas practicas a la hora del desarrollo backend.

# Acompañamiento ejecucion

### empezaremos por cambiar las credenciales configuradas por las propias, para seguidamente iniciar las migraciones debido a que la api no esta alojada en una nube,  por tal motivo debemos hacer uso de las migraciones que nos provee el entity framework con proposito de que nuestra api pueda testearse de manera local, este proceso es mu importante.


### ejemplo de reemplazo de credenciales.

estas se encontraran en el archivo json.developent de la carpeta DiagnosticGuruAPI.


![ejemplo: ](/Media/CredencialesDb.PNG)



### una vez cambiadas las credenciales respectivas el proyecto estara listo para inicializar las migraciones.

ya que contamos con una carpeta de migraciones ya creada dentro del proyecto no es necesario hacer uso del comando para crear una nueva migracion, solo ejecutaremos el siguiente comando en la terminal de en este caso vsc

```
dotnet ef database update --project ./Persistencia/ --startup-project ./DiagnosticGuruAPI/
```
una vez ejecutado podemos ir a phpmyadmin, mysqlworkbrench o el entorno de visualizacion de base de datos de tu preferencia y el modelo de base de datos deberia observarse de esta manera. 



![ejemplo: ](/Media/diagramadb.jpg)





este proyecto esta en proceso de desarrollo, una vez se genere un nuevo avance. Esta documentacion sera actualizada y culminada periodicamente dependiendo del avance del proyecto.

## Authors

- [@Angel-ISO](https://www.github.com/Angel-ISO)

## Tecnologias Usadas

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mysql/mysql-original.svg" height="40" alt="mysql logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" height="40" alt="dotnetcore logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" alt="csharp logo"  />
</div>


