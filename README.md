# taller-netcore
login y web api con netcore

El presente taller presenta un ejercicio básico de arquitectura MVC con .net core implementando sus tres capas. La aplicación MVC cuenta
con una página de Bienvenida, un formulario de contacto y una página de Login. Para poder acceder a la página de inicio de usuario se debe
ingresar las siguientes credenciales:

usuario: cess
clave: 123

Adicionalmente, se construyó una web api Rest que expone un servicio post que recibe la información del formulario de contacto en api 
en json o xml y la retorna. Para poder consumir el servicio es necesario  acceder a la url: http://localhost:5000/api/WebApi por el método
post y en el body agregar el contenido de la petición ya sea en json o xml. A continuación, un ejemplo:

### XML 
```
<FormContactoWebApi
            xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
            xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            <Nombres>cess</Nombres>
            <Apellidos>sol</Apellidos>
            <Direccion>qwe</Direccion>
            <Telefono>1111111</Telefono>
            <Correo>cesar@javeriana.edu.co</Correo>
            <Comentario>comentario</Comentario>
</FormContactoWebApi>
```

### JSON
```
{
  "Nombres":"cess",
  "Apellidos":"sol",
  "Direccion":"qwe", 
  "Telefono":"12123",
  "Correo":"cess@jave.com",
  "comentario":"qweasd"
}
```
